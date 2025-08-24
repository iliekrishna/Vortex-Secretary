using Secretary.DAO;
using Secretary.Forms.Gerenciamento;
using Secretary.Forms.Gerenciamento.FAQ;
using Secretary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Secretary.Forms.Gerenciamento.FAQ
{
    public partial class FormFaqs : Form
    {
        private Categoria _categoria;

        public FormFaqs(Categoria categoria)
        {
            InitializeComponent();
            _categoria = categoria;
            Load += FormFaqs_Load;
        }

        private void FormFaqs_Load(object sender, EventArgs e)
        {
            txtNomeCategoria.Text = _categoria.Nome;
            CarregarPerguntas();
        }

        private void CarregarPerguntas()
        {
            flowLayoutPanelPerguntas.Controls.Clear(); // Limpa as perguntas antes de carregar
            FaqDAO faqDao = new FaqDAO();
            List<Faq> faqs = faqDao.ListarTodos().Where(f => f.IdCategoria == _categoria.Id).ToList();

            foreach (var faq in faqs)
            {
                flowLayoutPanelPerguntas.Controls.Add(CriarPanelFaq(faq));
            }
        }

        private Panel CriarPanelFaq(Faq faq)
        {
            Panel panelFaq = new Panel
            {
                Size = new Size(flowLayoutPanelPerguntas.Width - 20, 50),
                Margin = new Padding(0, 0, 0, 10),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblPergunta = new Label
            {
                Text = faq.Pergunta,
                AutoSize = true,
                Location = new Point(20, 15),
                Font = new Font("Verdana", 10F)
            };

            Button btnEditar = new Button
            {
                Text = "Editar",
                Font = new Font("Verdana", 9F),
                Size = new Size(80, 25),
                Location = new Point(panelFaq.Width - 100, 12),
                Tag = faq,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };

            btnEditar.Click += (s, e) => EditarFaq(faq);

            panelFaq.Controls.Add(lblPergunta);
            panelFaq.Controls.Add(btnEditar);

            return panelFaq;
        }
        private void EditarFaq(Faq faq)
        {
            using (var formEditarFaq = new FormEditarFaq(faq))
            {
                formEditarFaq.FormClosed += (s, args) => CarregarPerguntas(); // Recarregar perguntas após edição
                formEditarFaq.ShowDialog();
            }
        }

        private void btnEditarNome_Click_1(object sender, EventArgs e)
        {
            // Lógica para editar o nome da categoria
            CategoriaDAO categoriaDao = new CategoriaDAO();
            categoriaDao.AtualizarNome(_categoria.Id, txtNomeCategoria.Text);
            MessageBox.Show("Categoria alterada com sucesso!");
        }
        private void btnAdicionarNovaPergunta_Click(object sender, EventArgs e)
        {
            using (var formNovaFaq = new Secretary.FormNovaFaq(Sessao.UsuarioLogado, _categoria.Id))
            {
                formNovaFaq.FormClosed += (s, args) => CarregarPerguntas();
                formNovaFaq.ShowDialog();
            }
        }
        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            // Lógica para excluir a categoria e suas perguntas
            var confirm = MessageBox.Show("Tem certeza que deseja excluir esta Categoria? As perguntas contidas nesse espaço também serão deletadas.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                CategoriaDAO categoriaDao = new CategoriaDAO();
                categoriaDao.Excluir(_categoria.Id);
                MessageBox.Show("Categoria e perguntas excluídas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
