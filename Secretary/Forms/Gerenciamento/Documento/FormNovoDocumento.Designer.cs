namespace Secretary.Forms.Gerenciamento
{
    partial class FormNovoDocumento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoDocumento));
            this.chbPagamentoTaxa = new System.Windows.Forms.CheckBox();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNomeDoc = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNomeDoc = new System.Windows.Forms.TextBox();
            this.lblTipoGratuidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoGratuidade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chbPagamentoTaxa
            // 
            this.chbPagamentoTaxa.AutoSize = true;
            this.chbPagamentoTaxa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentoTaxa.Location = new System.Drawing.Point(28, 186);
            this.chbPagamentoTaxa.Name = "chbPagamentoTaxa";
            this.chbPagamentoTaxa.Size = new System.Drawing.Size(444, 22);
            this.chbPagamentoTaxa.TabIndex = 68;
            this.chbPagamentoTaxa.Text = "Necessário pagamento de taxa em caso de segunda via";
            this.chbPagamentoTaxa.UseVisualStyleBackColor = true;
            this.chbPagamentoTaxa.CheckedChanged += new System.EventHandler(this.chbPagamentoTaxa_CheckedChanged);
            // 
            // panelDivisor
            // 
            this.panelDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor.Location = new System.Drawing.Point(21, 47);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(300, 1);
            this.panelDivisor.TabIndex = 66;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(19, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 23);
            this.lblTitulo.TabIndex = 61;
            this.lblTitulo.Text = "Adicionar Novo Documento";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(407, 275);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(166, 29);
            this.btnAdicionar.TabIndex = 67;
            this.btnAdicionar.Text = "Adicionar Documento";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // lblNomeDoc
            // 
            this.lblNomeDoc.AutoSize = true;
            this.lblNomeDoc.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeDoc.Location = new System.Drawing.Point(25, 88);
            this.lblNomeDoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomeDoc.Name = "lblNomeDoc";
            this.lblNomeDoc.Size = new System.Drawing.Size(176, 18);
            this.lblNomeDoc.TabIndex = 63;
            this.lblNomeDoc.Text = "Nome do Documento:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(206, 132);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(234, 23);
            this.txtDescricao.TabIndex = 65;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblDescricao.Location = new System.Drawing.Point(23, 132);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(180, 18);
            this.lblDescricao.TabIndex = 62;
            this.lblDescricao.Text = "Prazo de atendimento:";
            // 
            // txtNomeDoc
            // 
            this.txtNomeDoc.BackColor = System.Drawing.Color.White;
            this.txtNomeDoc.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNomeDoc.Location = new System.Drawing.Point(206, 88);
            this.txtNomeDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeDoc.Name = "txtNomeDoc";
            this.txtNomeDoc.Size = new System.Drawing.Size(354, 23);
            this.txtNomeDoc.TabIndex = 64;
            // 
            // lblTipoGratuidade
            // 
            this.lblTipoGratuidade.AutoSize = true;
            this.lblTipoGratuidade.Location = new System.Drawing.Point(28, 211);
            this.lblTipoGratuidade.Name = "lblTipoGratuidade";
            this.lblTipoGratuidade.Size = new System.Drawing.Size(0, 16);
            this.lblTipoGratuidade.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label1.Location = new System.Drawing.Point(38, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Limite de gratuidade:";
            // 
            // cbTipoGratuidade
            // 
            this.cbTipoGratuidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoGratuidade.Enabled = false;
            this.cbTipoGratuidade.FormattingEnabled = true;
            this.cbTipoGratuidade.Items.AddRange(new object[] {
            "Nenhuma",
            "Curso",
            "Período letivo"});
            this.cbTipoGratuidade.Location = new System.Drawing.Point(206, 227);
            this.cbTipoGratuidade.Name = "cbTipoGratuidade";
            this.cbTipoGratuidade.Size = new System.Drawing.Size(234, 24);
            this.cbTipoGratuidade.TabIndex = 71;
            // 
            // FormNovoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(594, 321);
            this.Controls.Add(this.cbTipoGratuidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoGratuidade);
            this.Controls.Add(this.chbPagamentoTaxa);
            this.Controls.Add(this.panelDivisor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblNomeDoc);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNomeDoc);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNovoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbPagamentoTaxa;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNomeDoc;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNomeDoc;
        private System.Windows.Forms.Label lblTipoGratuidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoGratuidade;
    }
}
