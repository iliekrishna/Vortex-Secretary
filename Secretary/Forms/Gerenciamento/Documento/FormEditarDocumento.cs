using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class FormEditarDocumento : Form
    {
        private int idDocumento;
        private bool exigeImagem;
        private string nomeCampoImagem;
        private bool obrigatorioSegVia;

        public FormEditarDocumento(int id, string nome, string descricao, string status, bool exigeImagem, string nomeCampoImagem, bool obrigatorioSegVia)
        {
            InitializeComponent();

            idDocumento = id;
            this.exigeImagem = exigeImagem;
            this.nomeCampoImagem = nomeCampoImagem;
            this.obrigatorioSegVia = obrigatorioSegVia;

            txtNomeRequerimento.Text = nome;
            txtPrazo.Text = descricao;

            rbtnAtivo.Checked = (status == "Disponível" || status == "Ativo");
            rbtnInativo.Checked = !rbtnAtivo.Checked;

            if (exigeImagem)
                rdbSim.Checked = true;
            else
                rdbNao.Checked = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string novoNome = txtNomeRequerimento.Text.Trim();
            string novaDescricao = txtPrazo.Text.Trim();
            string novoStatus = rbtnAtivo.Checked ? "Disponível" : "Indisponível";
            bool necessitaImagem = rdbSim.Checked;

            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    // Atualiza documento principal
                    string query = @"UPDATE t_disponibilidade_doc 
                             SET nome_doc = @nome, 
                                 descricao = @desc, 
                                 status_atual = @status,
                                 necessidade_imagem = @img 
                             WHERE id_disponibilidade = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome", novoNome);
                    cmd.Parameters.AddWithValue("@desc", novaDescricao);
                    cmd.Parameters.AddWithValue("@status", novoStatus);
                    cmd.Parameters.AddWithValue("@img", necessitaImagem ? "Sim" : "Não");
                    cmd.Parameters.AddWithValue("@id", idDocumento);

                    cmd.ExecuteNonQuery();
                }

                // --------- CAMPOS DE IMAGEM ----------
                if (necessitaImagem)
                {
                    // Salva ou atualiza campo
                    SalvarOuAtualizarCampoImagem();
                }
                else
                {
                    // Remove campo caso exista
                    RemoverCampoImagem();
                }

                MessageBox.Show("Documento atualizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void SalvarOuAtualizarCampoImagem()
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = @"
            INSERT INTO t_campos_documento 
                (id_disponibilidade, nome_campo, obrigatorio_segunda_via)
            VALUES 
                (@id, @nome, @obrigatorio)
            ON DUPLICATE KEY UPDATE
                nome_campo = @nome,
                obrigatorio_segunda_via = @obrigatorio";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idDocumento);
                cmd.Parameters.AddWithValue("@nome", txtNomeCampo.Text.Trim());
                cmd.Parameters.AddWithValue("@obrigatorio", chkObrigatorio.Checked ? "Sim" : "Não");

                cmd.ExecuteNonQuery();
            }
        }
        private void RemoverCampoImagem()
        {
            using (var conn = ConexaoBD.ObterConexao())
            {
                string sql = "DELETE FROM t_campos_documento WHERE id_disponibilidade = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idDocumento);

                cmd.ExecuteNonQuery();
            }
        }
        private void FormEditarDocumento_Load(object sender, EventArgs e)
        {
            if (exigeImagem)
            {
                rdbSim.Checked = true;
                panelCampoImagem.Visible = true;
                txtNomeCampo.Text = nomeCampoImagem;
                chkObrigatorio.Checked = obrigatorioSegVia;

                this.Size = new Size(611, 456);
                btnSalvar.Location = new Point(461, 369);
            }
            else
            {
                rdbNao.Checked = true;
                panelCampoImagem.Visible = false;

                this.Size = new Size(611, 302);
                btnSalvar.Location = new Point(450, 210);
            }

            rdbSim.CheckedChanged += (s, ev) =>
            {
                if (rdbSim.Checked)
                {
                    panelCampoImagem.Visible = true;

                    this.Size = new Size(611, 456);
                    btnSalvar.Location = new Point(461, 369);
                }
            };

            rdbNao.CheckedChanged += (s, ev) =>
            {
                if (rdbNao.Checked)
                {
                    panelCampoImagem.Visible = false;

                    this.Size = new Size(611, 302);
                    btnSalvar.Location = new Point(450, 210);
                }
            };
        }

    }
}
