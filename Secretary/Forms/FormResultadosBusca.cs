using Secretary.DAO;
using Secretary.Forms.Atendimentos;
using Secretary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class FormResultadosBusca : Form
    {
        private string termoBusca;
        private List<ResultadoBusca> resultados;

        public FormResultadosBusca(string termo)
        {
            InitializeComponent();
            this.termoBusca = termo;
        }

        private void FormResultadosBusca_Load(object sender, EventArgs e)
        {
            lblTermoBusca.Text = $"Resultados para: \"{termoBusca}\"";
            cmbFiltro.SelectedIndex = 0;
            ExecutarBusca();
        }

        private void ExecutarBusca()
        {
            Cursor = Cursors.WaitCursor;
            resultados = BuscaDAO.BuscarGlobal(termoBusca);
            AtualizarGrid(resultados);
            Cursor = Cursors.Default;

            if (resultados.Count == 0)
                MessageBox.Show("Nenhum resultado encontrado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AtualizarGrid(List<ResultadoBusca> lista)
        {
            dgvResultados.Rows.Clear();

            foreach (var r in lista)
            {
                int idx = dgvResultados.Rows.Add(r.Tipo, r.Nome, r.Descricao, r.Status, 
                    r.Data?.ToString("dd/MM/yyyy") ?? "-", r.Detalhes, r.Id);

                var row = dgvResultados.Rows[idx];

                // Cor por tipo
                if (r.Tipo == "Requerimento")
                    row.Cells["colTipo"].Style.BackColor = Color.FromArgb(200, 230, 201);
                else if (r.Tipo == "Atendimento")
                    row.Cells["colTipo"].Style.BackColor = Color.FromArgb(187, 222, 251);
                else if (r.Tipo == "Usuário")
                    row.Cells["colTipo"].Style.BackColor = Color.FromArgb(255, 224, 178);

                // Cor por status
                string st = r.Status?.ToLower() ?? "";
                if (st.Contains("respondido") || st.Contains("ativo"))
                    row.Cells["colStatus"].Style.ForeColor = Color.Green;
                else if (st.Contains("pendente"))
                    row.Cells["colStatus"].Style.ForeColor = Color.Orange;
                else if (st.Contains("cancelado") || st.Contains("inativo"))
                    row.Cells["colStatus"].Style.ForeColor = Color.Red;
            }

            lblTotal.Text = $"Total: {lista.Count} resultado(s)";
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultados == null) return;

            string filtro = cmbFiltro.SelectedItem?.ToString() ?? "Todos";
            var filtrados = filtro == "Todos" ? resultados : resultados.FindAll(r => r.Tipo == filtro);
            AtualizarGrid(filtrados);
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string tipo = dgvResultados.Rows[e.RowIndex].Cells["colTipo"].Value?.ToString();
            int id = Convert.ToInt32(dgvResultados.Rows[e.RowIndex].Cells["colId"].Value);

            if (tipo == "Requerimento")
            {
                new DetalhesRequerimento(id).ShowDialog();
            }
            else if (tipo == "Atendimento")
            {
                new FormDetalhesAtendimento(id).ShowDialog();
            }
            else if (tipo == "Usuário")
            {
                MessageBox.Show($"Usuário ID: {id}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
