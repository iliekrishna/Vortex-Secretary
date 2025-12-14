using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace Secretary.Utils
{
    public static class PdfExporter
    {
        public static void ExportToPdf(DataGridView dgv, string totalRequerimentos, string totalTickets, string usuario, string curso, DateTime inicio, DateTime fim)
        {
            // Cria um SaveFileDialog para o usuário escolher onde salvar
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Salvar Relatório como PDF",
                FileName = $"Relatorio_Funcionarios_{DateTime.Now:yyyyMMdd}.pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            // Cria o documento PDF
            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
            doc.Open();

            // Fonte padrão
            Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            // Título
            doc.Add(new Paragraph("Relatório de Funcionários", titleFont));
            doc.Add(new Paragraph(" ")); // Espaço

            // Cabeçalho
            doc.Add(new Paragraph($"Data da geração do relatório: {DateTime.Now:dd/MM/yyyy HH:mm}", headerFont));
            doc.Add(new Paragraph($"Funcionário: {(usuario == "0" ? "Todos os Usuários" : usuario)}", headerFont));
            doc.Add(new Paragraph($"Curso: {(string.IsNullOrEmpty(curso) ? "Todos os Cursos" : curso)}", headerFont));
            doc.Add(new Paragraph($"Período de: {inicio:dd/MM/yyyy} até: {fim:dd/MM/yyyy}", headerFont));
            doc.Add(new Paragraph($"Total de Requerimentos Atendidos: {totalRequerimentos}", headerFont));
            doc.Add(new Paragraph($"Total de Tickets Atendidos: {totalTickets}", headerFont));
            doc.Add(new Paragraph(" ")); // Espaço

            // Tabela do DataGridView
            PdfPTable table = new PdfPTable(dgv.Columns.Count);
            table.WidthPercentage = 100;

            // Cabeçalhos da tabela
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                table.AddCell(new Phrase(col.HeaderText, normalFont));
            }

            // Dados da tabela
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Phrase(cell.Value?.ToString() ?? "", normalFont));
                }
            }

            doc.Add(table);

            // Rodapé
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Fatec Guarulhos - Sistema Vortex", headerFont));

            doc.Close();
            MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}