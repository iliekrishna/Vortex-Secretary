using MySql.Data.MySqlClient;
using Secretary.Forms.Atendimentos;
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
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            // Adiciona os filtros à ComboBox
            cmbFiltroStatus.Items.Add("Todos");
            cmbFiltroStatus.Items.Add("Pendente");
            cmbFiltroStatus.Items.Add("Respondido");
            cmbFiltroStatus.Items.Add("Cancelado");

            cmbFiltroStatus.SelectedIndex = 0; // Define "Todos" como padrão

            CarregarTickets();
            CarregarRequerimentos();

            //dgvHistoricoT.CellContentClick += dgvHistoricoT_CellContentClick;
            dgvHistoricoR.CellContentClick += dgvHistoricoR_CellContentClick;

            TxtCinza();
        }

        private void CarregarTickets()
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string filtro = cmbFiltroStatus.SelectedItem?.ToString();
                    string query = @"
               SELECT t_tickets.*, t_usuarios.nome_usuario AS nome_usuario
    FROM t_tickets
    LEFT JOIN t_usuarios ON t_tickets.id_usuario = t_usuarios.id_usuario"; // Puxa dados de t_tickets e nome_usuario de t_usuario.

                    if (filtro == "Pendente")
                        query += " WHERE status = 'Pendente'";
                    else if (filtro == "Cancelado")
                        query += " WHERE status = 'Cancelado'";
                    else if (filtro == "Respondido")
                        query += " WHERE status = 'Respondido'"; // Aplicam os filtros de acordo com oque é selecionado no cbbox

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistoricoT.Columns.Clear(); //Remove colunas erradas
                        dgvHistoricoT.DataSource = dt;
                        dgvHistoricoT.Columns["nome_usuario"].DisplayIndex = 13; // Poe a coluna respondido por no local correto

                        // Oculta a coluna id_usuario
                            dgvHistoricoT.Columns["id_usuario"].Visible = false; 

                        
                        RenomearColunasT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tickets: " + ex.Message);
            }
        }

        private void CarregarRequerimentos()
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string filtro = cmbFiltroStatus.SelectedItem?.ToString();
                    string query = @"
               SELECT t_requerimentos.*, t_usuarios.nome_usuario AS nome_usuario
    FROM t_requerimentos
    LEFT JOIN t_usuarios ON t_requerimentos.id_usuario = t_usuarios.id_usuario"; //Puxa dados de t_requerimentos e nome_usuario de t_usuario.

                    if (filtro == "Pendente")
                        query += " WHERE status_doc = 'Pendente'";
                    else if (filtro == "Cancelado")
                        query += " WHERE status_doc = 'Cancelado'";
                    else if (filtro == "Respondido")
                        query += " WHERE status_doc = 'Respondido'";   // Aplicam os filtros de acordo com oque é selecionado no cbbox

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistoricoR.Columns.Clear(); //Remove colunas erradas
                        dgvHistoricoR.DataSource = dt;
                        dgvHistoricoR.Columns["nome_usuario"].DisplayIndex = 15; // Poe a coluna respondido por no local correto

                        // Oculta a coluna id_usuario, id imagem e tipo_doc
                            dgvHistoricoR.Columns["id_usuario"].Visible = false;
                            dgvHistoricoR.Columns["id_imagem"].Visible = false;
                            dgvHistoricoR.Columns["tipo_doc"].Visible = false;

                        RenomearColunasR();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar requerimentos: " + ex.Message);
            }
        }
        private void cmbFiltroStatus_SelectedIndexChanged(object sender, EventArgs e) // Método ativado mudando a cbbox filtro
        {
            CarregarTickets();
            CarregarRequerimentos();
        }

        private void dgvHistoricoR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int idRequerimento = Convert.ToInt32(dgvHistoricoR.Rows[e.RowIndex].Cells["id_requerimento"].Value);

                var formDetalhes = new DetalhesRequerimento(idRequerimento);
                formDetalhes.StartPosition = FormStartPosition.CenterParent;
                formDetalhes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário de detalhes: " + ex.Message);
            }
        }

        private void dgvHistoricoT_CellContentClick(object sender, DataGridViewCellEventArgs e) // abre FormDetalhesAtendimento
        {
            if (e.RowIndex >= 0)
            {
                int idTicket = Convert.ToInt32(dgvHistoricoT.Rows[e.RowIndex].Cells["id_ticket"].Value);

                FormDetalhesAtendimento detalhesForm = new FormDetalhesAtendimento(idTicket);
                detalhesForm.ShowDialog();
            }
        }
        private void BuscarTickets(string termo)
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string filtro = cmbFiltroStatus.SelectedItem?.ToString();

                    // Puxa a tabela t_tickets e o nome de t_usuarios
                    string query = @"
                SELECT t_tickets.*, t_usuarios.nome_usuario
                FROM t_tickets
                LEFT JOIN t_usuarios ON t_tickets.id_usuario = t_usuarios.id_usuario
                WHERE (t_tickets.nome_aluno LIKE @busca OR t_tickets.ra LIKE @busca)";

                  
                    if (filtro == "Pendente")
                        query += " AND t_tickets.status = 'Pendente'";
                    else if (filtro == "Cancelado")
                        query += " AND (t_tickets.status = 'Cancelado')";
                    else if (filtro == "Respondido")
                        query += " AND t_tickets.status = 'Respondido'"; // Aplicam os filtros de acordo com oque é selecionado no cbbox

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@busca", $"%{termo}%");

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvHistoricoT.Columns.Clear(); // Remove colunas erradas
                        dgvHistoricoT.DataSource = dt;
                        
                            dgvHistoricoT.Columns["id_usuario"].Visible = false; //oculta coluna id_usuario

                            dgvHistoricoT.Columns["nome_usuario"].DisplayIndex = 13; // Coloca na posição correta
                        

                        RenomearColunasT();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar em tickets: " + ex.Message);
            }
        }

        private void BuscarRequerimentos(string termo)
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string filtro = cmbFiltroStatus.SelectedItem?.ToString();
                    string query = @"
                SELECT t_requerimentos.*, t_usuarios.nome_usuario
                FROM t_requerimentos
                LEFT JOIN t_usuarios ON t_requerimentos.id_usuario = t_usuarios.id_usuario
                WHERE (t_requerimentos.nome LIKE @busca OR t_requerimentos.ra LIKE @busca)";

                    // Adiciona filtro de status
                    if (filtro == "Pendente")
                        query += " AND t_requerimentos.status_doc = 'Pendente'";
                    else if (filtro == "Cancelado")
                        query += " AND (t_requerimentos.status_doc = 'Cancelado')";
                    else if (filtro == "Respondido")
                        query += " AND t_requerimentos.status_doc = 'Respondido'";  // Aplicam os filtros de acordo com oque é selecionado no cbbox

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@busca", $"%{termo}%");

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvHistoricoR.Columns.Clear();  // Remove colunas erradas
                        dgvHistoricoR.DataSource = dt;

                        // Oculta a coluna id_usuario, id imagem e tipo_doc
                        dgvHistoricoR.Columns["id_usuario"].Visible = false;
                        dgvHistoricoR.Columns["id_imagem"].Visible = false;
                        dgvHistoricoR.Columns["tipo_doc"].Visible = false;

                        dgvHistoricoR.Columns["nome_usuario"].DisplayIndex = 15; // Coloca na posição correta
                        

                        RenomearColunasR();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar em requerimentos: " + ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ignora se estiver com o texto padrão
            if (txtBuscar.Text == textoBuscar)
                return;

            string termoBusca = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(termoBusca))
            {
                // Se limpar a caixa, recarrega todos os dados
                CarregarTickets();
                CarregarRequerimentos();
            }
            else
            {
                // Se tiver algo digitado, busca automaticamente
                BuscarTickets(termoBusca);
                BuscarRequerimentos(termoBusca);
            }
        }
        private string textoBuscar = "Nome ou RA"; // texto padrâo da txtBuscar
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text)) // Volta para texto padrâo e cor cinza
            {
                txtBuscar.Text = textoBuscar;
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void RenomearColunasT()
        {
            // Renomear colunas de ticket
            dgvHistoricoT.Columns["id_ticket"].HeaderText = "ID";
            dgvHistoricoT.Columns["nome_aluno"].HeaderText = "Nome";
            dgvHistoricoT.Columns["cpf"].HeaderText = "CPF";
            dgvHistoricoT.Columns["ra"].HeaderText = "RA";
            dgvHistoricoT.Columns["tipo_vinculo"].HeaderText = "Vínculo";
            dgvHistoricoT.Columns["email"].HeaderText = "Email";
            dgvHistoricoT.Columns["curso"].HeaderText = "Curso";
            dgvHistoricoT.Columns["categoria"].HeaderText = "Assunto";
            dgvHistoricoT.Columns["assunto"].HeaderText = "Dúvida"; // No bd a coluna categoria usa o campo assunto do site, e a coluna assunto usa o campo dúvida
            dgvHistoricoT.Columns["data_pedido"].HeaderText = "Data do Ticket";
            dgvHistoricoT.Columns["resposta"].HeaderText = "Resposta";
            dgvHistoricoT.Columns["status"].HeaderText = "Status";
            dgvHistoricoT.Columns["data_resposta"].HeaderText = "Data da Resposta";
            //dgvHistoricoT.Columns["id_usuario"].HeaderText = "Código";
            dgvHistoricoT.Columns["nome_usuario"].HeaderText = "Respondido Por";


        }

        private void RenomearColunasR()
        {
            //Renomear colunas de requerimento
            dgvHistoricoR.Columns["id_requerimento"].HeaderText = "ID";
            //dgvHistoricoR.Columns["id_usuario"].HeaderText = "Código";
            dgvHistoricoR.Columns["ra"].HeaderText = "RA";
            dgvHistoricoR.Columns["telefone"].HeaderText = "Telefone";
            dgvHistoricoR.Columns["nome"].HeaderText = "Nome";
            dgvHistoricoR.Columns["curso"].HeaderText = "Curso";
            dgvHistoricoR.Columns["cpf"].HeaderText = "CPF";
            dgvHistoricoR.Columns["rg"].HeaderText = "RG";
            dgvHistoricoR.Columns["email"].HeaderText = "Email";
            dgvHistoricoR.Columns["id_requerimento"].HeaderText = "ID";
            dgvHistoricoR.Columns["nome_doc"].HeaderText = "Documento";
            dgvHistoricoR.Columns["status_doc"].HeaderText = "Status";
            //dgvHistoricoR.Columns["tipo_doc"].HeaderText = "Tipo";
            dgvHistoricoR.Columns["data_pedido"].HeaderText = "Data do Pedido";
            dgvHistoricoR.Columns["data_resposta"].HeaderText = "Data da Resposta";
            dgvHistoricoR.Columns["resposta"].HeaderText = "Resposta";
            //dgvHistoricoR.Columns["comprovante"].HeaderText = "Comprovante";
            dgvHistoricoR.Columns["nome_usuario"].HeaderText = "Respondido Por";

        }
        //Deixa o texto cinza
        private void TxtCinza() {

            txtBuscar.Text = textoBuscar;
            txtBuscar.ForeColor = Color.Gray;
        }
    }
    
}