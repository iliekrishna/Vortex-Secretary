
namespace Secretary.Forms.Atendimentos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbVinculo = new System.Windows.Forms.ComboBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
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
            this.tabControlAtendimentos.Size = new System.Drawing.Size(1328, 609);
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
            this.tpagAberto.Size = new System.Drawing.Size(1320, 578);
            this.tpagAberto.TabIndex = 0;
            this.tpagAberto.Text = "Em aberto";
            this.tpagAberto.UseVisualStyleBackColor = true;
            // 
            // btnSimular
            // 
            this.btnSimular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSimular.Location = new System.Drawing.Point(4, 524);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(1312, 50);
            this.btnSimular.TabIndex = 9;
            this.btnSimular.Text = "Simular Atendimento";
            this.btnSimular.UseVisualStyleBackColor = true;
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
            this.datagvEmAberto.ReadOnly = true;
            this.datagvEmAberto.Size = new System.Drawing.Size(1312, 570);
            this.datagvEmAberto.TabIndex = 2;
            this.datagvEmAberto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvEmAberto_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.colunaID.ReadOnly = true;
            // 
            // colunaDetalhes
            // 
            this.colunaDetalhes.HeaderText = "Ação";
            this.colunaDetalhes.Name = "colunaDetalhes";
            this.colunaDetalhes.ReadOnly = true;
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
            this.datagvRespondidos.ReadOnly = true;
            this.datagvRespondidos.Size = new System.Drawing.Size(1312, 570);
            this.datagvRespondidos.TabIndex = 5;
            this.datagvRespondidos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagvRespondidos_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.cbVinculo);
            this.panel1.Controls.Add(this.cbCurso);
            this.panel1.Controls.Add(this.lblAtendimentos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(1328, 100);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(936, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo de Vinculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label1.Location = new System.Drawing.Point(250, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtros:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Menu;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(1029, 34);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(212, 26);
            this.cbCategoria.TabIndex = 11;
            // 
            // cbVinculo
            // 
            this.cbVinculo.BackColor = System.Drawing.SystemColors.Menu;
            this.cbVinculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVinculo.FormattingEnabled = true;
            this.cbVinculo.Location = new System.Drawing.Point(760, 34);
            this.cbVinculo.Name = "cbVinculo";
            this.cbVinculo.Size = new System.Drawing.Size(170, 26);
            this.cbVinculo.TabIndex = 10;
            // 
            // cbCurso
            // 
            this.cbCurso.BackColor = System.Drawing.SystemColors.Menu;
            this.cbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(408, 34);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(214, 26);
            this.cbCurso.TabIndex = 9;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // Atendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 749);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbVinculo;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimular;
    }
}