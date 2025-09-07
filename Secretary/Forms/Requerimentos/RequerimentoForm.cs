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

namespace Secretary.Forms
{
    public partial class RequerimentoForm : Form
    {
        private readonly string _placeholder = "Nome, CPF ou RA";
        private Timer _debounceTimer;


        private int usuarioId;

        public RequerimentoForm(int usuarioId)
        {
            InitializeComponent();

            // placeholder + eventos
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            // debounce (300ms)
            _debounceTimer = new Timer { Interval = 300 };
            _debounceTimer.Tick += (s, e) => { _debounceTimer.Stop(); DispararBusca(); };


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

                try
                {
                    var documentosDisponiveis = RequerimentoDAO.ListarDocumentosDisponiveis();
                    foreach (var doc in documentosDisponiveis)
                    {
                        cbDocumento.Items.Add(doc);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar documentos disponíveis: " + ex.Message);
                }
                cbDocumento.SelectedIndex = 0;
                SetPlaceholder();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar filtros: " + ex.Message);
            }

        }

        private void SetPlaceholder()
        {
            txtBuscar.Text = _placeholder;
            txtBuscar.ForeColor = Color.Gray;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.ForeColor == Color.Gray)
            {
                txtBuscar.Clear();
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                SetPlaceholder();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.ForeColor == Color.Gray) return; // ignora enquanto placeholder
            _debounceTimer.Stop();
            _debounceTimer.Start();
        }

        private void DispararBusca()
        {
            string termo = (txtBuscar.ForeColor == Color.Gray) ? "" : txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(termo))
                AplicarFiltros();           // volta à listagem normal
            else
                BuscarRequerimentos(termo); // busca por Nome/RA
        }

        private void AplicarFiltros()
        {
            // Se há texto de busca, reaplica a busca com os novos filtros
            var termo = (txtBuscar.ForeColor == Color.Gray) ? "" : txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(termo))
            {
                BuscarRequerimentos(termo);
                return;
            }

            // ... seu código atual que carrega em aberto e respondidos sem termo
            string curso = cbCurso.SelectedItem?.ToString() ?? "Todos";
            string documento = cbDocumento.SelectedItem?.ToString() ?? "Todos";

            try
            {
                DataTable dtAberto = RequerimentoDAO.ListarRequerimentos("aberto", curso, documento);
                datagvEmAberto.Columns.Clear();
                datagvEmAberto.DataSource = dtAberto;
                AjustarColunasEmAberto(datagvEmAberto);

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
        private void BuscarRequerimentos(string termo)
        {
            try
            {
                string curso = cbCurso.SelectedItem?.ToString() ?? "Todos";
                string documento = cbDocumento.SelectedItem?.ToString() ?? "Todos";

                var dtAberto = RequerimentoDAO.BuscarRequerimentos("aberto", curso, documento, termo);
                datagvEmAberto.Columns.Clear();
                datagvEmAberto.DataSource = dtAberto;
                AjustarColunasEmAberto(datagvEmAberto);

                var dtRespondido = RequerimentoDAO.BuscarRequerimentos("respondido", curso, documento, termo);
                datagvRespondidos.Columns.Clear();
                datagvRespondidos.DataSource = dtRespondido;
                AjustarColunasRespondidos(datagvRespondidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar requerimentos: " + ex.Message);
            }
        }

    }

}