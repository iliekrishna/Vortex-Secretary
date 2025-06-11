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
            this.txtNomeRequerimento = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluirRequerimento = new System.Windows.Forms.Button();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.lblNomeRequerimento = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.lblNumID = new System.Windows.Forms.Label();
            this.rbtnAtivo = new System.Windows.Forms.RadioButton();
            this.rbtnInativo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNomeRequerimento
            // 
            this.txtNomeRequerimento.Location = new System.Drawing.Point(151, 61);
            this.txtNomeRequerimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeRequerimento.Name = "txtNomeRequerimento";
            this.txtNomeRequerimento.Size = new System.Drawing.Size(301, 21);
            this.txtNomeRequerimento.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(364, 166);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluirRequerimento
            // 
            this.btnExcluirRequerimento.Location = new System.Drawing.Point(272, 166);
            this.btnExcluirRequerimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluirRequerimento.Name = "btnExcluirRequerimento";
            this.btnExcluirRequerimento.Size = new System.Drawing.Size(84, 23);
            this.btnExcluirRequerimento.TabIndex = 3;
            this.btnExcluirRequerimento.Text = "Deletar";
            this.btnExcluirRequerimento.UseVisualStyleBackColor = true;
            this.btnExcluirRequerimento.Click += new System.EventHandler(this.btnExcluirRequerimento_Click);
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(151, 98);
            this.txtPrazo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(301, 21);
            this.txtPrazo.TabIndex = 5;
            // 
            // lblNomeRequerimento
            // 
            this.lblNomeRequerimento.AutoSize = true;
            this.lblNomeRequerimento.Location = new System.Drawing.Point(17, 64);
            this.lblNomeRequerimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeRequerimento.Name = "lblNomeRequerimento";
            this.lblNomeRequerimento.Size = new System.Drawing.Size(126, 13);
            this.lblNomeRequerimento.TabIndex = 6;
            this.lblNomeRequerimento.Text = "Nome requerimento:";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Location = new System.Drawing.Point(99, 101);
            this.lblPrazo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(44, 13);
            this.lblPrazo.TabIndex = 7;
            this.lblPrazo.Text = "Prazo:";
            // 
            // lblNumID
            // 
            this.lblNumID.AutoSize = true;
            this.lblNumID.Location = new System.Drawing.Point(95, 132);
            this.lblNumID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumID.Name = "lblNumID";
            this.lblNumID.Size = new System.Drawing.Size(48, 13);
            this.lblNumID.TabIndex = 8;
            this.lblNumID.Text = "Status:";
            // 
            // rbtnAtivo
            // 
            this.rbtnAtivo.AutoSize = true;
            this.rbtnAtivo.Checked = true;
            this.rbtnAtivo.Location = new System.Drawing.Point(155, 132);
            this.rbtnAtivo.Name = "rbtnAtivo";
            this.rbtnAtivo.Size = new System.Drawing.Size(54, 17);
            this.rbtnAtivo.TabIndex = 9;
            this.rbtnAtivo.TabStop = true;
            this.rbtnAtivo.Text = "Ativo";
            this.rbtnAtivo.UseVisualStyleBackColor = true;
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Location = new System.Drawing.Point(217, 132);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(65, 17);
            this.rbtnInativo.TabIndex = 10;
            this.rbtnInativo.Text = "Inativo";
            this.rbtnInativo.UseVisualStyleBackColor = true;
            // 
            // FormEditarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 249);
            this.Controls.Add(this.rbtnInativo);
            this.Controls.Add(this.rbtnAtivo);
            this.Controls.Add(this.lblNumID);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblNomeRequerimento);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.btnExcluirRequerimento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeRequerimento);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormEditarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Requerimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeRequerimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluirRequerimento;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.Label lblNomeRequerimento;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label lblNumID;
        private System.Windows.Forms.RadioButton rbtnAtivo;
        private System.Windows.Forms.RadioButton rbtnInativo;
    }
}