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

        public FormEditarDocumento(int id, string nome, string descricao, string status)
        {
            InitializeComponent();

            idDocumento = id;
            txtNomeRequerimento.Text = nome;
            txtPrazo.Text = descricao;

            if (status == "Disponível" || status == "Ativo")
            {
                rbtnAtivo.Checked = true;
            }
            else
            {
                rbtnInativo.Checked = true;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string novoNome = txtNomeRequerimento.Text.Trim();
            string novaDescricao = txtPrazo.Text.Trim();
            string novoStatus = rbtnAtivo.Checked ? "Disponível" : "Indisponível";

            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "UPDATE t_disponibilidade_doc SET nome_doc = @nome, descricao = @desc, status_atual = @status WHERE id_disponibilidade = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", novoNome);
                cmd.Parameters.AddWithValue("@desc", novaDescricao);
                cmd.Parameters.AddWithValue("@status", novoStatus);
                cmd.Parameters.AddWithValue("@id", idDocumento);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Documento atualizado com sucesso!");
            this.Close();
        }
    }
}
