using Secretary.DAO;
using Secretary.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class FormEstatisticasFuncionarios : Form
    {
        public FormEstatisticasFuncionarios()
        {
            InitializeComponent();
        }

        private void FormEstatisticasFuncionarios_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = new DateTime(2025, 1, 1);
            // Define dtpFim para a data atual
            dtpFim.Value = DateTime.Now.Date;

            CarregarUsuarios();
            CarregarCursos();
            CarregarVisualizarPor();
            AtualizarEstatisticas();
            cmbVisualizarPor.SelectedIndexChanged += cmbVisualizarPor_SelectedIndexChanged;
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarFiltros();
            AtualizarEstatisticas();
        }


        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarFiltros();
            AtualizarEstatisticas();
        }

        private void cmbVisualizarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarFiltros();
            AtualizarEstatisticas();
        }
        private void ValidarFiltros()
        {
            string modo = cmbVisualizarPor.SelectedItem?.ToString();
            int idUsuario = cmbUsuario.SelectedValue != null && int.TryParse(cmbUsuario.SelectedValue.ToString(), out int tempId) ? tempId : 0;
            string curso = cmbCurso.SelectedValue?.ToString() == "Todos" ? null : cmbCurso.SelectedValue?.ToString();
            // Regra 1: Se usuário e curso específicos, forçar "Detalhado"
            if (idUsuario > 0 && !string.IsNullOrEmpty(curso))
            {
                if (modo != "Detalhado")
                {
                    MessageBox.Show("Quando um usuário e um curso específicos são selecionados, a visualização é automaticamente ajustada para 'Detalhado' para mostrar os detalhes individuais.", "Ajuste Automático", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbVisualizarPor.SelectedItem = "Detalhado";
                }
            }
            // Regra 2: Se tentar "Usuários" com curso específico, forçar curso para "Todos"
            else if (modo == "Usuários" && !string.IsNullOrEmpty(curso))
            {
                MessageBox.Show("A visualização 'Usuários' não suporta filtro por curso específico. O filtro de curso foi ajustado para 'Todos'.", "Ajuste Automático", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCurso.SelectedIndex = 0; // "Todos"
            }
            // Regra 3: Se tentar "Cursos" com usuário específico, forçar usuário para "Todos"
            else if (modo == "Cursos" && idUsuario > 0)
            {
                MessageBox.Show("A visualização 'Cursos' não suporta filtro por usuário específico. O filtro de usuário foi ajustado para 'Todos'.", "Ajuste Automático", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbUsuario.SelectedIndex = 0; // "Todos"
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            // Validação: dtpInicio não pode ser maior que dtpFim
            if (dtpInicio.Value > dtpFim.Value)
            {
                dtpInicio.Value = dtpFim.Value;
            }
            AtualizarEstatisticas();
        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            // Validação: dtpFim não pode ser no futuro
            if (dtpFim.Value > DateTime.Now.Date)
            {
                dtpFim.Value = DateTime.Now.Date;
                MessageBox.Show("A data fim não pode ser no futuro. Ajustada para hoje.");
            }
            // Validação: dtpFim não pode ser menor que dtpInicio
            if (dtpFim.Value < dtpInicio.Value)
            {
                dtpInicio.Value = dtpFim.Value;
            }
            AtualizarEstatisticas();
        }

        // -----------------------------------------
        // CARREGAR FILTROS
        // -----------------------------------------

        private void CarregarUsuarios()
        {
            try
            {
                cmbUsuario.DataSource = EstatisticasDAO.ObterUsuariosAtivos();
                cmbUsuario.DisplayMember = "nome_usuario";
                cmbUsuario.ValueMember = "id_usuario";
                cmbUsuario.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}");
            }
        }

        private void CarregarCursos()
        {
            try
            {
                cmbCurso.DataSource = EstatisticasDAO.ObterCursos();
                cmbCurso.DisplayMember = "curso";
                cmbCurso.ValueMember = "curso";
                cmbCurso.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cursos: {ex.Message}");
            }
        }

        private void CarregarVisualizarPor()
        {
            cmbVisualizarPor.Items.Clear();
            cmbVisualizarPor.Items.Add("Usuários");
            cmbVisualizarPor.Items.Add("Cursos");
            cmbVisualizarPor.Items.Add("Detalhado");
            cmbVisualizarPor.SelectedIndex = 0;
        }

        // -----------------------------------------
        // REGRA PRINCIPAL
        // -----------------------------------------
        private void AtualizarEstatisticas()
        {
            string curso = null;
            int idUsuario = 0;
            string modoVisualizacao = cmbVisualizarPor.SelectedItem?.ToString();

            if (cmbCurso.SelectedValue != null)
            {
                string selectedCurso = cmbCurso.SelectedValue.ToString();
                curso = selectedCurso == "Todos" ? null : selectedCurso;
            }

            if (cmbUsuario.SelectedValue != null && int.TryParse(cmbUsuario.SelectedValue.ToString(), out int tempId))
            {
                idUsuario = tempId;
            }

            DateTime inicio = dtpInicio.Value;
            DateTime fim = dtpFim.Value;
            DateTime fimAjustado = fim.Date.AddDays(1).AddTicks(-1);

            try
            {
                if (modoVisualizacao == "Usuários")
                {
                    // Visualização por usuários (lógica existente, sem mudanças)
                    if (idUsuario > 0 && !string.IsNullOrEmpty(curso))
                    {
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsUsuarioCurso(idUsuario, curso, inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosUsuarioCurso(idUsuario, curso, inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoPorUsuarioECurso(idUsuario, curso, inicio, fimAjustado);
                    }
                    else if (idUsuario > 0)
                    {
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsUsuario(idUsuario, inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosUsuario(idUsuario, inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoPorUsuario(idUsuario, inicio, fimAjustado);
                    }
                    else
                    {
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsGeral(inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosGeral(inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoAgrupadoPorUsuario(inicio, fimAjustado);
                    }
                }
                else if (modoVisualizacao == "Cursos")
                {
                    // Visualização por cursos (ajustada para aplicar filtros)
                    if (!string.IsNullOrEmpty(curso) && idUsuario > 0)
                    {
                        // Curso e usuário selecionados: agrupa por cursos filtrados por usuário
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsUsuarioCurso(idUsuario, curso, inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosUsuarioCurso(idUsuario, curso, inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoAgrupadoPorCursoFiltradoPorUsuario(idUsuario, inicio, fimAjustado);
                    }
                    else if (!string.IsNullOrEmpty(curso))
                    {
                        // Apenas curso: agrupa por curso específico (usuários que atenderam)
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsCurso(curso, inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosCurso(curso, inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoPorCurso(curso, inicio, fimAjustado);
                    }
                    else if (idUsuario > 0)
                    {
                        // Apenas usuário: agrupa por cursos atendidos por esse usuário
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsUsuario(idUsuario, inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosUsuario(idUsuario, inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoAgrupadoPorCursoFiltradoPorUsuario(idUsuario, inicio, fimAjustado);
                    }
                    else
                    {
                        // Nenhum filtro: agrupa por todos os cursos
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsGeral(inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosGeral(inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoAgrupadoPorCurso(inicio, fimAjustado);
                    }
                }
                else if (modoVisualizacao == "Detalhado")
                {
                    // Visualização detalhada (ajustada para aplicar filtros)
                    if (idUsuario > 0 && !string.IsNullOrEmpty(curso))
                    {
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsUsuarioCurso(idUsuario, curso, inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosUsuarioCurso(idUsuario, curso, inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoPorUsuarioECurso(idUsuario, curso, inicio, fimAjustado);
                    }
                    else if (idUsuario > 0)
                    {
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsUsuario(idUsuario, inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosUsuario(idUsuario, inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoPorUsuario(idUsuario, inicio, fimAjustado);
                    }
                    else if (!string.IsNullOrEmpty(curso))
                    {
                        // Apenas curso: lista detalhes filtrados por curso
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsCurso(curso, inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosCurso(curso, inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarDetalhesPorCurso(curso, inicio, fimAjustado);
                    }
                    else
                    {
                        lblTotalTickets.Text = EstatisticasDAO.TotalTicketsGeral(inicio, fimAjustado).ToString();
                        lblTotalRequerimentos.Text = EstatisticasDAO.TotalRequerimentosGeral(inicio, fimAjustado).ToString();
                        dgvDados.DataSource = EstatisticasDAO.ListarResumoGeral(inicio, fimAjustado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar estatísticas: {ex.Message}");
            }
        }
        // -----------------------------------------
        // BOTÕES DE EXPORTAÇÃO
        // -----------------------------------------
        private void btnBaixarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = cmbUsuario.SelectedIndex > 0
                    ? cmbUsuario.Text
                    : "Todos os Usuários";

                string curso = cmbCurso.SelectedIndex > 0
                    ? cmbCurso.Text
                    : "Todos os Cursos";

                PdfExporter.ExportToPdf(
                    dgvDados,
                    lblTotalRequerimentos.Text,
                    lblTotalTickets.Text,
                    usuario,
                    curso,
                    dtpInicio.Value,
                    dtpFim.Value
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar PDF: {ex.Message}");
            }
        }

        private void btnBaixarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = cmbUsuario.SelectedIndex > 0
                    ? cmbUsuario.Text
                    : "Todos os Usuários";

                string curso = cmbCurso.SelectedIndex > 0
                    ? cmbCurso.Text
                    : "Todos os Cursos";

                ExcelExporter.ExportToExcel(
                    dgvDados,
                    lblTotalRequerimentos.Text,
                    lblTotalTickets.Text,
                    usuario,
                    curso,
                    dtpInicio.Value,
                    dtpFim.Value
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar Excel: {ex.Message}");
            }
        }
    }
}
