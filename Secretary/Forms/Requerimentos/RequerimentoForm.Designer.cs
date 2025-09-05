using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms
{
    partial class RequerimentoForm
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
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tabControlRequerimentos = new System.Windows.Forms.TabControl();
            this.tpagAberto = new System.Windows.Forms.TabPage();
            this.datagvEmAberto = new System.Windows.Forms.DataGridView();
            this.tpagRespondido = new System.Windows.Forms.TabPage();
            this.datagvRespondidos = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colunaDetalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFiltros.SuspendLayout();
            this.tabControlRequerimentos.SuspendLayout();
            this.tpagAberto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvEmAberto)).BeginInit();
            this.tpagRespondido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvRespondidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.cbDocumento);
            this.panelFiltros.Controls.Add(this.lblDocumento);
            this.panelFiltros.Controls.Add(this.cbCurso);
            this.panelFiltros.Controls.Add(this.lblCurso);
            this.panelFiltros.Controls.Add(this.txtBuscar);
            this.panelFiltros.Controls.Add(this.lblBuscar);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(20, 20);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(30);
            this.panelFiltros.Size = new System.Drawing.Size(1328, 100);
            this.panelFiltros.TabIndex = 2;
            // 
            // cbDocumento
            // 
            this.cbDocumento.BackColor = System.Drawing.SystemColors.Menu;
            this.cbDocumento.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Location = new System.Drawing.Point(986, 30);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(319, 26);
            this.cbDocumento.TabIndex = 45;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDocumento.Location = new System.Drawing.Point(854, 30);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblDocumento.Size = new System.Drawing.Size(132, 18);
            this.lblDocumento.TabIndex = 44;
            this.lblDocumento.Text = "Documento:";
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.SystemColors.Menu;
            this.cbCurso.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(523, 30);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(331, 26);
            this.cbCurso.TabIndex = 43;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCurso.Location = new System.Drawing.Point(434, 30);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblCurso.Size = new System.Drawing.Size(89, 18);
            this.lblCurso.TabIndex = 42;
            this.lblCurso.Text = "Curso:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(95, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(339, 26);
            this.txtBuscar.TabIndex = 41;
            this.txtBuscar.Text = "Nome ou RA";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(30, 30);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(65, 18);
            this.lblBuscar.TabIndex = 40;
            this.lblBuscar.Text = "Buscar:";
            // 
            // tabControlRequerimentos
            // 
            this.tabControlRequerimentos.Controls.Add(this.tpagAberto);
            this.tabControlRequerimentos.Controls.Add(this.tpagRespondido);
            this.tabControlRequerimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRequerimentos.Location = new System.Drawing.Point(20, 120);
            this.tabControlRequerimentos.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlRequerimentos.Name = "tabControlRequerimentos";
            this.tabControlRequerimentos.SelectedIndex = 0;
            this.tabControlRequerimentos.Size = new System.Drawing.Size(1328, 609);
            this.tabControlRequerimentos.TabIndex = 3;
            // 
            // tpagAberto
            // 
            this.tpagAberto.AutoScroll = true;
            this.tpagAberto.Controls.Add(this.datagvEmAberto);
            this.tpagAberto.Location = new System.Drawing.Point(4, 27);
            this.tpagAberto.Margin = new System.Windows.Forms.Padding(4);
            this.tpagAberto.Name = "tpagAberto";
            this.tpagAberto.Padding = new System.Windows.Forms.Padding(4);
            this.tpagAberto.Size = new System.Drawing.Size(1320, 578);
            this.tpagAberto.TabIndex = 0;
            this.tpagAberto.Text = "Em aberto";
            this.tpagAberto.UseVisualStyleBackColor = true;
            // 
            // datagvEmAberto
            // 
            this.datagvEmAberto.AllowDrop = true;
            this.datagvEmAberto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagvEmAberto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagvEmAberto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagvEmAberto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagvEmAberto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.datagvEmAberto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagvEmAberto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvEmAberto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvEmAberto.Location = new System.Drawing.Point(4, 4);
            this.datagvEmAberto.Name = "datagvEmAberto";
            this.datagvEmAberto.ReadOnly = true;
            this.datagvEmAberto.Size = new System.Drawing.Size(1312, 570);
            this.datagvEmAberto.TabIndex = 2;
            // 
            // tpagRespondido
            // 
            this.tpagRespondido.AutoScroll = true;
            this.tpagRespondido.Controls.Add(this.datagvRespondidos);
            this.tpagRespondido.Controls.Add(this.dataGridView1);
            this.tpagRespondido.Location = new System.Drawing.Point(4, 27);
            this.tpagRespondido.Margin = new System.Windows.Forms.Padding(4);
            this.tpagRespondido.Name = "tpagRespondido";
            this.tpagRespondido.Padding = new System.Windows.Forms.Padding(4);
            this.tpagRespondido.Size = new System.Drawing.Size(1320, 578);
            this.tpagRespondido.TabIndex = 1;
            this.tpagRespondido.Text = "Respondidos";
            this.tpagRespondido.UseVisualStyleBackColor = true;
            // 
            // datagvRespondidos
            // 
            this.datagvRespondidos.AllowDrop = true;
            this.datagvRespondidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagvRespondidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagvRespondidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagvRespondidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagvRespondidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.datagvRespondidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagvRespondidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvRespondidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvRespondidos.Location = new System.Drawing.Point(4, 4);
            this.datagvRespondidos.Name = "datagvRespondidos";
            this.datagvRespondidos.ReadOnly = true;
            this.datagvRespondidos.Size = new System.Drawing.Size(1312, 570);
            this.datagvRespondidos.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 454);
            this.dataGridView1.TabIndex = 4;
            // 
            // colunaDetalhes
            // 
            this.colunaDetalhes.Name = "colunaDetalhes";
            // 
            // colunaID
            // 
            this.colunaID.Name = "colunaID";
            // 
            // colunaData
            // 
            this.colunaData.Name = "colunaData";
            // 
            // colunaAssunto
            // 
            this.colunaAssunto.Name = "colunaAssunto";
            // 
            // Column1
            // 
            this.Column1.Name = "Column1";
            // 
            // RequerimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1368, 749);
            this.Controls.Add(this.tabControlRequerimentos);
            this.Controls.Add(this.panelFiltros);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequerimentoForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Atendimentos";
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.tabControlRequerimentos.ResumeLayout(false);
            this.tpagAberto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvEmAberto)).EndInit();
            this.tpagRespondido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvRespondidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFiltros;
        private TabControl tabControlRequerimentos;
        private TabPage tpagAberto;
        private DataGridView datagvEmAberto;
        private TabPage tpagRespondido;
        private DataGridView datagvRespondidos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colunaDetalhes;
        private DataGridViewTextBoxColumn colunaID;
        private DataGridViewTextBoxColumn colunaData;
        private DataGridViewTextBoxColumn colunaAssunto;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private ComboBox cbDocumento;
        private Label lblDocumento;
        private ComboBox cbCurso;
        private Label lblCurso;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}