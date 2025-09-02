using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Secretary;            // ConexaoBD
using Secretary.DAO;        // UsuarioDAO
using Secretary.Models;     // Usuario

namespace Secretary.Forms
{
    public partial class FormPerfilUsuario : Form
    {
        public FormPerfilUsuario()
        {
            InitializeComponent();
        }

        private void FormPerfilUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarDadosUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar perfil: " + ex.Message, "Perfil do Usuário",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDadosUsuario()
        {
            if (Sessao.UsuarioLogado == null)
            {
                MessageBox.Show("Nenhum usuário logado.");
                return;
            }

            var usuario = Sessao.UsuarioLogado;

            using (MySqlConnection conn = ConexaoBD.ObterConexao())
            {
                // Busca dados atualizados no banco
                var usuarioDAO = new UsuarioDAO();
                usuario = usuarioDAO.BuscarPorEmail(usuario.Email, conn);

                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado no banco.");
                    return;
                }

                // Campos básicos
                txtNomeUsuario.Text = usuario.Nome;
                txtLoginUsuario.Text = usuario.Email;
                string tipoAmigavel;
                switch (usuario.TipoPerfil?.ToUpper())
                {
                    case "ADM":
                        tipoAmigavel = "Administrador";
                        break;
                    case "USER":
                        tipoAmigavel = "Usuário comum";
                        break;
                    default:
                        tipoAmigavel = "Não definido";
                        break;
                }

                txtTipoUsuario.Text = tipoAmigavel;
                txtCriadoEm.Text = (usuario.CriadoEm == default(DateTime))
                                        ? ""
                                        : usuario.CriadoEm.ToString("dd/MM/yyyy");

                // Contagem de tickets
                string sqlTickets = @"
                SELECT COUNT(*) 
                FROM t_tickets 
                WHERE id_usuario = @id
                  AND resposta IS NOT NULL AND resposta <> ''
                  AND (LOWER(status) = 'respondido' OR LOWER(status) = 'cancelado');";

                using (var cmd = new MySqlCommand(sqlTickets, conn))
                {
                    cmd.Parameters.AddWithValue("@id", usuario.Id);
                    txtTicketsAtendidos.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }

                // Contagem de requerimentos
                string sqlReq = @"
                SELECT COUNT(*)
                FROM t_requerimentos
                WHERE id_usuario = @id
                  AND resposta IS NOT NULL AND resposta <> '';";

                using (var cmd = new MySqlCommand(sqlReq, conn))
                {
                    cmd.Parameters.AddWithValue("@id", usuario.Id);
                    txtReqAtendidos.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                }
            }
        }
    }
}