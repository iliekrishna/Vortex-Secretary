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
            this.panelCampoImagem = new System.Windows.Forms.Panel();
            this.chkObrigatorio = new System.Windows.Forms.CheckBox();
            this.txtNomeCampo = new System.Windows.Forms.TextBox();
            this.lblNomeCampo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.lblNecessitaImg = new System.Windows.Forms.Label();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNomeDoc = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNomeDoc = new System.Windows.Forms.TextBox();
            this.panelCampoImagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCampoImagem
            // 
            this.panelCampoImagem.Controls.Add(this.chkObrigatorio);
            this.panelCampoImagem.Controls.Add(this.txtNomeCampo);
            this.panelCampoImagem.Controls.Add(this.lblNomeCampo);
            this.panelCampoImagem.Controls.Add(this.lblTitulo2);
            this.panelCampoImagem.Location = new System.Drawing.Point(12, 235);
            this.panelCampoImagem.Name = "panelCampoImagem";
            this.panelCampoImagem.Size = new System.Drawing.Size(571, 157);
            this.panelCampoImagem.TabIndex = 34;
            this.panelCampoImagem.Visible = false;
            // 
            // chkObrigatorio
            // 
            this.chkObrigatorio.AutoSize = true;
            this.chkObrigatorio.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.chkObrigatorio.Location = new System.Drawing.Point(21, 112);
            this.chkObrigatorio.Name = "chkObrigatorio";
            this.chkObrigatorio.Size = new System.Drawing.Size(224, 20);
            this.chkObrigatorio.TabIndex = 46;
            this.chkObrigatorio.Text = "Obrigatório somente na 2ª via";
            this.chkObrigatorio.UseVisualStyleBackColor = true;
            // 
            // txtNomeCampo
            // 
            this.txtNomeCampo.BackColor = System.Drawing.Color.White;
            this.txtNomeCampo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNomeCampo.Location = new System.Drawing.Point(248, 66);
            this.txtNomeCampo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeCampo.Name = "txtNomeCampo";
            this.txtNomeCampo.Size = new System.Drawing.Size(302, 23);
            this.txtNomeCampo.TabIndex = 44;
            // 
            // lblNomeCampo
            // 
            this.lblNomeCampo.AutoSize = true;
            this.lblNomeCampo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeCampo.Location = new System.Drawing.Point(15, 66);
            this.lblNomeCampo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomeCampo.Name = "lblNomeCampo";
            this.lblNomeCampo.Size = new System.Drawing.Size(228, 18);
            this.lblNomeCampo.TabIndex = 45;
            this.lblNomeCampo.Text = "Nome do campo de imagem:";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo2.Location = new System.Drawing.Point(13, 14);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(195, 18);
            this.lblTitulo2.TabIndex = 44;
            this.lblTitulo2.Text = "Documento com anexo";
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Checked = true;
            this.rdbNao.Location = new System.Drawing.Point(274, 188);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(50, 20);
            this.rdbNao.TabIndex = 53;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(330, 188);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(48, 20);
            this.rdbSim.TabIndex = 52;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // lblNecessitaImg
            // 
            this.lblNecessitaImg.AutoSize = true;
            this.lblNecessitaImg.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNecessitaImg.Location = new System.Drawing.Point(27, 188);
            this.lblNecessitaImg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNecessitaImg.Name = "lblNecessitaImg";
            this.lblNecessitaImg.Size = new System.Drawing.Size(239, 18);
            this.lblNecessitaImg.TabIndex = 51;
            this.lblNecessitaImg.Text = "Este documento exige imagem";
            // 
            // panelDivisor
            // 
            this.panelDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor.Location = new System.Drawing.Point(23, 42);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(300, 1);
            this.panelDivisor.TabIndex = 49;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(21, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 23);
            this.lblTitulo.TabIndex = 44;
            this.lblTitulo.Text = "Adicionar Novo Documento";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(396, 225);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(166, 29);
            this.btnAdicionar.TabIndex = 50;
            this.btnAdicionar.Text = "Adicionar Documento";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // lblNomeDoc
            // 
            this.lblNomeDoc.AutoSize = true;
            this.lblNomeDoc.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeDoc.Location = new System.Drawing.Point(27, 83);
            this.lblNomeDoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomeDoc.Name = "lblNomeDoc";
            this.lblNomeDoc.Size = new System.Drawing.Size(176, 18);
            this.lblNomeDoc.TabIndex = 46;
            this.lblNomeDoc.Text = "Nome do Documento:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(208, 127);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(140, 23);
            this.txtDescricao.TabIndex = 48;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblDescricao.Location = new System.Drawing.Point(25, 127);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(180, 18);
            this.lblDescricao.TabIndex = 45;
            this.lblDescricao.Text = "Prazo de atendimento:";
            // 
            // txtNomeDoc
            // 
            this.txtNomeDoc.BackColor = System.Drawing.Color.White;
            this.txtNomeDoc.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNomeDoc.Location = new System.Drawing.Point(208, 83);
            this.txtNomeDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeDoc.Name = "txtNomeDoc";
            this.txtNomeDoc.Size = new System.Drawing.Size(354, 23);
            this.txtNomeDoc.TabIndex = 47;
            // 
            // FormNovoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(594, 267);
            this.Controls.Add(this.rdbNao);
            this.Controls.Add(this.rdbSim);
            this.Controls.Add(this.lblNecessitaImg);
            this.Controls.Add(this.panelDivisor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblNomeDoc);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNomeDoc);
            this.Controls.Add(this.panelCampoImagem);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNovoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Documento";
            this.panelCampoImagem.ResumeLayout(false);
            this.panelCampoImagem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCampoImagem;
        private System.Windows.Forms.CheckBox chkObrigatorio;
        private System.Windows.Forms.TextBox txtNomeCampo;
        private System.Windows.Forms.Label lblNomeCampo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.Label lblNecessitaImg;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNomeDoc;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNomeDoc;
    }
}
