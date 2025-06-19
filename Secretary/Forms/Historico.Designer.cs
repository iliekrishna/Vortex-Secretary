
namespace Secretary.Forms
{
    partial class Historico
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
            this.acoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltrarNomeRA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxStatusFiltrar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dateTimePickerFiltro = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acoes
            // 
            this.acoes.HeaderText = "Ações";
            this.acoes.Name = "acoes";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo de Documento";
            this.tipo.Name = "tipo";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome do Solicitante";
            this.nome.Name = "nome";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvHistorico.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nome,
            this.tipo,
            this.data,
            this.status,
            this.acoes});
            this.dgvHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorico.GridColor = System.Drawing.Color.White;
            this.dgvHistorico.Location = new System.Drawing.Point(20, 120);
            this.dgvHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(1283, 467);
            this.dgvHistorico.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome ou RA:";
            // 
            // txtFiltrarNomeRA
            // 
            this.txtFiltrarNomeRA.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFiltrarNomeRA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarNomeRA.Location = new System.Drawing.Point(126, 38);
            this.txtFiltrarNomeRA.Margin = new System.Windows.Forms.Padding(4, 4, 10, 4);
            this.txtFiltrarNomeRA.Name = "txtFiltrarNomeRA";
            this.txtFiltrarNomeRA.Size = new System.Drawing.Size(227, 22);
            this.txtFiltrarNomeRA.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status:";
            // 
            // cboxStatusFiltrar
            // 
            this.cboxStatusFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxStatusFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxStatusFiltrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboxStatusFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatusFiltrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxStatusFiltrar.FormattingEnabled = true;
            this.cboxStatusFiltrar.Items.AddRange(new object[] {
            "Todos",
            "Em andamento",
            "Concluído",
            "Cancelado"});
            this.cboxStatusFiltrar.Location = new System.Drawing.Point(426, 38);
            this.cboxStatusFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.cboxStatusFiltrar.Name = "cboxStatusFiltrar";
            this.cboxStatusFiltrar.Size = new System.Drawing.Size(157, 22);
            this.cboxStatusFiltrar.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.dateTimePickerFiltro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboxStatusFiltrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFiltrarNomeRA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(38);
            this.panel1.Size = new System.Drawing.Size(1283, 100);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(872, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ordenar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mais antigos",
            "Mais recentes"});
            this.comboBox1.Location = new System.Drawing.Point(961, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 22);
            this.comboBox1.TabIndex = 34;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFiltrar.Location = new System.Drawing.Point(1133, 38);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(10);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 24);
            this.btnFiltrar.TabIndex = 33;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFiltro
            // 
            this.dateTimePickerFiltro.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePickerFiltro.CustomFormat = "";
            this.dateTimePickerFiltro.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerFiltro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFiltro.Location = new System.Drawing.Point(663, 38);
            this.dateTimePickerFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFiltro.Name = "dateTimePickerFiltro";
            this.dateTimePickerFiltro.Size = new System.Drawing.Size(114, 22);
            this.dateTimePickerFiltro.TabIndex = 32;
            this.dateTimePickerFiltro.Value = new System.DateTime(2025, 5, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "Período:";
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1323, 607);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Historico";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Historico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn acoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltrarNomeRA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxStatusFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltro;
        private System.Windows.Forms.Label label3;
    }
}