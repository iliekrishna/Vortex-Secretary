using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Secretary.Forms
{
    public partial class FormEditarUsuario : Form
    {
        private int idUsuario;

        public FormEditarUsuario(int id, string nomeUsuario, string email, string tipoUsuario)
        {
            InitializeComponent();

            idUsuario = id;
            txtNome.Text = nomeUsuario;
            txtEmail.Text = email;

            // Mapeia ADM/USER para o texto visível na ComboBox
            string tipoExibido = tipoUsuario == "ADM" ? "Administrador" : "Usuário Comum";

            // Garante que o valor está presente na ComboBox
            if (cboxTipoUsuario.Items.Contains(tipoExibido))
            {
                cboxTipoUsuario.SelectedItem = tipoExibido;
            }
            else
            {
                MessageBox.Show($"Tipo de usuário desconhecido: {tipoUsuario}");
            }
        }


        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 350);
            btnAtualizar.Location = new Point(671, 233);
            btnExcluirUsuario.Location = new Point(671, 267);
        }

        private void linklblAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelAlterarSenha.Visible = !panelAlterarSenha.Visible;

            if (panelAlterarSenha.Visible)
            {
                this.Size = new Size(900, 500); // aumenta a altura do form
                btnAtualizar.Location = new Point(671, 418); // posição mais abaixo
                btnExcluirUsuario.Visible = false;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.Size = new Size(900, 350); // volta ao tamanho original
                btnAtualizar.Location = new Point(671, 233); // volta à posição original
                btnExcluirUsuario.Visible = true;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este usuário?",
                                          "Confirmação",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conexao = ConexaoBD.ObterConexao())
                    {
                        string query = "DELETE FROM t_usuarios WHERE id_usuario = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conexao);
                        cmd.Parameters.AddWithValue("@id", idUsuario);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuário excluído com sucesso.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir usuário: " + ex.Message);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string novoNome = txtNome.Text.Trim();
            string novoEmail = txtEmail.Text.Trim();
            string tipoSelecionado = cboxTipoUsuario.SelectedItem?.ToString();
            string novoTipo = tipoSelecionado == "Administrador" ? "ADM" : "USER";

            if (string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novoEmail) || string.IsNullOrWhiteSpace(novoTipo))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se o painel de senha estiver visível, tenta alterar a senha
            if (panelAlterarSenha.Visible)
            {
                bool senhaAlterada = AlterarSenha();

                if (!senhaAlterada)
                {
                    // Se senha incorreta ou erro na alteração, para aqui.
                    return;
                }
            }

            // Se chegou aqui, senha correta ou painel de senha não estava visível
            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    string query = "UPDATE t_usuarios SET nome_usuario = @nome, email_usuario = @email, tipo_perfil = @tipo WHERE id_usuario = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome", novoNome);
                    cmd.Parameters.AddWithValue("@email", novoEmail);
                    cmd.Parameters.AddWithValue("@tipo", novoTipo);
                    cmd.Parameters.AddWithValue("@id", idUsuario);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuário atualizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AlterarSenha()
        {
            string senhaAtual = txtSenhaAtual.Text.Trim();
            string novaSenha = txtSenhaNova.Text.Trim();
            string confirmarSenha = txtConfirmarSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(senhaAtual) || string.IsNullOrWhiteSpace(novaSenha) || string.IsNullOrWhiteSpace(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos de senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas novas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    string queryVerifica = "SELECT senha_hash FROM t_usuarios WHERE id_usuario = @id";
                    MySqlCommand cmdVerifica = new MySqlCommand(queryVerifica, conexao);
                    cmdVerifica.Parameters.AddWithValue("@id", idUsuario);
                    object result = cmdVerifica.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    string hashBanco = result.ToString();

                    if (!BCrypt.Net.BCrypt.Verify(senhaAtual, hashBanco))
                    {
                        MessageBox.Show("A senha atual está incorreta.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    string novaSenhaHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);

                    string queryAtualizaSenha = "UPDATE t_usuarios SET senha_hash = @senha WHERE id_usuario = @id";
                    MySqlCommand cmdAtualiza = new MySqlCommand(queryAtualizaSenha, conexao);
                    cmdAtualiza.Parameters.AddWithValue("@senha", novaSenhaHash);
                    cmdAtualiza.Parameters.AddWithValue("@id", idUsuario);
                    cmdAtualiza.ExecuteNonQuery();

                    MessageBox.Show("Senha alterada com sucesso!");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
