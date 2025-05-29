namespace Secretary.Forms
{
    partial class FormEditarRequerimento
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
            this.btnSalvar.Location = new System.Drawing.Point(353, 140);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluirRequerimento
            // 
            this.btnExcluirRequerimento.Location = new System.Drawing.Point(206, 140);
            this.btnExcluirRequerimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluirRequerimento.Name = "btnExcluirRequerimento";
            this.btnExcluirRequerimento.Size = new System.Drawing.Size(139, 23);
            this.btnExcluirRequerimento.TabIndex = 3;
            this.btnExcluirRequerimento.Text = "Apagar requerimento";
            this.btnExcluirRequerimento.UseVisualStyleBackColor = true;
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
            // FormEditarRequerimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 228);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblNomeRequerimento);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.btnExcluirRequerimento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeRequerimento);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormEditarRequerimento";
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
    }
}