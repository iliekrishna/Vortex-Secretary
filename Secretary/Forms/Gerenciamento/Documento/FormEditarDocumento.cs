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

        private void FormEditarDocumento_Load(object sender, EventArgs e)
        {
            CarregarCampos();
        }


        // ===========================================
        // CARREGAR LISTA DE CAMPOS
        // ===========================================
        private void CarregarCampos()
        {
            panelCampos.Controls.Clear();

            CampoDocumentoDAO dao = new CampoDocumentoDAO();
            var campos = dao.ListarPorDocumento(idDocumento);

            int y = 10;

            foreach (var campo in campos)
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Size = new Size(560, 48);
                card.Location = new Point(10, y);
                card.BackColor = Color.WhiteSmoke;

                Label lbl = new Label();
                lbl.Text = $"{campo.NomeCampo}  ({campo.TipoCampo})";
                lbl.Font = new Font("Verdana", 9, FontStyle.Bold);
                lbl.Location = new Point(10, 14);
                lbl.AutoSize = true;

                Button btnEditar = new Button();
                btnEditar.Text = "Editar";
                btnEditar.Size = new Size(80, 26);
                btnEditar.Location = new Point(370, 10);
                btnEditar.Click += (s, e) =>
                {
                    var editForm = new Secretary.Forms.Gerenciamento.Documento.FormAdicionarCampo(idDocumento, campo);
                    editForm.FormClosed += (x, z) => CarregarCampos();
                    editForm.ShowDialog();
                };

                Button btnExcluir = new Button();
                btnExcluir.Text = "Excluir";
                btnExcluir.Size = new Size(80, 26);
                btnExcluir.Location = new Point(460, 10);
                btnExcluir.ForeColor = Color.Red;

                btnExcluir.Click += (s, e) =>
                {
                    if (MessageBox.Show("Deseja realmente excluir este campo?",
                        "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dao.Excluir(campo.IdCampo);
                        CarregarCampos();
                    }
                };

                card.Controls.Add(lbl);
                card.Controls.Add(btnEditar);
                card.Controls.Add(btnExcluir);

                panelCampos.Controls.Add(card);

                y += 55;
            }

            // ============================================================
            // AJUSTA O TAMANHO DO FORM SE EXISTIREM CAMPOS EXTRAS
            // ============================================================
            if (campos.Count > 0)
            {
                // Existe pelo menos um campo extra
                this.Size = new Size(611, 656);
                panelCampos.Visible = true;
                this.CenterToScreen();

            }
            else
            {
                // Não existe campo algum
                this.Size = new Size(611, 378);
                panelCampos.Visible = false;
                this.CenterToScreen();

            }
        }

        // ===========================================
        // SALVAR ALTERAÇÕES DO DOCUMENTO
        // ===========================================
        private void btnSalvar_Click_1(object sender, EventArgs e)
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

        // ===========================================
        // ABRIR FORM DE ADICIONAR CAMPOS
        // ===========================================

        private void btnAdicionarCampo_Click_1(object sender, EventArgs e)
        {
            var formCampo = new Secretary.Forms.Gerenciamento.Documento.FormAdicionarCampo(idDocumento);
            formCampo.FormClosed += (s, args) => CarregarCampos();
            formCampo.ShowDialog();
        }
    }
}
