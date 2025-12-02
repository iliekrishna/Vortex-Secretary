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
            cmbFiltroTipo.SelectedIndex = 0; // Seleciona "Todos" por padrão
            RealizarBusca();
        }

        private void RealizarBusca()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                
                resultados = BuscaDAO.BuscarGlobal(termoBusca);
                var contagem = BuscaDAO.ContarResultadosPorTipo(termoBusca);

                // Atualizar contadores
                lblContRequerimentos.Text = $"Requerimentos: {contagem["Requerimento"]}";
                lblContAtendimentos.Text = $"Atendimentos: {contagem["Atendimento"]}";
                lblContUsuarios.Text = $"Usuários: {contagem["Usuário"]}";
                lblTotalResultados.Text = $"Total: {resultados.Count} resultado(s)";

                // Preencher DataGridView
                dgvResultados.DataSource = null;
                dgvResultados.Rows.Clear();

                foreach (var resultado in resultados)
                {
                    int rowIndex = dgvResultados.Rows.Add(
                        resultado.Tipo,
                        resultado.Titulo,
                        resultado.Descricao,
                        resultado.Status,
                        resultado.Data?.ToString("dd/MM/yyyy HH:mm") ?? "-",
                        resultado.InfoAdicional,
                        resultado.Id
                    );

                    // Colorir por tipo
                    DataGridViewRow row = dgvResultados.Rows[rowIndex];
                    switch (resultado.Tipo)
                    {
                        case "Requerimento":
                            row.Cells["colTipo"].Style.BackColor = Color.FromArgb(200, 230, 201);
                            break;
                        case "Atendimento":
                            row.Cells["colTipo"].Style.BackColor = Color.FromArgb(187, 222, 251);
                            break;
                        case "Usuário":
                            row.Cells["colTipo"].Style.BackColor = Color.FromArgb(255, 224, 178);
                            break;
                    }

                    // Colorir por status
                    string status = resultado.Status?.ToLower() ?? "";
                    if (status.Contains("respondido") || status.Contains("atendido") || status.Contains("ativo"))
                    {
                        row.Cells["colStatus"].Style.ForeColor = Color.Green;
                    }
                    else if (status.Contains("pendente") || status.Contains("aberto"))
                    {
                        row.Cells["colStatus"].Style.ForeColor = Color.Orange;
                    }
                    else if (status.Contains("cancelado") || status.Contains("inativo"))
                    {
                        row.Cells["colStatus"].Style.ForeColor = Color.Red;
                    }
                }

                if (resultados.Count == 0)
                {
                    MessageBox.Show("Nenhum resultado encontrado para o termo informado.", 
                        "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar busca: " + ex.Message, 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                string tipo = dgvResultados.Rows[e.RowIndex].Cells["colTipo"].Value?.ToString();
                int id = Convert.ToInt32(dgvResultados.Rows[e.RowIndex].Cells["colId"].Value);

                switch (tipo)
                {
                    case "Requerimento":
                        AbrirDetalhesRequerimento(id);
                        break;
                    case "Atendimento":
                        AbrirDetalhesAtendimento(id);
                        break;
                    case "Usuário":
                        MessageBox.Show($"Usuário ID: {id}\nVisualize os detalhes na tela de Gerenciamento.", 
                            "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir detalhes: " + ex.Message, 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirDetalhesRequerimento(int id)
        {
            var formDetalhes = new DetalhesRequerimento(id);
            formDetalhes.StartPosition = FormStartPosition.CenterParent;
            formDetalhes.ShowDialog();
        }

        private void AbrirDetalhesAtendimento(int id)
        {
            var formDetalhes = new FormDetalhesAtendimento(id);
            formDetalhes.StartPosition = FormStartPosition.CenterParent;
            formDetalhes.ShowDialog();
        }

        private void cmbFiltroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarResultados();
        }

        private void FiltrarResultados()
        {
            string filtro = cmbFiltroTipo.SelectedItem?.ToString() ?? "Todos";

            dgvResultados.Rows.Clear();

            var resultadosFiltrados = filtro == "Todos" 
                ? resultados 
                : resultados.FindAll(r => r.Tipo == filtro);

            foreach (var resultado in resultadosFiltrados)
            {
                int rowIndex = dgvResultados.Rows.Add(
                    resultado.Tipo,
                    resultado.Titulo,
                    resultado.Descricao,
                    resultado.Status,
                    resultado.Data?.ToString("dd/MM/yyyy HH:mm") ?? "-",
                    resultado.InfoAdicional,
                    resultado.Id
                );

                DataGridViewRow row = dgvResultados.Rows[rowIndex];
                switch (resultado.Tipo)
                {
                    case "Requerimento":
                        row.Cells["colTipo"].Style.BackColor = Color.FromArgb(200, 230, 201);
                        break;
                    case "Atendimento":
                        row.Cells["colTipo"].Style.BackColor = Color.FromArgb(187, 222, 251);
                        break;
                    case "Usuário":
                        row.Cells["colTipo"].Style.BackColor = Color.FromArgb(255, 224, 178);
                        break;
                }

                string status = resultado.Status?.ToLower() ?? "";
                if (status.Contains("respondido") || status.Contains("atendido") || status.Contains("ativo"))
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Green;
                }
                else if (status.Contains("pendente") || status.Contains("aberto"))
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Orange;
                }
                else if (status.Contains("cancelado") || status.Contains("inativo"))
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Red;
                }
            }

            lblTotalResultados.Text = $"Exibindo: {resultadosFiltrados.Count} resultado(s)";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
