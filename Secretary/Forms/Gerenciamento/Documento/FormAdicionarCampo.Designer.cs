namespace Secretary.Forms.Gerenciamento.Documento
{
    partial class FormAdicionarCampo
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNomeCampo = new System.Windows.Forms.Label();
            this.txtNomeCampo = new System.Windows.Forms.TextBox();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chkObrigatorio = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpcoes = new System.Windows.Forms.TextBox();
            this.lblOpcoesCombo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(395, 189);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(166, 29);
            this.btnAdicionar.TabIndex = 63;
            this.btnAdicionar.Text = "Adicionar Campo";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // lblNomeCampo
            // 
            this.lblNomeCampo.AutoSize = true;
            this.lblNomeCampo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeCampo.Location = new System.Drawing.Point(14, 77);
            this.lblNomeCampo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomeCampo.Name = "lblNomeCampo";
            this.lblNomeCampo.Size = new System.Drawing.Size(143, 18);
            this.lblNomeCampo.TabIndex = 60;
            this.lblNomeCampo.Text = "Nome do Campo:";
            // 
            // txtNomeCampo
            // 
            this.txtNomeCampo.BackColor = System.Drawing.Color.White;
            this.txtNomeCampo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNomeCampo.Location = new System.Drawing.Point(163, 76);
            this.txtNomeCampo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeCampo.Name = "txtNomeCampo";
            this.txtNomeCampo.Size = new System.Drawing.Size(398, 23);
            this.txtNomeCampo.TabIndex = 61;
            // 
            // panelDivisor
            // 
            this.panelDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor.Location = new System.Drawing.Point(15, 45);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(250, 1);
            this.panelDivisor.TabIndex = 65;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(13, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 23);
            this.lblTitulo.TabIndex = 64;
            this.lblTitulo.Text = "Adicionar Novo Campo";
            // 
            // chkObrigatorio
            // 
            this.chkObrigatorio.AutoSize = true;
            this.chkObrigatorio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkObrigatorio.Location = new System.Drawing.Point(400, 146);
            this.chkObrigatorio.Name = "chkObrigatorio";
            this.chkObrigatorio.Size = new System.Drawing.Size(167, 22);
            this.chkObrigatorio.TabIndex = 66;
            this.chkObrigatorio.Text = "Campo obrigatório";
            this.chkObrigatorio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tipo de Campo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Texto",
            "Imagem",
            "Seleção"});
            this.comboBox1.Location = new System.Drawing.Point(163, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(398, 24);
            this.comboBox1.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOpcoes);
            this.panel1.Controls.Add(this.lblOpcoesCombo);
            this.panel1.Location = new System.Drawing.Point(12, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 164);
            this.panel1.TabIndex = 69;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Insira as opções separadas por \" , \" (vírgula). Ex.: \"Opção 1, Opção 2, Opção 3, " +
    "...\"\r\n";
            // 
            // txtOpcoes
            // 
            this.txtOpcoes.BackColor = System.Drawing.Color.White;
            this.txtOpcoes.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtOpcoes.Location = new System.Drawing.Point(8, 46);
            this.txtOpcoes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOpcoes.Multiline = true;
            this.txtOpcoes.Name = "txtOpcoes";
            this.txtOpcoes.Size = new System.Drawing.Size(531, 89);
            this.txtOpcoes.TabIndex = 70;
            // 
            // lblOpcoesCombo
            // 
            this.lblOpcoesCombo.AutoSize = true;
            this.lblOpcoesCombo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblOpcoesCombo.Location = new System.Drawing.Point(5, 18);
            this.lblOpcoesCombo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOpcoesCombo.Name = "lblOpcoesCombo";
            this.lblOpcoesCombo.Size = new System.Drawing.Size(157, 18);
            this.lblOpcoesCombo.TabIndex = 70;
            this.lblOpcoesCombo.Text = "Opções de Seleção:";
            // 
            // FormAdicionarCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 225);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkObrigatorio);
            this.Controls.Add(this.panelDivisor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblNomeCampo);
            this.Controls.Add(this.txtNomeCampo);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAdicionarCampo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Novo Campo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNomeCampo;
        private System.Windows.Forms.TextBox txtNomeCampo;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox chkObrigatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOpcoes;
        private System.Windows.Forms.Label lblOpcoesCombo;
        private System.Windows.Forms.Label label2;
    }
}