using Secretary.DAO;
using Secretary.Forms.Gerenciamento;
using Secretary.Models;
using System;
using System.Windows.Forms;

namespace Secretary
{
    public partial class FormNovaFaq : Form
    {
        private int _usuarioLogadoId;
        public FormNovaFaq(Usuario usuarioLogado)
        {
            InitializeComponent();
            _usuarioLogadoId = usuarioLogado.Id;
        }
        private void CarregarCategorias()
        {
            var categoriaDAO = new CategoriaDAO();
            var categorias = categoriaDAO.ListarCategorias();

            cboxCategoria.DataSource = categorias;
            cboxCategoria.DisplayMember = "Nome";
            cboxCategoria.ValueMember = "Id";
        }
        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            using (var form = new FormNovaCategoria())
            {
                form.ShowDialog();
                // Depois que fechar, recarregue categorias
                CarregarCategorias();
            }
        }
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPergunta.Text) || string.IsNullOrWhiteSpace(txtResposta.Text) || string.IsNullOrWhiteSpace(cboxCategoria.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            var faq = new Faq
            {
                Pergunta = txtPergunta.Text.Trim(),
                Resposta = txtResposta.Text.Trim(),
                CriadoPor = _usuarioLogadoId,
                IdCategoria = (int)cboxCategoria.SelectedValue
            };

            var faqDAO = new FaqDAO();
            faqDAO.Inserir(faq);

            MessageBox.Show("FAQ adicionada com sucesso!");
            txtPergunta.Clear();
            txtResposta.Clear();
            cboxCategoria.Text = ""; 
            txtPergunta.Focus(); // Foca no campo de pergunta para inserir nova FAQ
        }

        private void FormNovaFaq_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            cboxCategoria.Text = "";
            cboxCategoria.Focus(); // Foca no campo de categoria ao abrir o formulário
        }
    }
}
