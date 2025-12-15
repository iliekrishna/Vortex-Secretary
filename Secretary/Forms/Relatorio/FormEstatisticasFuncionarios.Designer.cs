using System.Windows.Forms;

namespace Secretary.Forms
{
    partial class FormEstatisticasFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.tableFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.paneTable = new System.Windows.Forms.Panel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.panelBotao = new System.Windows.Forms.Panel();
            this.btnBaixarPDF = new System.Windows.Forms.Button();
            this.btnBaixarExcel = new System.Windows.Forms.Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblTotalRequerimentos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelFiltros.SuspendLayout();
            this.tableFiltros.SuspendLayout();
            this.panelConteudo.SuspendLayout();
            this.paneTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panelBotao.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.AutoSize = true;
            this.panelFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFiltros.Controls.Add(this.tableFiltros);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(34, 34, 34, 10);
            this.panelFiltros.Size = new System.Drawing.Size(1370, 76);
            this.panelFiltros.TabIndex = 3;
            // 
            // tableFiltros
            // 
            this.tableFiltros.AutoSize = true;
            this.tableFiltros.ColumnCount = 8;
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableFiltros.Controls.Add(this.dtpFim, 7, 0);
            this.tableFiltros.Controls.Add(this.lblDataFim, 6, 0);
            this.tableFiltros.Controls.Add(this.dtpInicio, 5, 0);
            this.tableFiltros.Controls.Add(this.lblDataInicio, 4, 0);
            this.tableFiltros.Controls.Add(this.cmbCurso, 3, 0);
            this.tableFiltros.Controls.Add(this.lblCurso, 2, 0);
            this.tableFiltros.Controls.Add(this.cmbUsuario, 1, 0);
            this.tableFiltros.Controls.Add(this.lblUsuario, 0, 0);
            this.tableFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFiltros.Location = new System.Drawing.Point(34, 34);
            this.tableFiltros.Name = "tableFiltros";
            this.tableFiltros.RowCount = 1;
            this.tableFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFiltros.Size = new System.Drawing.Size(1302, 32);
            this.tableFiltros.TabIndex = 54;
            // 
            // dtpFim
            // 
            this.dtpFim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(1090, 3);
            this.dtpFim.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(209, 26);
            this.dtpFim.TabIndex = 60;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDataFim.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFim.Location = new System.Drawing.Point(1044, 0);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDataFim.Size = new System.Drawing.Size(40, 32);
            this.lblDataFim.TabIndex = 59;
            this.lblDataFim.Text = "Até:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(831, 3);
            this.dtpInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(207, 26);
            this.dtpInicio.TabIndex = 58;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDataInicio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(785, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblDataInicio.Size = new System.Drawing.Size(40, 32);
            this.lblDataInicio.TabIndex = 57;
            this.lblDataInicio.Text = "De:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(465, 3);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(314, 26);
            this.cmbCurso.TabIndex = 56;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCurso.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(400, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblCurso.Size = new System.Drawing.Size(59, 32);
            this.lblCurso.TabIndex = 55;
            this.lblCurso.Text = "Curso:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(80, 3);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(314, 26);
            this.cmbUsuario.TabIndex = 50;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(3, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblUsuario.Size = new System.Drawing.Size(71, 32);
            this.lblUsuario.TabIndex = 41;
            this.lblUsuario.Text = "Usuário:";
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.paneTable);
            this.panelConteudo.Controls.Add(this.panelCards);
            this.panelConteudo.Controls.Add(this.lblResultado);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConteudo.Location = new System.Drawing.Point(0, 76);
            this.panelConteudo.Margin = new System.Windows.Forms.Padding(34);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Padding = new System.Windows.Forms.Padding(34);
            this.panelConteudo.Size = new System.Drawing.Size(1370, 612);
            this.panelConteudo.TabIndex = 46;
            // 
            // paneTable
            // 
            this.paneTable.Controls.Add(this.dgvDados);
            this.paneTable.Controls.Add(this.panelBotao);
            this.paneTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneTable.Location = new System.Drawing.Point(452, 83);
            this.paneTable.Name = "paneTable";
            this.paneTable.Padding = new System.Windows.Forms.Padding(20, 22, 20, 5);
            this.paneTable.Size = new System.Drawing.Size(884, 495);
            this.paneTable.TabIndex = 53;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowDrop = true;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvDados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(20, 22);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(844, 340);
            this.dgvDados.TabIndex = 51;
            // 
            // panelBotao
            // 
            this.panelBotao.Controls.Add(this.btnBaixarPDF);
            this.panelBotao.Controls.Add(this.btnBaixarExcel);
            this.panelBotao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotao.Location = new System.Drawing.Point(20, 362);
            this.panelBotao.Name = "panelBotao";
            this.panelBotao.Padding = new System.Windows.Forms.Padding(20, 20, 20, 50);
            this.panelBotao.Size = new System.Drawing.Size(844, 128);
            this.panelBotao.TabIndex = 50;
            // 
            // btnBaixarPDF
            // 
            this.btnBaixarPDF.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBaixarPDF.FlatAppearance.BorderSize = 0;
            this.btnBaixarPDF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarPDF.ForeColor = System.Drawing.Color.Black;
            this.btnBaixarPDF.Image = global::Secretary.Properties.Resources.pdf__1_;
            this.btnBaixarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaixarPDF.Location = new System.Drawing.Point(434, 20);
            this.btnBaixarPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBaixarPDF.Name = "btnBaixarPDF";
            this.btnBaixarPDF.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnBaixarPDF.Size = new System.Drawing.Size(195, 58);
            this.btnBaixarPDF.TabIndex = 50;
            this.btnBaixarPDF.Text = "   Baixar PDF";
            this.btnBaixarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaixarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaixarPDF.UseVisualStyleBackColor = true;
            this.btnBaixarPDF.Click += new System.EventHandler(this.btnBaixarPDF_Click);
            // 
            // btnBaixarExcel
            // 
            this.btnBaixarExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBaixarExcel.FlatAppearance.BorderSize = 0;
            this.btnBaixarExcel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixarExcel.ForeColor = System.Drawing.Color.Black;
            this.btnBaixarExcel.Image = global::Secretary.Properties.Resources.excel;
            this.btnBaixarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaixarExcel.Location = new System.Drawing.Point(629, 20);
            this.btnBaixarExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBaixarExcel.Name = "btnBaixarExcel";
            this.btnBaixarExcel.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnBaixarExcel.Size = new System.Drawing.Size(195, 58);
            this.btnBaixarExcel.TabIndex = 49;
            this.btnBaixarExcel.Text = "   Baixar Excel";
            this.btnBaixarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaixarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaixarExcel.UseVisualStyleBackColor = true;
            this.btnBaixarExcel.Click += new System.EventHandler(this.btnBaixarExcel_Click);
            // 
            // panelCards
            // 
            this.panelCards.Controls.Add(this.panel1);
            this.panelCards.Controls.Add(this.panel2);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCards.Location = new System.Drawing.Point(34, 83);
            this.panelCards.Name = "panelCards";
            this.panelCards.Padding = new System.Windows.Forms.Padding(10);
            this.panelCards.Size = new System.Drawing.Size(418, 495);
            this.panelCards.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 191);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(398, 185);
            this.panel1.TabIndex = 58;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblTotalTickets);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 10);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(20);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(15);
            this.materialCard1.Size = new System.Drawing.Size(378, 158);
            this.materialCard1.TabIndex = 53;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalTickets.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTickets.Location = new System.Drawing.Point(15, 74);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Padding = new System.Windows.Forms.Padding(10);
            this.lblTotalTickets.Size = new System.Drawing.Size(348, 69);
            this.lblTotalTickets.TabIndex = 43;
            this.lblTotalTickets.Text = "Total";
            this.lblTotalTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label6.Size = new System.Drawing.Size(348, 59);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tickets Atendidos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialCard3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(398, 181);
            this.panel2.TabIndex = 57;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lblTotalRequerimentos);
            this.materialCard3.Controls.Add(this.label3);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(10, 10);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(20);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(15);
            this.materialCard3.Size = new System.Drawing.Size(378, 158);
            this.materialCard3.TabIndex = 52;
            // 
            // lblTotalRequerimentos
            // 
            this.lblTotalRequerimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalRequerimentos.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRequerimentos.Location = new System.Drawing.Point(15, 74);
            this.lblTotalRequerimentos.Name = "lblTotalRequerimentos";
            this.lblTotalRequerimentos.Padding = new System.Windows.Forms.Padding(10);
            this.lblTotalRequerimentos.Size = new System.Drawing.Size(348, 69);
            this.lblTotalRequerimentos.TabIndex = 43;
            this.lblTotalRequerimentos.Text = "Total";
            this.lblTotalRequerimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.label3.Size = new System.Drawing.Size(348, 59);
            this.label3.TabIndex = 42;
            this.label3.Text = "Requerimentos Atendidos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(34, 34);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(30);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblResultado.Size = new System.Drawing.Size(275, 49);
            this.lblResultado.TabIndex = 45;
            this.lblResultado.Text = "Resultado da consulta";
            // 
            // FormEstatisticasFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelFiltros);
            this.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEstatisticasFuncionarios";
            this.Text = "Estatísticas Funcionários";
            this.Load += new System.EventHandler(this.FormEstatisticasFuncionarios_Load);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.tableFiltros.ResumeLayout(false);
            this.tableFiltros.PerformLayout();
            this.panelConteudo.ResumeLayout(false);
            this.panelConteudo.PerformLayout();
            this.paneTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panelBotao.ResumeLayout(false);
            this.panelCards.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnBaixarExcel;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Label lblTotalRequerimentos;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel paneTable;
        private System.Windows.Forms.Panel panelBotao;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnBaixarPDF;
        private System.Windows.Forms.TableLayoutPanel tableFiltros;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblUsuario;
    }
}