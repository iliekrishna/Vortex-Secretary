namespace Secretary.Forms
{
    partial class FormEditarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarDocumento));
            this.txtNomeRequerimento = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.lblNomeRequerimento = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.lblNumID = new System.Windows.Forms.Label();
            this.rbtnAtivo = new System.Windows.Forms.RadioButton();
            this.rbtnInativo = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.lblNecessitaImg = new System.Windows.Forms.Label();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.panelCampoImagem = new System.Windows.Forms.Panel();
            this.chkObrigatorio = new System.Windows.Forms.CheckBox();
            this.txtNomeCampo = new System.Windows.Forms.TextBox();
            this.lblNomeCampo = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.panelDocumentoImagem = new System.Windows.Forms.Panel();
            this.panelCampoImagem.SuspendLayout();
            this.panelDocumentoImagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeRequerimento
            // 
            this.txtNomeRequerimento.Location = new System.Drawing.Point(207, 88);
            this.txtNomeRequerimento.Name = "txtNomeRequerimento";
            this.txtNomeRequerimento.Size = new System.Drawing.Size(343, 23);
            this.txtNomeRequerimento.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(449, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 28);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(207, 128);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(149, 23);
            this.txtPrazo.TabIndex = 11;
            // 
            // lblNomeRequerimento
            // 
            this.lblNomeRequerimento.AutoSize = true;
            this.lblNomeRequerimento.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeRequerimento.Location = new System.Drawing.Point(26, 88);
            this.lblNomeRequerimento.Name = "lblNomeRequerimento";
            this.lblNomeRequerimento.Size = new System.Drawing.Size(174, 18);
            this.lblNomeRequerimento.TabIndex = 10;
            this.lblNomeRequerimento.Text = "Nome do documento:";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblPrazo.Location = new System.Drawing.Point(143, 129);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(58, 18);
            this.lblPrazo.TabIndex = 9;
            this.lblPrazo.Text = "Prazo:";
            // 
            // lblNumID
            // 
            this.lblNumID.AutoSize = true;
            this.lblNumID.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNumID.Location = new System.Drawing.Point(138, 174);
            this.lblNumID.Name = "lblNumID";
            this.lblNumID.Size = new System.Drawing.Size(63, 18);
            this.lblNumID.TabIndex = 8;
            this.lblNumID.Text = "Status:";
            // 
            // rbtnAtivo
            // 
            this.rbtnAtivo.AutoSize = true;
            this.rbtnAtivo.Checked = true;
            this.rbtnAtivo.Location = new System.Drawing.Point(212, 175);
            this.rbtnAtivo.Name = "rbtnAtivo";
            this.rbtnAtivo.Size = new System.Drawing.Size(59, 20);
            this.rbtnAtivo.TabIndex = 7;
            this.rbtnAtivo.TabStop = true;
            this.rbtnAtivo.Text = "Ativo";
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Location = new System.Drawing.Point(282, 175);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(71, 20);
            this.rbtnInativo.TabIndex = 6;
            this.rbtnInativo.Text = "Inativo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(26, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 23);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Editar Documento";
            // 
            // panelDivisor
            // 
            this.panelDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor.Location = new System.Drawing.Point(30, 58);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(200, 1);
            this.panelDivisor.TabIndex = 4;
            // 
            // lblNecessitaImg
            // 
            this.lblNecessitaImg.AutoSize = true;
            this.lblNecessitaImg.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNecessitaImg.Location = new System.Drawing.Point(15, 19);
            this.lblNecessitaImg.Name = "lblNecessitaImg";
            this.lblNecessitaImg.Size = new System.Drawing.Size(239, 18);
            this.lblNecessitaImg.TabIndex = 3;
            this.lblNecessitaImg.Text = "Este documento exige imagem";
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Checked = true;
            this.rdbNao.Location = new System.Drawing.Point(261, 19);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(50, 20);
            this.rdbNao.TabIndex = 1;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(317, 19);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(48, 20);
            this.rdbSim.TabIndex = 2;
            this.rdbSim.Text = "Sim";
            // 
            // panelCampoImagem
            // 
            this.panelCampoImagem.Controls.Add(this.chkObrigatorio);
            this.panelCampoImagem.Controls.Add(this.txtNomeCampo);
            this.panelCampoImagem.Controls.Add(this.lblNomeCampo);
            this.panelCampoImagem.Controls.Add(this.lblTitulo2);
            this.panelCampoImagem.Location = new System.Drawing.Point(12, 255);
            this.panelCampoImagem.Name = "panelCampoImagem";
            this.panelCampoImagem.Size = new System.Drawing.Size(571, 113);
            this.panelCampoImagem.TabIndex = 0;
            this.panelCampoImagem.Visible = false;
            // 
            // chkObrigatorio
            // 
            this.chkObrigatorio.AutoSize = true;
            this.chkObrigatorio.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.chkObrigatorio.Location = new System.Drawing.Point(18, 89);
            this.chkObrigatorio.Name = "chkObrigatorio";
            this.chkObrigatorio.Size = new System.Drawing.Size(203, 20);
            this.chkObrigatorio.TabIndex = 0;
            this.chkObrigatorio.Text = "Obrigatório na segunda via";
            // 
            // txtNomeCampo
            // 
            this.txtNomeCampo.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNomeCampo.Location = new System.Drawing.Point(248, 53);
            this.txtNomeCampo.Name = "txtNomeCampo";
            this.txtNomeCampo.Size = new System.Drawing.Size(302, 23);
            this.txtNomeCampo.TabIndex = 1;
            // 
            // lblNomeCampo
            // 
            this.lblNomeCampo.AutoSize = true;
            this.lblNomeCampo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeCampo.Location = new System.Drawing.Point(15, 53);
            this.lblNomeCampo.Name = "lblNomeCampo";
            this.lblNomeCampo.Size = new System.Drawing.Size(228, 18);
            this.lblNomeCampo.TabIndex = 2;
            this.lblNomeCampo.Text = "Nome do campo de imagem:";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo2.Location = new System.Drawing.Point(13, 14);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(195, 18);
            this.lblTitulo2.TabIndex = 3;
            this.lblTitulo2.Text = "Documento com anexo";
            // 
            // panelDocumentoImagem
            // 
            this.panelDocumentoImagem.Controls.Add(this.rdbSim);
            this.panelDocumentoImagem.Controls.Add(this.lblNecessitaImg);
            this.panelDocumentoImagem.Controls.Add(this.rdbNao);
            this.panelDocumentoImagem.Location = new System.Drawing.Point(12, 198);
            this.panelDocumentoImagem.Name = "panelDocumentoImagem";
            this.panelDocumentoImagem.Size = new System.Drawing.Size(399, 57);
            this.panelDocumentoImagem.TabIndex = 14;
            // 
            // FormEditarDocumento
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(595, 254);
            this.Controls.Add(this.panelDocumentoImagem);
            this.Controls.Add(this.panelCampoImagem);
            this.Controls.Add(this.panelDivisor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbtnInativo);
            this.Controls.Add(this.rbtnAtivo);
            this.Controls.Add(this.lblNumID);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblNomeRequerimento);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeRequerimento);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição";
            this.Load += new System.EventHandler(this.FormEditarDocumento_Load);
            this.panelCampoImagem.ResumeLayout(false);
            this.panelCampoImagem.PerformLayout();
            this.panelDocumentoImagem.ResumeLayout(false);
            this.panelDocumentoImagem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeRequerimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.Label lblNomeRequerimento;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label lblNumID;
        private System.Windows.Forms.RadioButton rbtnAtivo;
        private System.Windows.Forms.RadioButton rbtnInativo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelDivisor;

        // NOVOS CAMPOS
        private System.Windows.Forms.Label lblNecessitaImg;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.Panel panelCampoImagem;
        private System.Windows.Forms.CheckBox chkObrigatorio;
        private System.Windows.Forms.TextBox txtNomeCampo;
        private System.Windows.Forms.Label lblNomeCampo;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel panelDocumentoImagem;
    }
}
