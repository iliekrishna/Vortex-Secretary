namespace Secretary.Forms.Requerimentos
{
    partial class EnviarDocumento
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panelDivisor1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTituloDadosSolicitante = new System.Windows.Forms.Label();
            this.panelDivisor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(26, 66);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(82, 16);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquivo:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(114, 63);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagem.Size = new System.Drawing.Size(680, 243);
            this.txtMensagem.TabIndex = 2;
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(114, 328);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.ReadOnly = true;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(485, 23);
            this.txtCaminhoArquivo.TabIndex = 3;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(49, 362);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(174, 31);
            this.btnSelecionarArquivo.TabIndex = 4;
            this.btnSelecionarArquivo.Text = "Selecionar Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(620, 328);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(174, 29);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar E-mail";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panelDivisor1
            // 
            this.panelDivisor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor1.Controls.Add(this.label3);
            this.panelDivisor1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDivisor1.Location = new System.Drawing.Point(202, 33);
            this.panelDivisor1.Name = "panelDivisor1";
            this.panelDivisor1.Size = new System.Drawing.Size(600, 1);
            this.panelDivisor1.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-94, -9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dados do solicitante";
            // 
            // lblTituloDadosSolicitante
            // 
            this.lblTituloDadosSolicitante.AutoSize = true;
            this.lblTituloDadosSolicitante.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDadosSolicitante.Location = new System.Drawing.Point(13, 22);
            this.lblTituloDadosSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDadosSolicitante.Name = "lblTituloDadosSolicitante";
            this.lblTituloDadosSolicitante.Size = new System.Drawing.Size(187, 18);
            this.lblTituloDadosSolicitante.TabIndex = 66;
            this.lblTituloDadosSolicitante.Text = "Envio de Documento";
            // 
            // EnviarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(832, 415);
            this.Controls.Add(this.panelDivisor1);
            this.Controls.Add(this.lblTituloDadosSolicitante);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensagem);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnviarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnviarDocumento";
            this.Load += new System.EventHandler(this.EnviarDocumento_Load);
            this.panelDivisor1.ResumeLayout(false);
            this.panelDivisor1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panelDivisor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTituloDadosSolicitante;
    }
}