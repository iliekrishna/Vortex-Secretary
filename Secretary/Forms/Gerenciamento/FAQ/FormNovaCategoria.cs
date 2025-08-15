using Secretary.DAO;
using System;
using System.Windows.Forms;

namespace Secretary.Forms.Gerenciamento
{
    public partial class FormNovaCategoria : Form
    {
        public FormNovaCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeCategoria = txtCategoria.Text.Trim();

            if (string.IsNullOrEmpty(nomeCategoria))
            {
                MessageBox.Show("O nome da categoria não pode estar vazio.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var categoriaDAO = new CategoriaDAO();
                categoriaDAO.Inserir(nomeCategoria);

                MessageBox.Show("Categoria criada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCategoria.Clear();
                txtCategoria.Focus(); // foca para inserir rápido nova categoria
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar categoria: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSalvar.PerformClick();
            }
        }
    }
}