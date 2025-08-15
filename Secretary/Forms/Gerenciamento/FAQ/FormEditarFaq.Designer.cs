namespace Secretary.Forms.Gerenciamento
{
    partial class FormEditarFaq
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtResposta;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPergunta = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDataEUsuario = new System.Windows.Forms.Label();
            this.lblCriadoPor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(12, 76);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(70, 14);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "Pergunta:";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(12, 96);
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(586, 60);
            this.txtPergunta.TabIndex = 1;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(12, 167);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(71, 14);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.Text = "Resposta:";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(12, 187);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResposta.Size = new System.Drawing.Size(586, 263);
            this.txtResposta.TabIndex = 3;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.Location = new System.Drawing.Point(471, 465);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 28);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir FAQ";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(355, 465);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 28);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // lblDataEUsuario
            // 
            this.lblDataEUsuario.AutoSize = true;
            this.lblDataEUsuario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEUsuario.Location = new System.Drawing.Point(21, 510);
            this.lblDataEUsuario.Name = "lblDataEUsuario";
            this.lblDataEUsuario.Size = new System.Drawing.Size(0, 14);
            this.lblDataEUsuario.TabIndex = 12;
            // 
            // lblCriadoPor
            // 
            this.lblCriadoPor.AutoSize = true;
            this.lblCriadoPor.Location = new System.Drawing.Point(17, 477);
            this.lblCriadoPor.Name = "lblCriadoPor";
            this.lblCriadoPor.Size = new System.Drawing.Size(11, 14);
            this.lblCriadoPor.TabIndex = 13;
            this.lblCriadoPor.Text = " ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 16);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 14);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 27);
            this.textBox1.TabIndex = 15;
            // 
            // FormEditarFaq
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(610, 545);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCriadoPor);
            this.Controls.Add(this.lblDataEUsuario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtResposta);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormEditarFaq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar FAQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDataEUsuario;
        private System.Windows.Forms.Label lblCriadoPor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox textBox1;
    }
}
