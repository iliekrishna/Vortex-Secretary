using Secretary.Models;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Secretary.Forms.Gerenciamento
{
    public partial class FormEditarFaq : Form
    {
        private Faq _faq;
        private readonly FaqDAO _faqDAO = new FaqDAO();

        public FormEditarFaq(Faq faq)
        {
            InitializeComponent();
            _faq = faq ?? throw new ArgumentNullException(nameof(faq));
            InicializarEventos();
            CarregarCategorias(); // Primeiro carrega as categorias
            CarregarDados();      // Depois carrega os dados (incluindo seleção da categoria)
        }

        public FormEditarFaq(int id, string pergunta, string resposta, int usuarioLogado)
        {
            InitializeComponent();

            var fromDb = _faqDAO.ObterPorId(id);
            if (fromDb != null)
                _faq = fromDb;
            else
                _faq = new Faq
                {
                    Id = id,
                    Pergunta = pergunta ?? string.Empty,
                    Resposta = resposta ?? string.Empty
                };

            InicializarEventos();
            CarregarCategorias(); // Primeiro carrega as categorias
            CarregarDados();      // Depois carrega os dados
        }

        private void InicializarEventos()
        {
            // Remover eventos existentes antes de adicionar novos
            btnSalvar.Click -= btnSalvar_Click_1;
            btnSalvar.Click += btnSalvar_Click_1;

            btnExcluir.Click -= btnExcluir_Click_1;
            btnExcluir.Click += btnExcluir_Click_1;
        }

        private void CarregarDados()
        {
            txtPergunta.Text = _faq.Pergunta ?? "";
            txtResposta.Text = _faq.Resposta ?? "";

            // Selecionar a categoria correta no ComboBox
            if (_faq.IdCategoria > 0)
            {
                cboxCategoria.SelectedValue = _faq.IdCategoria;
            }

            string nomeCriador = "Desconhecido";
            if (_faq.CriadoPor != 0)
                nomeCriador = ObterNomeUsuario(_faq.CriadoPor);

            if (_faq.DataCriacao != DateTime.MinValue)
                lblCriadoPor.Text = $"Criado por {nomeCriador} em {_faq.DataCriacao:dd/MM/yyyy HH:mm}";
            else
                lblCriadoPor.Text = $"Criado por {nomeCriador}";

            if (_faq.AtualizadoPor.HasValue && _faq.DataAtualizacao != DateTime.MinValue)
            {
                string nomeAtualizador = ObterNomeUsuario(_faq.AtualizadoPor.Value);
                lblDataEUsuario.Text = $"Editado por {nomeAtualizador} em {_faq.DataAtualizacao:dd/MM/yyyy HH:mm}";
            }
            else
            {
                lblDataEUsuario.Text = "Sem edições";
            }
        }

        private string ObterNomeUsuario(int idUsuario)
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string sql = "SELECT nome_usuario FROM t_usuarios WHERE id_usuario = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "Desconhecido";
                }
            }
            catch
            {
                return "Desconhecido";
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPergunta.Text) || string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _faq.Pergunta = txtPergunta.Text.Trim();
            _faq.Resposta = txtResposta.Text.Trim();

            // Atualizar a categoria selecionada
            if (cboxCategoria.SelectedValue != null)
            {
                _faq.IdCategoria = (int)cboxCategoria.SelectedValue;
            }

            Usuario usuarioLogado = Sessao.UsuarioLogado;
            _faq.AtualizadoPor = usuarioLogado.Id;

            bool sucesso = _faqDAO.AtualizarFaq(_faq);
            if (sucesso)
            {
                MessageBox.Show("FAQ atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar FAQ.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCategorias()
        {
            var categoriaDAO = new CategoriaDAO();
            var categorias = categoriaDAO.ListarCategorias();

            cboxCategoria.DataSource = categorias;
            cboxCategoria.DisplayMember = "Nome";
            cboxCategoria.ValueMember = "Id";
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tem certeza que deseja excluir esta FAQ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                _faqDAO.Excluir(_faq.Id);
                MessageBox.Show("FAQ excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}