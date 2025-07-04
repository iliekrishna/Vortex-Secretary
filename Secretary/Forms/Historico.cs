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
            cmbFiltroStatus.Items.Add("Respondido/Concluído");
            cmbFiltroStatus.Items.Add("Encerrado/Cancelado");

            cmbFiltroStatus.SelectedIndex = 0; // Define "Todos" como padrão

            CarregarTickets();
            CarregarRequerimentos();

            dgvHistoricoT.CellDoubleClick += dgvHistoricoT_CellDoubleClick;

            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = textoBuscar;
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void CarregarTickets()
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string filtro = cmbFiltroStatus.SelectedItem?.ToString();
                    string query = "SELECT * FROM t_tickets";

                    if (filtro == "Pendente")
                        query += " WHERE status = 'Pendente'";
                    else if (filtro == "Encerrado/Cancelado")
                        query += " WHERE status = 'Encerrado' OR status = 'Cancelado'";
                    else if (filtro == "Respondido/Concluído")
                        query += " WHERE status = 'Respondido'";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistoricoT.Columns.Clear();
                        dgvHistoricoT.DataSource = dt;
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
                    string query = "SELECT * FROM t_requerimentos";

                    if (filtro == "Pendente")
                        query += " WHERE status_doc = 'Pendente'";
                    else if (filtro == "Encerrado/Cancelado")
                        query += " WHERE status_doc = 'Cancelado'";
                    else if (filtro == "Respondido/Concluído")
                        query += " WHERE status_doc = 'Concluído'";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistoricoR.Columns.Clear();
                        dgvHistoricoR.DataSource = dt;
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
            // ND
        }

        private void dgvHistoricoT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow linha = dgvHistoricoT.Rows[e.RowIndex];

            int ticketId = Convert.ToInt32(linha.Cells["id_ticket"].Value);
            string nome = linha.Cells["nome_aluno"].Value?.ToString();
            string ra = linha.Cells["ra"].Value?.ToString();
            string curso = linha.Cells["curso"].Value?.ToString();
            string categoria = linha.Cells["Categoria"].Value?.ToString();
            string assunto = linha.Cells["assunto"].Value?.ToString();
            string data = DateTime.Now.ToShortDateString();
            string mensagem = assunto;

            int usuarioId = Sessao.UsuarioId; // ou ajuste conforme onde você guarda o ID

            //var chat = new FormChatAtendimento(ticketId, nome, ra, curso, assunto, categoria, data, mensagem, null, usuarioId);
            //chat.StartPosition = FormStartPosition.CenterScreen;
            //chat.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termoBusca = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(termoBusca) || termoBusca == textoBuscar)
            {
                MessageBox.Show("Digite um RA ou nome para buscar.");
                return;
            }

            BuscarTickets(termoBusca);
            BuscarRequerimentos(termoBusca);
        }

        private void BuscarTickets(string termo)
        {
            try
            {
                using (var conn = ConexaoBD.ObterConexao())
                {
                    string filtro = cmbFiltroStatus.SelectedItem?.ToString();
                    string query = "SELECT * FROM t_tickets WHERE (nome_aluno LIKE @busca OR ra LIKE @busca)";

                    if (filtro == "Pendente")
                        query += " AND status = 'Pendente'";
                    else if (filtro == "Encerrado/Cancelado")
                        query += " AND status = 'Encerrado'";
                    else if (filtro == "Respondido/Concluído")
                        query += " AND status = 'Respondido'";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@busca", $"%{termo}%");

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistoricoT.Columns.Clear();
                        dgvHistoricoT.DataSource = dt;
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
                    string query = "SELECT * FROM t_requerimentos WHERE (nome LIKE @busca OR ra LIKE @busca)";

                    if (filtro == "Pendente")
                        query += " AND status_doc = 'Pendente'";
                    else if (filtro == "Encerrado/Cancelado")
                        query += " AND status_doc = 'Cancelado'";
                    else if (filtro == "Respondido/Concluído")
                        query += " AND status_doc = 'Concluído'";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@busca", $"%{termo}%");

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistoricoR.Columns.Clear();
                        dgvHistoricoR.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar em requerimentos: " + ex.Message);
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {
            //nd
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // nd 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear(); // Limpa a txtbuscar
            CarregarTickets();         // Recarrega todos os tickets
            CarregarRequerimentos();  // Recarrega todos os requerimentos

        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //nd
        }

        private string textoBuscar = "Nome ou RA";

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
       
    }
}


