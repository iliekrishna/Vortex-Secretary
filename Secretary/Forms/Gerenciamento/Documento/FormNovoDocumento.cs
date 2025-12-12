using Secretary.Models;
using Secretary.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms.Gerenciamento
{
    public partial class FormNovoDocumento : Form
    {
        private int? _idDocumentoEditar = null;
        private bool _modoEdicao = false;

        public FormNovoDocumento(int? idDocumentoEditar = null)
        {
            InitializeComponent();

            _idDocumentoEditar = idDocumentoEditar;
            _modoEdicao = idDocumentoEditar.HasValue;

            if (_modoEdicao)
            {
                this.Text = "Editar Documento";
                CarregarDadosParaEdicao();
            }
            else
            {
                // Para novos documentos, desabilitar a combobox inicialmente
                cbTipoGratuidade.Enabled = false;
                cbTipoGratuidade.SelectedItem = "Nenhuma";
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
                cbTipoGratuidade.SelectedItem = doc.TipoGratuidade;

                cbTipoGratuidade.Enabled = (doc.PrecisaPagamentoSegundaVia == 1);
            }
        }

        // ============================================================
        // BOTÃO SALVAR DOCUMENTO
        // ============================================================
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNomeDoc.Text.Trim();
            string descricao = txtDescricao.Text.Trim();
            bool pagamentoTaxa = chbPagamentoTaxa.Checked;
            string tipoGratuidade = cbTipoGratuidade.SelectedItem?.ToString();

            // ------------------- VALIDAÇÕES -------------------

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Preencha os campos obrigatórios (Nome e Descrição).",
                    "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se precisa pagar, não pode deixar tipo de gratuidade como "Nenhuma"
            if (pagamentoTaxa && tipoGratuidade == "Nenhuma")
            {
                MessageBox.Show("Selecione o limite de gratuidade para documentos que possuem taxa de segunda via.",
                    "Seleção obrigatória", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    // ------------------- EDIÇÃO -------------------
                    DocumentoDisponivel docEditado = new DocumentoDisponivel
                    {
                        Id = _idDocumentoEditar.Value,
                        Nome = nome,
                        Descricao = descricao,
                        PrecisaPagamentoSegundaVia = pagamentoTaxa ? 1 : 0,
                        TipoGratuidade = tipoGratuidade,
                        StatusAtual = "Disponível"
                    };

                    dao.Atualizar(docEditado);

                    MessageBox.Show("Documento atualizado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // ------------------- CRIAÇÃO -------------------
                    DocumentoDisponivel novoDoc = new DocumentoDisponivel
                    {
                        Nome = nome,
                        Descricao = descricao,
                        PrecisaPagamentoSegundaVia = pagamentoTaxa ? 1 : 0,
                        TipoGratuidade = tipoGratuidade,
                        StatusAtual = "Disponível"
                    };

                    dao.Inserir(novoDoc);

                    _idDocumentoEditar = dao.ObterUltimoIdInserido();
                    _modoEdicao = true;

                    MessageBox.Show("Documento adicionado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnAdicionar.Text = "Salvar Alterações";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // CHECKBOX — HABILITA/DESABILITA GRATUIDADE
        // ============================================================
        private void chbPagamentoTaxa_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPagamentoTaxa.Checked)
            {
                cbTipoGratuidade.Enabled = true;

                // Se estava "Nenhuma", sugere a primeira gratuidade
                if (cbTipoGratuidade.SelectedItem != null &&
                    cbTipoGratuidade.SelectedItem.ToString() == "Nenhuma")
                {
                    cbTipoGratuidade.SelectedItem = "Curso";
                }
            }
            else
            {
                cbTipoGratuidade.SelectedItem = "Nenhuma";
                cbTipoGratuidade.Enabled = false;
            }
        }
    }
}
