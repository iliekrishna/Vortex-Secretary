using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;

namespace Secretary.Utils
{
    public static class ExcelExporter
    {
        public static void ExportToExcel(DataGridView dgv, string totalRequerimentos, string totalTickets, string usuario, string curso, DateTime inicio, DateTime fim)
        {
            // Cria um SaveFileDialog para o usuário escolher onde salvar
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Salvar Relatório como Excel",
                FileName = $"Relatorio_Funcionarios_{DateTime.Now:yyyyMMdd}.xlsx"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            // Cria o arquivo Excel
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Relatório");

                // Cabeçalho (linhas 1-7)
                worksheet.Cells[1, 1].Value = "Relatório de Funcionários";
                worksheet.Cells[2, 1].Value = $"Data da geração do relatório: {DateTime.Now:dd/MM/yyyy HH:mm}";
                worksheet.Cells[3, 1].Value = $"Funcionário: {(usuario == "0" ? "Todos os Usuários" : usuario)}";
                worksheet.Cells[4, 1].Value = $"Curso: {(string.IsNullOrEmpty(curso) ? "Todos os Cursos" : curso)}";
                worksheet.Cells[5, 1].Value = $"Período de: {inicio:dd/MM/yyyy} até: {fim:dd/MM/yyyy}";
                worksheet.Cells[6, 1].Value = $"Total de Requerimentos Atendidos: {totalRequerimentos}";
                worksheet.Cells[7, 1].Value = $"Total de Tickets Atendidos: {totalTickets}";

                // Tabela do DataGridView (a partir da linha 9)
                int startRow = 9;
                int colIndex = 1;

                // Cabeçalhos da tabela
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    worksheet.Cells[startRow, colIndex].Value = col.HeaderText;
                    colIndex++;
                }

                // Dados da tabela
                int rowIndex = startRow + 1;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    colIndex = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        worksheet.Cells[rowIndex, colIndex].Value = cell.Value?.ToString() ?? "";
                        colIndex++;
                    }
                    rowIndex++;
                }

                // Rodapé (última linha)
                worksheet.Cells[rowIndex + 2, 1].Value = "Fatec Guarulhos - Sistema Vortex";

                // Salva o arquivo
                File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                MessageBox.Show("Excel gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}