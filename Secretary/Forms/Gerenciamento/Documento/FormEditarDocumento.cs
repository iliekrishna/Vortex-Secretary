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
        private string tipoGratuidadeAtual;

        public FormEditarDocumento(int id, string nome, string descricao, string status, int precisaPagamentoSegVia, string tipoGratuidade)
        {
            InitializeComponent();

            idDocumento = id;

            txtNomeRequerimento.Text = nome;
            txtPrazo.Text = descricao;

            // Status
            rbtnAtivo.Checked = status == "Disponível" || status == "Ativo";
            rbtnInativo.Checked = !rbtnAtivo.Checked;

            // Taxa
            chbPagamentoTaxa.Checked = (precisaPagamentoSegVia == 1);

            // Gratuidade
            tipoGratuidadeAtual = tipoGratuidade;

            cbTipoGratuidade.SelectedItem = tipoGratuidadeAtual;

            cbTipoGratuidade.Enabled = (precisaPagamentoSegVia == 1);

            // Evento do checkbox
            chbPagamentoTaxa.CheckedChanged += chbPagamentoTaxa_CheckedChanged;
        }

        // ============================================================
        // VALIDAÇÃO E SALVAMENTO
        // ============================================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string novoNome = txtNomeRequerimento.Text.Trim();
            string novaDescricao = txtPrazo.Text.Trim();
            string novoStatus = rbtnAtivo.Checked ? "Disponível" : "Indisponível";
            int pagamento = chbPagamentoTaxa.Checked ? 1 : 0;

            string tipoGratuidadeNovo = cbTipoGratuidade.SelectedItem?.ToString() ?? "Nenhuma";

            // ------------------ VALIDAÇÃO ------------------

            if (string.IsNullOrWhiteSpace(novoNome) || string.IsNullOrWhiteSpace(novaDescricao))
            {
                MessageBox.Show("Preencha os campos obrigatórios (Nome e Descrição).",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pagamento == 1 && tipoGratuidadeNovo == "Nenhuma")
            {
                MessageBox.Show("Selecione o tipo de gratuidade para documentos que possuem taxa.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conexao = ConexaoBD.ObterConexao())
                {
                    string query = @"
                        UPDATE t_disponibilidade_doc 
                        SET nome_doc = @nome,
                            descricao = @desc,
                            status_atual = @status,
                            precisa_pagamento_segunda_via = @pagamento,
                            tipo_gratuidade = @tipoGratuidade
                        WHERE id_disponibilidade = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    cmd.Parameters.AddWithValue("@nome", novoNome);
                    cmd.Parameters.AddWithValue("@desc", novaDescricao);
                    cmd.Parameters.AddWithValue("@status", novoStatus);
                    cmd.Parameters.AddWithValue("@pagamento", pagamento);
                    cmd.Parameters.AddWithValue("@tipoGratuidade", tipoGratuidadeNovo);
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

        // ============================================================
        // CHECKBOX — habilita/desabilita combobox
        // ============================================================
        private void chbPagamentoTaxa_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPagamentoTaxa.Checked)
            {
                cbTipoGratuidade.Enabled = true;

                if (cbTipoGratuidade.SelectedItem.ToString() == "Nenhuma")
                    cbTipoGratuidade.SelectedItem = "Curso";
            }
            else
            {
                cbTipoGratuidade.SelectedItem = "Nenhuma";
                cbTipoGratuidade.Enabled = false;
            }
        }
    }
}
