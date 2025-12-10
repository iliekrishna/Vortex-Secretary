using MySql.Data.MySqlClient;
using Secretary.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class FormEditarDocumento : Form
    {
        private int idDocumento;

        public FormEditarDocumento(int id, string nome, string descricao, string status, int precisaPagamentoSegVia)
        {
            InitializeComponent();

            idDocumento = id;

            txtNomeRequerimento.Text = nome;
            txtPrazo.Text = descricao;

            rbtnAtivo.Checked = status == "Disponível" || status == "Ativo";
            rbtnInativo.Checked = !rbtnAtivo.Checked;

            chbPagamentoTaxa.Checked = (precisaPagamentoSegVia == 1);
        }

        // ===========================================
        // SALVAR ALTERAÇÕES DO DOCUMENTO
        // ===========================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string novoNome = txtNomeRequerimento.Text.Trim();
            string novaDescricao = txtPrazo.Text.Trim();
            string novoStatus = rbtnAtivo.Checked ? "Disponível" : "Indisponível";
            int pagamento = chbPagamentoTaxa.Checked ? 1 : 0;

            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    string query = @"
                        UPDATE t_disponibilidade_doc 
                        SET nome_doc = @nome,
                            descricao = @desc,
                            status_atual = @status,
                            precisa_pagamento_segunda_via = @pagamento
                        WHERE id_disponibilidade = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@nome", novoNome);
                    cmd.Parameters.AddWithValue("@desc", novaDescricao);
                    cmd.Parameters.AddWithValue("@status", novoStatus);
                    cmd.Parameters.AddWithValue("@pagamento", pagamento);
                    cmd.Parameters.AddWithValue("@id", idDocumento);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Documento atualizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
