
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltrarNomeRA = new System.Windows.Forms.TextBox();
            this.dateTimePickerFiltro = new System.Windows.Forms.DateTimePicker();
            this.acoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.cboxStatusFiltrar = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome ou RA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Período:";
            // 
            // txtFiltrarNomeRA
            // 
            this.txtFiltrarNomeRA.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarNomeRA.Location = new System.Drawing.Point(555, 66);
            this.txtFiltrarNomeRA.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltrarNomeRA.Name = "txtFiltrarNomeRA";
            this.txtFiltrarNomeRA.Size = new System.Drawing.Size(227, 22);
            this.txtFiltrarNomeRA.TabIndex = 17;
            // 
            // dateTimePickerFiltro
            // 
            this.dateTimePickerFiltro.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePickerFiltro.CustomFormat = "";
            this.dateTimePickerFiltro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFiltro.Location = new System.Drawing.Point(341, 66);
            this.dateTimePickerFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFiltro.Name = "dateTimePickerFiltro";
            this.dateTimePickerFiltro.Size = new System.Drawing.Size(113, 22);
            this.dateTimePickerFiltro.TabIndex = 18;
            this.dateTimePickerFiltro.Value = new System.DateTime(2025, 5, 23, 0, 0, 0, 0);
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
            this.dgvHistorico.GridColor = System.Drawing.Color.White;
            this.dgvHistorico.Location = new System.Drawing.Point(43, 160);
            this.dgvHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(813, 454);
            this.dgvHistorico.TabIndex = 19;
            // 
            // cboxStatusFiltrar
            // 
            this.cboxStatusFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxStatusFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxStatusFiltrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxStatusFiltrar.FormattingEnabled = true;
            this.cboxStatusFiltrar.Items.AddRange(new object[] {
            "Todos",
            "Em andamento",
            "Concluído",
            "Cancelado"});
            this.cboxStatusFiltrar.Location = new System.Drawing.Point(95, 69);
            this.cboxStatusFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.cboxStatusFiltrar.Name = "cboxStatusFiltrar";
            this.cboxStatusFiltrar.Size = new System.Drawing.Size(172, 22);
            this.cboxStatusFiltrar.TabIndex = 20;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(789, 65);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(69, 23);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 607);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cboxStatusFiltrar);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.dateTimePickerFiltro);
            this.Controls.Add(this.txtFiltrarNomeRA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Historico";
            this.Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltrarNomeRA;
        private System.Windows.Forms.DateTimePicker dateTimePickerFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn acoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.ComboBox cboxStatusFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
    }
}