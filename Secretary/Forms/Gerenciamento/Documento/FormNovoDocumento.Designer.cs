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
            this.panelDocumento = new System.Windows.Forms.Panel();
            this.chbPagamentoTaxa = new System.Windows.Forms.CheckBox();
            this.btnAdicionarCampo = new System.Windows.Forms.Button();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNomeDoc = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNomeDoc = new System.Windows.Forms.TextBox();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.panelDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDocumento
            // 
            this.panelDocumento.Controls.Add(this.chbPagamentoTaxa);
            this.panelDocumento.Controls.Add(this.btnAdicionarCampo);
            this.panelDocumento.Controls.Add(this.panelDivisor);
            this.panelDocumento.Controls.Add(this.lblTitulo);
            this.panelDocumento.Controls.Add(this.btnAdicionar);
            this.panelDocumento.Controls.Add(this.lblNomeDoc);
            this.panelDocumento.Controls.Add(this.txtDescricao);
            this.panelDocumento.Controls.Add(this.lblDescricao);
            this.panelDocumento.Controls.Add(this.txtNomeDoc);
            this.panelDocumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDocumento.Location = new System.Drawing.Point(0, 0);
            this.panelDocumento.Name = "panelDocumento";
            this.panelDocumento.Size = new System.Drawing.Size(594, 300);
            this.panelDocumento.TabIndex = 52;
            // 
            // chbPagamentoTaxa
            // 
            this.chbPagamentoTaxa.AutoSize = true;
            this.chbPagamentoTaxa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentoTaxa.Location = new System.Drawing.Point(23, 172);
            this.chbPagamentoTaxa.Name = "chbPagamentoTaxa";
            this.chbPagamentoTaxa.Size = new System.Drawing.Size(444, 22);
            this.chbPagamentoTaxa.TabIndex = 60;
            this.chbPagamentoTaxa.Text = "Necessário pagamento de taxa em caso de segunda via";
            this.chbPagamentoTaxa.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCampo
            // 
            this.btnAdicionarCampo.Location = new System.Drawing.Point(405, 252);
            this.btnAdicionarCampo.Name = "btnAdicionarCampo";
            this.btnAdicionarCampo.Size = new System.Drawing.Size(166, 29);
            this.btnAdicionarCampo.TabIndex = 59;
            this.btnAdicionarCampo.Text = "Campo Extra";
            this.btnAdicionarCampo.UseVisualStyleBackColor = true;
            // 
            // panelDivisor
            // 
            this.panelDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor.Location = new System.Drawing.Point(16, 48);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(300, 1);
            this.panelDivisor.TabIndex = 57;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(14, 22);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 23);
            this.lblTitulo.TabIndex = 52;
            this.lblTitulo.Text = "Adicionar Novo Documento";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(405, 217);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(166, 29);
            this.btnAdicionar.TabIndex = 58;
            this.btnAdicionar.Text = "Adicionar Documento";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // lblNomeDoc
            // 
            this.lblNomeDoc.AutoSize = true;
            this.lblNomeDoc.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeDoc.Location = new System.Drawing.Point(20, 89);
            this.lblNomeDoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomeDoc.Name = "lblNomeDoc";
            this.lblNomeDoc.Size = new System.Drawing.Size(176, 18);
            this.lblNomeDoc.TabIndex = 54;
            this.lblNomeDoc.Text = "Nome do Documento:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(201, 133);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(234, 23);
            this.txtDescricao.TabIndex = 56;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblDescricao.Location = new System.Drawing.Point(18, 133);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(180, 18);
            this.lblDescricao.TabIndex = 53;
            this.lblDescricao.Text = "Prazo de atendimento:";
            // 
            // txtNomeDoc
            // 
            this.txtNomeDoc.BackColor = System.Drawing.Color.White;
            this.txtNomeDoc.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNomeDoc.Location = new System.Drawing.Point(201, 89);
            this.txtNomeDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeDoc.Name = "txtNomeDoc";
            this.txtNomeDoc.Size = new System.Drawing.Size(354, 23);
            this.txtNomeDoc.TabIndex = 55;
            // 
            // panelCampos
            // 
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampos.Location = new System.Drawing.Point(0, 300);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(594, 238);
            this.panelCampos.TabIndex = 53;
            // 
            // FormNovoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(594, 296);
            this.Controls.Add(this.panelCampos);
            this.Controls.Add(this.panelDocumento);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNovoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Documento";
            this.panelDocumento.ResumeLayout(false);
            this.panelDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDocumento;
        private System.Windows.Forms.Button btnAdicionarCampo;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNomeDoc;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNomeDoc;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.CheckBox chbPagamentoTaxa;
    }
}
