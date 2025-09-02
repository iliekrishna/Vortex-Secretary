using MySql.Data.MySqlClient;
using Secretary.DAO;
using Secretary.Forms.Gerenciamento;
using Secretary.Forms.Gerenciamento.FAQ;
using Secretary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Secretary.Forms.Requerimentos;

namespace Secretary.Forms
{
    public partial class Requerimento : Form
    {
        private int usuarioId;

        public Requerimento(int usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.Load += Requerimentos_Load;

            datagvEmAberto.CellDoubleClick += DatagvEmAberto_CellDoubleClick;
            datagvRespondidos.CellDoubleClick += DatagvRespondidos_CellDoubleClick;

            cbCurso.SelectedIndexChanged += (s, e) => AplicarFiltros();
            cbDocumento.SelectedIndexChanged += (s, e) => AplicarFiltros();
        }

        private void Requerimentos_Load(object sender, EventArgs e)
        {
            try
            {
                // Popula combo Curso
                cbCurso.Items.Clear();
                cbCurso.Items.Add("Todos");
                cbCurso.Items.AddRange(new string[] {
                    "Logística Aeroportuária", "Logística Tarde", "Logística Noite",
                    "Gestão Empresarial (EAD)", "Análise e Desenvolvimento de Sistemas",
                    "Comércio Exterior", "Gestão da Produção Industrial"
                });
                cbCurso.SelectedIndex = 0;

                // Popula combo Documento
                cbDocumento.Items.Clear();
                cbDocumento.Items.Add("Todos");
                cbDocumento.Items.AddRange(new string[] {
                    "Histórico Escolar", "Declaração de Matrícula", "Atestado de Frequência",
                    "Diploma", "Outros"
                });
                cbDocumento.SelectedIndex = 0;

                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar filtros: " + ex.Message);
            }
        }

        private void AplicarFiltros()
        {
            string curso = cbCurso.SelectedItem?.ToString() ?? "Todos";
            string documento = cbDocumento.SelectedItem?.ToString() ?? "Todos";

            try
            {
                // Listar requerimentos em aberto
                DataTable dtAberto = RequerimentoDAO.ListarRequerimentos("aberto", curso, documento);
                datagvEmAberto.Columns.Clear();
                datagvEmAberto.DataSource = dtAberto;
                AjustarColunasEmAberto(datagvEmAberto);

                // Listar requerimentos respondidos
                DataTable dtRespondido = RequerimentoDAO.ListarRequerimentos("respondido", curso, documento);
                datagvRespondidos.Columns.Clear();
                datagvRespondidos.DataSource = dtRespondido;
                AjustarColunasRespondidos(datagvRespondidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar filtros: " + ex.Message);
            }
        }

        private void AjustarColunasEmAberto(DataGridView dgv)
        {
            if (dgv.Columns.Contains("ID"))
                dgv.Columns["ID"].Visible = false;

            if (dgv.Columns.Contains("Data"))
                dgv.Columns["Data"].Width = 120;

            // Ajuste outras colunas conforme necessidade
        }

        private void AjustarColunasRespondidos(DataGridView dgv)
        {
            if (dgv.Columns.Contains("ID"))
                dgv.Columns["ID"].Visible = false;

            if (dgv.Columns.Contains("Data de Resposta"))
                dgv.Columns["Data de Resposta"].Width = 140;

            if (dgv.Columns.Contains("Respondido Por"))
                dgv.Columns["Respondido Por"].Width = 150;

            // Ajuste outras colunas conforme necessidade
        }

        private void DatagvEmAberto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int idRequerimento = Convert.ToInt32(datagvEmAberto.Rows[e.RowIndex].Cells["ID"].Value);

                var formResponder = new ResponderRequerimento(idRequerimento, usuarioId);
                formResponder.StartPosition = FormStartPosition.CenterParent;
                formResponder.ShowDialog();

                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário de resposta: " + ex.Message);
            }
        }

        private void DatagvRespondidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int idRequerimento = Convert.ToInt32(datagvRespondidos.Rows[e.RowIndex].Cells["ID"].Value);

                var formDetalhes = new DetalhesRequerimento(idRequerimento);
                formDetalhes.StartPosition = FormStartPosition.CenterParent;
                formDetalhes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário de detalhes: " + ex.Message);
            }
        }
    }
}