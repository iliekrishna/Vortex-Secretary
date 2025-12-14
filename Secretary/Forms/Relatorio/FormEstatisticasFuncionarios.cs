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
            // Define dtpInicio para o primeiro dia do mês atual (ou ajuste conforme necessário)
            dtpInicio.Value = new DateTime(2026, 1, 1);
            // Define dtpFim para a data atual (sem hora)
            dtpFim.Value = DateTime.Now.Date;

            CarregarUsuarios();
            CarregarCursos();
            AtualizarEstatisticas();
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarEstatisticas();
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarEstatisticas();
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
                cmbUsuario.SelectedIndex = 0; // Seleciona "Todos" por padrão
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
                cmbCurso.SelectedIndex = 0; // Seleciona "Todos" por padrão
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cursos: {ex.Message}");
            }
        }

        // -----------------------------------------
        // REGRA PRINCIPAL
        // -----------------------------------------
        private void AtualizarEstatisticas()
        {
            // Verificações de segurança para evitar erros se os comboboxes não estiverem carregados
            string curso = null;
            int idUsuario = 0;

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

            // Ajustar fim para incluir o dia inteiro (até 23:59:59.999)
            DateTime fimAjustado = fim.Date.AddDays(1).AddTicks(-1);

            try
            {
                // Caso 1: Usuário e curso selecionados (filtro combinado)
                if (idUsuario > 0 && !string.IsNullOrEmpty(curso))
                {
                    lblTotalTickets.Text =
                        EstatisticasDAO.TotalTicketsUsuarioCurso(idUsuario, curso, inicio, fimAjustado).ToString();

                    lblTotalRequerimentos.Text =
                        EstatisticasDAO.TotalRequerimentosUsuarioCurso(idUsuario, curso, inicio, fimAjustado).ToString();

                    dgvDados.DataSource =
                        EstatisticasDAO.ListarResumoPorUsuarioECurso(idUsuario, curso, inicio, fimAjustado);

                    return;
                }

                // Caso 2: Apenas usuário selecionado
                if (idUsuario > 0)
                {
                    lblTotalTickets.Text =
                        EstatisticasDAO.TotalTicketsUsuario(idUsuario, inicio, fimAjustado).ToString();

                    lblTotalRequerimentos.Text =
                        EstatisticasDAO.TotalRequerimentosUsuario(idUsuario, inicio, fimAjustado).ToString();

                    dgvDados.DataSource =
                        EstatisticasDAO.ListarResumoPorUsuario(idUsuario, inicio, fimAjustado);

                    return;
                }

                // Caso 3: Apenas curso selecionado
                if (!string.IsNullOrEmpty(curso))
                {
                    lblTotalTickets.Text =
                        EstatisticasDAO.TotalTicketsCurso(curso, inicio, fimAjustado).ToString();

                    lblTotalRequerimentos.Text =
                        EstatisticasDAO.TotalRequerimentosCurso(curso, inicio, fimAjustado).ToString();

                    dgvDados.DataSource =
                        EstatisticasDAO.ListarResumoPorCurso(curso, inicio, fimAjustado);

                    return;
                }

                // Caso 4: Nenhum filtro (geral)
                lblTotalTickets.Text =
                    EstatisticasDAO.TotalTicketsGeral(inicio, fimAjustado).ToString();

                lblTotalRequerimentos.Text =
                    EstatisticasDAO.TotalRequerimentosGeral(inicio, fimAjustado).ToString();

                dgvDados.DataSource =
                    EstatisticasDAO.ListarResumoGeral(inicio, fimAjustado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar estatísticas: {ex.Message}");
            }
        }

        // -----------------------------------------
        // BOTÕES DE EXPORTAÇÃO (IMPLEMENTAÇÃO BÁSICA, AJUSTE CONFORME NECESSÁRIO)
        // -----------------------------------------
        private void btnBaixarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = cmbUsuario.SelectedValue?.ToString() ?? "0";
                string curso = cmbCurso.SelectedValue?.ToString() ?? "";
                DateTime inicio = dtpInicio.Value;
                DateTime fim = dtpFim.Value;
                PdfExporter.ExportToPdf(dgvDados, lblTotalRequerimentos.Text, lblTotalTickets.Text, usuario, curso, inicio, fim);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBaixarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = cmbUsuario.SelectedValue?.ToString() ?? "0";
                string curso = cmbCurso.SelectedValue?.ToString() ?? "";
                DateTime inicio = dtpInicio.Value;
                DateTime fim = dtpFim.Value;
                ExcelExporter.ExportToExcel(dgvDados, lblTotalRequerimentos.Text, lblTotalTickets.Text, usuario, curso, inicio, fim);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar Excel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
