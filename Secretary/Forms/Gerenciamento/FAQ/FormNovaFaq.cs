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
        private int _categoriaId;
        private Usuario usuarioLogado;

        public FormNovaFaq(Usuario usuarioLogado, int categoriaId)
        {
            InitializeComponent();
            _usuarioLogadoId = usuarioLogado.Id;
            _categoriaId = categoriaId;
        }


        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPergunta.Text) || string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            var faq = new Faq
            {
                Pergunta = txtPergunta.Text.Trim(),
                Resposta = txtResposta.Text.Trim(),
                CriadoPor = _usuarioLogadoId,
                IdCategoria = _categoriaId
            };

            var faqDAO = new FaqDAO();
            faqDAO.Inserir(faq);

            MessageBox.Show("FAQ adicionada com sucesso!");
            txtPergunta.Clear();
            txtResposta.Clear();
            txtPergunta.Focus();
        }
    }
}