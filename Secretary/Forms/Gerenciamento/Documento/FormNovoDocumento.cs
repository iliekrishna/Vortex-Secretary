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

            if (_modoEdicao)
            {
                this.Text = "Editar Documento";
                CarregarDadosParaEdicao();
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
        // BOTÃO SALVAR DOCUMENTO (CRIAÇÃO OU EDIÇÃO)
        // ============================================================
        private void btnAdicionar_Click_1(object sender, EventArgs e)
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


    }
}