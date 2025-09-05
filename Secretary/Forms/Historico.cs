using MySql.Data.MySqlClient;
using Secretary.DAO;
using Secretary.Forms.Atendimentos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class Historico : Form
    {
        private string textoBuscar = "Nome ou RA"; // texto padrão da txtBuscar

        public Historico()
        {
            InitializeComponent();

            // Associa eventos para placeholder e busca
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
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
                        LEFT JOIN t_usuarios ON t_tickets.id_usuario = t_usuarios.id_usuario";

                    if (filtro == "Pendente")
                        query += " WHERE status = 'Pendente'";
                    else if (filtro == "Cancelado")
                        query += " WHERE status = 'Cancelado'";
                    else if (filtro == "Respondido")
                        query += " WHERE status = 'Respondido'";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistoricoT.Columns.Clear();
                        dgvHistoricoT.DataSource = dt;

                        if (dgvHistoricoT.Columns.Contains("id_usuario"))
                            dgvHistoricoT.Columns["id_usuario"].Visible = false;

                        if (dgvHistoricoT.Columns.Contains("nome_usuario"))
                            dgvHistoricoT.Columns["nome_usuario"].DisplayIndex = 13;

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
                        LEFT JOIN t_usuarios ON t_requerimentos.id_usuario = t_usuarios.id_usuario";

                    if (filtro == "Pendente")
                        query += " WHERE status_doc = 'Pendente'";
                    else if (filtro == "Cancelado")
                        query += " WHERE status_doc = 'Cancelado'";
                    else if (filtro == "Respondido")
                        query += " WHERE status_doc = 'Respondido'";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistoricoR.Columns.Clear();
                        dgvHistoricoR.DataSource = dt;

                        if (dgvHistoricoR.Columns.Contains("id_usuario"))
                            dgvHistoricoR.Columns["id_usuario"].Visible = false;
                        if (dgvHistoricoR.Columns.Contains("id_imagem"))
                            dgvHistoricoR.Columns["id_imagem"].Visible = false;
                        if (dgvHistoricoR.Columns.Contains("tipo_doc"))
                            dgvHistoricoR.Columns["tipo_doc"].Visible = false;
                        if (dgvHistoricoR.Columns.Contains("nome_usuario"))
                            dgvHistoricoR.Columns["nome_usuario"].DisplayIndex = 15;

                        RenomearColunasR();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar requerimentos: " + ex.Message);
            }
        }

        private void cmbFiltroStatus_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgvHistoricoT_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                    string query = @"
                        SELECT t_tickets.*, t_usuarios.nome_usuario
                        FROM t_tickets
                        LEFT JOIN t_usuarios ON t_tickets.id_usuario = t_usuarios.id_usuario
                        WHERE (t_tickets.nome_aluno LIKE @busca OR t_tickets.ra LIKE @busca)";

                    if (filtro == "Pendente")
                        query += " AND t_tickets.status = 'Pendente'";
                    else if (filtro == "Cancelado")
                        query += " AND t_tickets.status = 'Cancelado'";
                    else if (filtro == "Respondido")
                        query += " AND t_tickets.status = 'Respondido'";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@busca", $"%{termo}%");

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvHistoricoT.Columns.Clear();
                        dgvHistoricoT.DataSource = dt;

                        if (dgvHistoricoT.Columns.Contains("id_usuario"))
                            dgvHistoricoT.Columns["id_usuario"].Visible = false;

                        if (dgvHistoricoT.Columns.Contains("nome_usuario"))
                            dgvHistoricoT.Columns["nome_usuario"].DisplayIndex = 13;

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
                string filtro = cmbFiltroStatus.SelectedItem?.ToString();
                string statusFiltro = filtro == "Todos" ? "" : filtro;

                DataTable dt = RequerimentoDAO.BuscarRequerimentos(
                    string.IsNullOrEmpty(statusFiltro) ? "aberto" : statusFiltro,
                    "Todos",
                    "Todos",
                    termo
                );

                dgvHistoricoR.Columns.Clear();
                dgvHistoricoR.DataSource = dt;

                if (dgvHistoricoR.Columns.Contains("id_usuario"))
                    dgvHistoricoR.Columns["id_usuario"].Visible = false;
                if (dgvHistoricoR.Columns.Contains("id_imagem"))
                    dgvHistoricoR.Columns["id_imagem"].Visible = false;
                if (dgvHistoricoR.Columns.Contains("tipo_doc"))
                    dgvHistoricoR.Columns["tipo_doc"].Visible = false;
                if (dgvHistoricoR.Columns.Contains("nome_usuario"))
                    dgvHistoricoR.Columns["nome_usuario"].DisplayIndex = 15;

                RenomearColunasR();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar em requerimentos: " + ex.Message);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == textoBuscar)
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = textoBuscar;
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == textoBuscar) return;

            string termoBusca = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(termoBusca))
            {
                CarregarTickets();
                CarregarRequerimentos();
            }
            else
            {
                BuscarTickets(termoBusca);
                BuscarRequerimentos(termoBusca);
            }
        }

        private void RenomearColunasT()
        {
            if (dgvHistoricoT.Columns.Contains("id_ticket"))
                dgvHistoricoT.Columns["id_ticket"].HeaderText = "ID";
            if (dgvHistoricoT.Columns.Contains("nome_aluno"))
                dgvHistoricoT.Columns["nome_aluno"].HeaderText = "Nome";
            if (dgvHistoricoT.Columns.Contains("cpf"))
                dgvHistoricoT.Columns["cpf"].HeaderText = "CPF";
            if (dgvHistoricoT.Columns.Contains("ra"))
                dgvHistoricoT.Columns["ra"].HeaderText = "RA";
            if (dgvHistoricoT.Columns.Contains("tipo_vinculo"))
                dgvHistoricoT.Columns["tipo_vinculo"].HeaderText = "Vínculo";
            if (dgvHistoricoT.Columns.Contains("email"))
                dgvHistoricoT.Columns["email"].HeaderText = "Email";
            if (dgvHistoricoT.Columns.Contains("curso"))
                dgvHistoricoT.Columns["curso"].HeaderText = "Curso";
            if (dgvHistoricoT.Columns.Contains("categoria"))
                dgvHistoricoT.Columns["categoria"].HeaderText = "Assunto";
            if (dgvHistoricoT.Columns.Contains("assunto"))
                dgvHistoricoT.Columns["assunto"].HeaderText = "Dúvida";
            if (dgvHistoricoT.Columns.Contains("data_pedido"))
                dgvHistoricoT.Columns["data_pedido"].HeaderText = "Data do Ticket";
            if (dgvHistoricoT.Columns.Contains("resposta"))
                dgvHistoricoT.Columns["resposta"].HeaderText = "Resposta";
            if (dgvHistoricoT.Columns.Contains("status"))
                dgvHistoricoT.Columns["status"].HeaderText = "Status";
            if (dgvHistoricoT.Columns.Contains("data_resposta"))
                dgvHistoricoT.Columns["data_resposta"].HeaderText = "Data da Resposta";
            if (dgvHistoricoT.Columns.Contains("nome_usuario"))
                dgvHistoricoT.Columns["nome_usuario"].HeaderText = "Respondido Por";
        }

        private void RenomearColunasR()
        {
            if (dgvHistoricoR.Columns.Contains("id_requerimento"))
                dgvHistoricoR.Columns["id_requerimento"].HeaderText = "ID";
            if (dgvHistoricoR.Columns.Contains("ra"))
                dgvHistoricoR.Columns["ra"].HeaderText = "RA";
            if (dgvHistoricoR.Columns.Contains("telefone"))
                dgvHistoricoR.Columns["telefone"].HeaderText = "Telefone";
            if (dgvHistoricoR.Columns.Contains("nome"))
                dgvHistoricoR.Columns["nome"].HeaderText = "Nome";
            if (dgvHistoricoR.Columns.Contains("curso"))
                dgvHistoricoR.Columns["curso"].HeaderText = "Curso";
            if (dgvHistoricoR.Columns.Contains("cpf"))
                dgvHistoricoR.Columns["cpf"].HeaderText = "CPF";
            if (dgvHistoricoR.Columns.Contains("rg"))
                dgvHistoricoR.Columns["rg"].HeaderText = "RG";
            if (dgvHistoricoR.Columns.Contains("email"))
                dgvHistoricoR.Columns["email"].HeaderText = "Email";
            if (dgvHistoricoR.Columns.Contains("nome_doc"))
                dgvHistoricoR.Columns["nome_doc"].HeaderText = "Documento";
            if (dgvHistoricoR.Columns.Contains("status_doc"))
                dgvHistoricoR.Columns["status_doc"].HeaderText = "Status";
            if (dgvHistoricoR.Columns.Contains("data_pedido"))
                dgvHistoricoR.Columns["data_pedido"].HeaderText = "Data do Pedido";
            if (dgvHistoricoR.Columns.Contains("data_resposta"))
                dgvHistoricoR.Columns["data_resposta"].HeaderText = "Data da Resposta";
            if (dgvHistoricoR.Columns.Contains("resposta"))
                dgvHistoricoR.Columns["resposta"].HeaderText = "Resposta";
            if (dgvHistoricoR.Columns.Contains("nome_usuario"))
                dgvHistoricoR.Columns["nome_usuario"].HeaderText = "Respondido Por";
        }

        private void TxtCinza()
        {
            txtBuscar.Text = textoBuscar;
            txtBuscar.ForeColor = Color.Gray;
        }
    }
}