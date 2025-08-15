using Secretary.Models;
using Secretary.DAO;
using System;
using System.Windows.Forms;

namespace Secretary.Forms.Gerenciamento
{
    public partial class FormNovoDocumento : Form
    {
        public FormNovoDocumento()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeDoc.Text.Trim();
            string descricao = txtDescricao.Text.Trim();

            DocumentoDAO dao = new DocumentoDAO(); // ✅ Criar primeiro

            if (dao.ExisteDocumento(nome))
            {
                MessageBox.Show("Já existe um documento com esse nome.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DocumentoDisponivel novoDoc = new DocumentoDisponivel
            {
                Nome = nome,
                Descricao = descricao
            };

            bool sucesso = dao.CadastrarDocumento(novoDoc);

            if (sucesso)
            {
                MessageBox.Show("Documento adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar o documento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}