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
            this.panelDados = new System.Windows.Forms.Panel();
            this.chbPagamentoTaxa = new System.Windows.Forms.CheckBox();
            this.btnAdicionarCampo = new System.Windows.Forms.Button();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtnInativo = new System.Windows.Forms.RadioButton();
            this.rbtnAtivo = new System.Windows.Forms.RadioButton();
            this.lblNumID = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.lblNomeRequerimento = new System.Windows.Forms.Label();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeRequerimento = new System.Windows.Forms.TextBox();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.panelDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.chbPagamentoTaxa);
            this.panelDados.Controls.Add(this.btnAdicionarCampo);
            this.panelDados.Controls.Add(this.panelDivisor);
            this.panelDados.Controls.Add(this.lblTitulo);
            this.panelDados.Controls.Add(this.rbtnInativo);
            this.panelDados.Controls.Add(this.rbtnAtivo);
            this.panelDados.Controls.Add(this.lblNumID);
            this.panelDados.Controls.Add(this.lblPrazo);
            this.panelDados.Controls.Add(this.lblNomeRequerimento);
            this.panelDados.Controls.Add(this.txtPrazo);
            this.panelDados.Controls.Add(this.btnSalvar);
            this.panelDados.Controls.Add(this.txtNomeRequerimento);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDados.Location = new System.Drawing.Point(0, 0);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(595, 340);
            this.panelDados.TabIndex = 63;
            // 
            // chbPagamentoTaxa
            // 
            this.chbPagamentoTaxa.AutoSize = true;
            this.chbPagamentoTaxa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentoTaxa.Location = new System.Drawing.Point(20, 205);
            this.chbPagamentoTaxa.Name = "chbPagamentoTaxa";
            this.chbPagamentoTaxa.Size = new System.Drawing.Size(444, 22);
            this.chbPagamentoTaxa.TabIndex = 74;
            this.chbPagamentoTaxa.Text = "Necessário pagamento de taxa em caso de segunda via";
            this.chbPagamentoTaxa.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCampo
            // 
            this.btnAdicionarCampo.Location = new System.Drawing.Point(401, 256);
            this.btnAdicionarCampo.Name = "btnAdicionarCampo";
            this.btnAdicionarCampo.Size = new System.Drawing.Size(166, 29);
            this.btnAdicionarCampo.TabIndex = 73;
            this.btnAdicionarCampo.Text = "Campo Extra";
            this.btnAdicionarCampo.UseVisualStyleBackColor = true;
            this.btnAdicionarCampo.Click += new System.EventHandler(this.btnAdicionarCampo_Click_1);
            // 
            // panelDivisor
            // 
            this.panelDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor.Location = new System.Drawing.Point(24, 51);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(200, 1);
            this.panelDivisor.TabIndex = 63;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 23);
            this.lblTitulo.TabIndex = 64;
            this.lblTitulo.Text = "Editar Documento";
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Location = new System.Drawing.Point(276, 168);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(71, 20);
            this.rbtnInativo.TabIndex = 65;
            this.rbtnInativo.Text = "Inativo";
            // 
            // rbtnAtivo
            // 
            this.rbtnAtivo.AutoSize = true;
            this.rbtnAtivo.Checked = true;
            this.rbtnAtivo.Location = new System.Drawing.Point(206, 168);
            this.rbtnAtivo.Name = "rbtnAtivo";
            this.rbtnAtivo.Size = new System.Drawing.Size(59, 20);
            this.rbtnAtivo.TabIndex = 66;
            this.rbtnAtivo.TabStop = true;
            this.rbtnAtivo.Text = "Ativo";
            // 
            // lblNumID
            // 
            this.lblNumID.AutoSize = true;
            this.lblNumID.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNumID.Location = new System.Drawing.Point(132, 167);
            this.lblNumID.Name = "lblNumID";
            this.lblNumID.Size = new System.Drawing.Size(63, 18);
            this.lblNumID.TabIndex = 67;
            this.lblNumID.Text = "Status:";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblPrazo.Location = new System.Drawing.Point(137, 122);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(58, 18);
            this.lblPrazo.TabIndex = 68;
            this.lblPrazo.Text = "Prazo:";
            // 
            // lblNomeRequerimento
            // 
            this.lblNomeRequerimento.AutoSize = true;
            this.lblNomeRequerimento.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeRequerimento.Location = new System.Drawing.Point(20, 81);
            this.lblNomeRequerimento.Name = "lblNomeRequerimento";
            this.lblNomeRequerimento.Size = new System.Drawing.Size(174, 18);
            this.lblNomeRequerimento.TabIndex = 69;
            this.lblNomeRequerimento.Text = "Nome do documento:";
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(201, 121);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(149, 23);
            this.txtPrazo.TabIndex = 70;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(401, 291);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(166, 28);
            this.btnSalvar.TabIndex = 71;
            this.btnSalvar.Text = "Salvar Alteração";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // txtNomeRequerimento
            // 
            this.txtNomeRequerimento.Location = new System.Drawing.Point(201, 81);
            this.txtNomeRequerimento.Name = "txtNomeRequerimento";
            this.txtNomeRequerimento.Size = new System.Drawing.Size(343, 23);
            this.txtNomeRequerimento.TabIndex = 72;
            // 
            // panelCampos
            // 
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampos.Location = new System.Drawing.Point(0, 340);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(595, 271);
            this.panelCampos.TabIndex = 64;
            // 
            // FormEditarDocumento
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(595, 339);
            this.Controls.Add(this.panelCampos);
            this.Controls.Add(this.panelDados);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição";
            this.Load += new System.EventHandler(this.FormEditarDocumento_Load);
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.CheckBox chbPagamentoTaxa;
        private System.Windows.Forms.Button btnAdicionarCampo;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtnInativo;
        private System.Windows.Forms.RadioButton rbtnAtivo;
        private System.Windows.Forms.Label lblNumID;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label lblNomeRequerimento;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeRequerimento;
        private System.Windows.Forms.Panel panelCampos;
    }
}
