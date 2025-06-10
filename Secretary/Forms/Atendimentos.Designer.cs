
namespace Secretary.Forms
{
    partial class Atendimentos
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
            this.tabControlAtendimentos = new System.Windows.Forms.TabControl();
            this.tpagAberto = new System.Windows.Forms.TabPage();
            this.btnSimular = new System.Windows.Forms.Button();
            this.datagvEmAberto = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAssunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDetalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpagRespondido = new System.Windows.Forms.TabPage();
            this.datagvRespondidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAtendimentos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlAtendimentos.SuspendLayout();
            this.tpagAberto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvEmAberto)).BeginInit();
            this.tpagRespondido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvRespondidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAtendimentos
            // 
            this.tabControlAtendimentos.Controls.Add(this.tpagAberto);
            this.tabControlAtendimentos.Controls.Add(this.tpagRespondido);
            this.tabControlAtendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAtendimentos.Location = new System.Drawing.Point(20, 120);
            this.tabControlAtendimentos.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlAtendimentos.Name = "tabControlAtendimentos";
            this.tabControlAtendimentos.SelectedIndex = 0;
            this.tabControlAtendimentos.Size = new System.Drawing.Size(934, 651);
            this.tabControlAtendimentos.TabIndex = 0;
            // 
            // tpagAberto
            // 
            this.tpagAberto.AutoScroll = true;
            this.tpagAberto.Controls.Add(this.btnSimular);
            this.tpagAberto.Controls.Add(this.datagvEmAberto);
            this.tpagAberto.Location = new System.Drawing.Point(4, 27);
            this.tpagAberto.Margin = new System.Windows.Forms.Padding(4);
            this.tpagAberto.Name = "tpagAberto";
            this.tpagAberto.Padding = new System.Windows.Forms.Padding(4);
            this.tpagAberto.Size = new System.Drawing.Size(926, 620);
            this.tpagAberto.TabIndex = 0;
            this.tpagAberto.Text = "Em aberto";
            this.tpagAberto.UseVisualStyleBackColor = true;
            // 
            // btnSimular
            // 
            this.btnSimular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSimular.Location = new System.Drawing.Point(4, 566);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(918, 50);
            this.btnSimular.TabIndex = 9;
            this.btnSimular.Text = "Simular Atendimento";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // datagvEmAberto
            // 
            this.datagvEmAberto.AllowDrop = true;
            this.datagvEmAberto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvEmAberto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagvEmAberto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagvEmAberto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagvEmAberto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagvEmAberto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvEmAberto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colunaAssunto,
            this.colunaData,
            this.colunaID,
            this.colunaDetalhes});
            this.datagvEmAberto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvEmAberto.Location = new System.Drawing.Point(4, 4);
            this.datagvEmAberto.Name = "datagvEmAberto";
            this.datagvEmAberto.Size = new System.Drawing.Size(918, 612);
            this.datagvEmAberto.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // colunaAssunto
            // 
            this.colunaAssunto.HeaderText = "Assunto";
            this.colunaAssunto.Name = "colunaAssunto";
            this.colunaAssunto.ReadOnly = true;
            // 
            // colunaData
            // 
            this.colunaData.HeaderText = "Data";
            this.colunaData.Name = "colunaData";
            this.colunaData.ReadOnly = true;
            // 
            // colunaID
            // 
            this.colunaID.HeaderText = "ID";
            this.colunaID.Name = "colunaID";
            // 
            // colunaDetalhes
            // 
            this.colunaDetalhes.HeaderText = "Ação";
            this.colunaDetalhes.Name = "colunaDetalhes";
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
            this.tpagRespondido.Size = new System.Drawing.Size(926, 620);
            this.tpagRespondido.TabIndex = 1;
            this.tpagRespondido.Text = "Respondidos";
            this.tpagRespondido.UseVisualStyleBackColor = true;
            // 
            // datagvRespondidos
            // 
            this.datagvRespondidos.AllowDrop = true;
            this.datagvRespondidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvRespondidos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagvRespondidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagvRespondidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datagvRespondidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagvRespondidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvRespondidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.datagvRespondidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvRespondidos.Location = new System.Drawing.Point(4, 4);
            this.datagvRespondidos.Name = "datagvRespondidos";
            this.datagvRespondidos.Size = new System.Drawing.Size(918, 612);
            this.datagvRespondidos.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Assunto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Respondido em";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Data";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Assunto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // lblAtendimentos
            // 
            this.lblAtendimentos.AutoSize = true;
            this.lblAtendimentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAtendimentos.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimentos.Location = new System.Drawing.Point(30, 30);
            this.lblAtendimentos.Margin = new System.Windows.Forms.Padding(0);
            this.lblAtendimentos.Name = "lblAtendimentos";
            this.lblAtendimentos.Size = new System.Drawing.Size(157, 25);
            this.lblAtendimentos.TabIndex = 8;
            this.lblAtendimentos.Text = "Atendimentos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAtendimentos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(934, 100);
            this.panel1.TabIndex = 1;
            // 
            // Atendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 791);
            this.Controls.Add(this.tabControlAtendimentos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Atendimentos";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Atendimentos";
            this.tabControlAtendimentos.ResumeLayout(false);
            this.tpagAberto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvEmAberto)).EndInit();
            this.tpagRespondido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvRespondidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAtendimentos;
        private System.Windows.Forms.TabPage tpagAberto;
        private System.Windows.Forms.DataGridView datagvEmAberto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaAssunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDetalhes;
        private System.Windows.Forms.TabPage tpagRespondido;
        private System.Windows.Forms.DataGridView datagvRespondidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblAtendimentos;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Panel panel1;
    }
}