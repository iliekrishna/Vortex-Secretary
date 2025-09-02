namespace Secretary.Forms
{
    partial class FormEditarDocumento
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
            this.SuspendLayout();
            // 
            // txtNomeRequerimento
            // 
            this.txtNomeRequerimento.Location = new System.Drawing.Point(207, 88);
            this.txtNomeRequerimento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeRequerimento.Name = "txtNomeRequerimento";
            this.txtNomeRequerimento.Size = new System.Drawing.Size(343, 23);
            this.txtNomeRequerimento.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(449, 222);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 28);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(207, 128);
            this.txtPrazo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(149, 23);
            this.txtPrazo.TabIndex = 5;
            // 
            // lblNomeRequerimento
            // 
            this.lblNomeRequerimento.AutoSize = true;
            this.lblNomeRequerimento.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeRequerimento.Location = new System.Drawing.Point(26, 88);
            this.lblNomeRequerimento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomeRequerimento.Name = "lblNomeRequerimento";
            this.lblNomeRequerimento.Size = new System.Drawing.Size(174, 18);
            this.lblNomeRequerimento.TabIndex = 6;
            this.lblNomeRequerimento.Text = "Nome do documento:";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblPrazo.Location = new System.Drawing.Point(143, 129);
            this.lblPrazo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(58, 18);
            this.lblPrazo.TabIndex = 7;
            this.lblPrazo.Text = "Prazo:";
            // 
            // lblNumID
            // 
            this.lblNumID.AutoSize = true;
            this.lblNumID.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNumID.Location = new System.Drawing.Point(138, 174);
            this.lblNumID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.rbtnAtivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnAtivo.Name = "rbtnAtivo";
            this.rbtnAtivo.Size = new System.Drawing.Size(59, 20);
            this.rbtnAtivo.TabIndex = 9;
            this.rbtnAtivo.TabStop = true;
            this.rbtnAtivo.Text = "Ativo";
            this.rbtnAtivo.UseVisualStyleBackColor = true;
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Location = new System.Drawing.Point(282, 175);
            this.rbtnInativo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(71, 20);
            this.rbtnInativo.TabIndex = 10;
            this.rbtnInativo.Text = "Inativo";
            this.rbtnInativo.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(26, 32);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 23);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Editar Documento";
            // 
            // panelDivisor
            // 
            this.panelDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDivisor.Location = new System.Drawing.Point(30, 58);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(200, 1);
            this.panelDivisor.TabIndex = 32;
            // 
            // FormEditarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(610, 279);
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
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormEditarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição";
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
    }
}