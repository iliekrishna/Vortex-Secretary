using Secretary.Models;
using Secretary.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms.Gerenciamento
{
    public partial class FormNovoDocumento : Form
    {
        private int? _idDocumentoEditar = null;  // Null para criação, valor para edição
        private bool _modoEdicao = false;

        public FormNovoDocumento(int? idDocumentoEditar = null)
        {
            InitializeComponent();

            _idDocumentoEditar = idDocumentoEditar;
            _modoEdicao = idDocumentoEditar.HasValue;

            btnAdicionarCampo.Enabled = false;  // Só libera após salvar documento (criação) ou sempre em edição

            if (_modoEdicao)
            {
                this.Text = "Editar Documento";
                btnAdicionarCampo.Text = "Salvar Alterações";
                btnAdicionarCampo.Enabled = true;  // Em edição, sempre habilitado
                CarregarDadosParaEdicao();
                CarregarCampos();
            }
        }

        private void CarregarDadosParaEdicao()
        {
            DocumentoDAO dao = new DocumentoDAO();
            var doc = dao.BuscarPorId(_idDocumentoEditar.Value);

            if (doc != null)
            {
                txtNomeDoc.Text = doc.Nome;
                txtDescricao.Text = doc.Descricao;
                chbPagamentoTaxa.Checked = doc.PrecisaPagamentoSegundaVia == 1;
            }
        }

        // ============================================================
        // CARREGAR A LISTA DE CAMPOS DO DOCUMENTO
        // ============================================================
        private void CarregarCampos()
        {
            this.CenterToScreen();

            panelCampos.Controls.Clear();

            CampoDocumentoDAO dao = new CampoDocumentoDAO();
            var campos = dao.ListarPorDocumento(_idDocumentoEditar ?? 0);  // Usa ID se edição, senão 0 (não carrega)

            int y = 10;

            foreach (var campo in campos)
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Size = new Size(560, 48);
                card.Location = new Point(10, y);
                card.BackColor = Color.WhiteSmoke;

                Label lbl = new Label();
                lbl.Text = $"{campo.NomeCampo}  ({campo.TipoCampo})";
                lbl.Font = new Font("Verdana", 9, FontStyle.Bold);
                lbl.Location = new Point(10, 14);
                lbl.AutoSize = true;

                Button btnEditar = new Button();
                btnEditar.Text = "Editar";
                btnEditar.Size = new Size(80, 26);
                btnEditar.Location = new Point(370, 10);
                btnEditar.Click += (s, e) =>
                {
                    var editForm = new Secretary.Forms.Gerenciamento.Documento.FormAdicionarCampo(_idDocumentoEditar.Value, campo);
                    editForm.FormClosed += (x, z) => CarregarCampos();
                    editForm.ShowDialog();
                };

                Button btnExcluir = new Button();
                btnExcluir.Text = "Excluir";
                btnExcluir.Size = new Size(80, 26);
                btnExcluir.Location = new Point(460, 10);
                btnExcluir.ForeColor = Color.Red;

                btnExcluir.Click += (s, e) =>
                {
                    if (MessageBox.Show("Deseja realmente excluir este campo?",
                        "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dao.Excluir(campo.IdCampo);
                        CarregarCampos();
                    }
                };

                card.Controls.Add(lbl);
                card.Controls.Add(btnEditar);
                card.Controls.Add(btnExcluir);

                panelCampos.Controls.Add(card);

                y += 55;
            }

            // ============================================================
            // AJUSTA O TAMANHO DO FORM SE EXISTIREM CAMPOS EXTRAS
            // ============================================================
            if (campos.Count > 0)
            {
                // Existe pelo menos um campo extra
                this.Size = new Size(611, 656);
                panelCampos.Visible = true;
                this.CenterToScreen();

            }
            else
            {
                // Não existe campo algum
                this.Size = new Size(611, 378);
                panelCampos.Visible = false;
                this.CenterToScreen();

            }
        }
        
        // ============================================================
        // ABRIR TELA PARA ADICIONAR CAMPO
        // ============================================================
        private void btnAdicionarCampo_Click_1(object sender, EventArgs e)
        {    
            if (!_idDocumentoEditar.HasValue || _idDocumentoEditar.Value == 0)
            {
                MessageBox.Show("Salve o documento antes de adicionar campos.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var formCampo = new Secretary.Forms.Gerenciamento.Documento.FormAdicionarCampo(_idDocumentoEditar.Value);
            formCampo.FormClosed += (s, args) => CarregarCampos();
            formCampo.ShowDialog();
        }

        // ============================================================
        // BOTÃO SALVAR DOCUMENTO (CRIAÇÃO OU EDIÇÃO)
        // ============================================================
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeDoc.Text.Trim();
            string descricao = txtDescricao.Text.Trim();
            bool pagamentoTaxa = chbPagamentoTaxa.Checked;

            // Campos obrigatórios
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Preencha os campos obrigatórios (Nome e Descrição).",
                    "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DocumentoDAO dao = new DocumentoDAO();

            // Verifica duplicatas
            if (_modoEdicao)
            {
                if (dao.ExisteDocumentoExcetoId(nome, _idDocumentoEditar.Value))
                {
                    MessageBox.Show("Já existe um documento com esse nome.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (dao.ExisteDocumento(nome))
                {
                    MessageBox.Show("Já existe um documento com esse nome.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                if (_modoEdicao)
                {
                    // EDIÇÃO
                    DocumentoDisponivel docEditado = new DocumentoDisponivel
                    {
                        Id = _idDocumentoEditar.Value,
                        Nome = nome,
                        Descricao = descricao,
                        PrecisaPagamentoSegundaVia = pagamentoTaxa ? 1 : 0,
                        StatusAtual = "Disponível"
                    };

                    dao.Atualizar(docEditado);

                    MessageBox.Show("Documento atualizado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // CRIAÇÃO
                    DocumentoDisponivel novoDoc = new DocumentoDisponivel
                    {
                        Nome = nome,
                        Descricao = descricao,
                        PrecisaPagamentoSegundaVia = pagamentoTaxa ? 1 : 0,
                        StatusAtual = "Disponível"
                    };

                    dao.Inserir(novoDoc);

                    _idDocumentoEditar = dao.ObterUltimoIdInserido();
                    _modoEdicao = true;

                    MessageBox.Show("Documento adicionado com sucesso! Agora você pode criar campos adicionais.",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnAdicionar.Text = "Salvar Alterações";
                    btnAdicionarCampo.Enabled = true;  // Habilita botão de campos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}