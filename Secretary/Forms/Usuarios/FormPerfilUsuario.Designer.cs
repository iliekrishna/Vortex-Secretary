namespace Secretary.Forms
{
    partial class FormPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfilUsuario));
            this.lblDetalhesUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtReqAtendidos = new System.Windows.Forms.TextBox();
            this.lblReqAtendidos = new System.Windows.Forms.Label();
            this.txtTicketsAtendidos = new System.Windows.Forms.TextBox();
            this.lblTicketsAtendidos = new System.Windows.Forms.Label();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtCriadoEm = new System.Windows.Forms.TextBox();
            this.lblCriadoEm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetalhesUsuario
            // 
            this.lblDetalhesUsuario.AutoSize = true;
            this.lblDetalhesUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhesUsuario.Location = new System.Drawing.Point(256, 69);
            this.lblDetalhesUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalhesUsuario.Name = "lblDetalhesUsuario";
            this.lblDetalhesUsuario.Size = new System.Drawing.Size(182, 18);
            this.lblDetalhesUsuario.TabIndex = 2;
            this.lblDetalhesUsuario.Text = "Detalhes do usuário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(267, 105);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(267, 136);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 16);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login:";
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(323, 136);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.ReadOnly = true;
            this.txtLoginUsuario.Size = new System.Drawing.Size(360, 23);
            this.txtLoginUsuario.TabIndex = 20;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(323, 105);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.ReadOnly = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(276, 23);
            this.txtNomeUsuario.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::Secretary.Properties.Resources.iconeUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(65, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 134);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtReqAtendidos
            // 
            this.txtReqAtendidos.Location = new System.Drawing.Point(446, 259);
            this.txtReqAtendidos.Name = "txtReqAtendidos";
            this.txtReqAtendidos.ReadOnly = true;
            this.txtReqAtendidos.Size = new System.Drawing.Size(113, 23);
            this.txtReqAtendidos.TabIndex = 22;
            // 
            // lblReqAtendidos
            // 
            this.lblReqAtendidos.AutoSize = true;
            this.lblReqAtendidos.Location = new System.Drawing.Point(261, 261);
            this.lblReqAtendidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReqAtendidos.Name = "lblReqAtendidos";
            this.lblReqAtendidos.Size = new System.Drawing.Size(178, 16);
            this.lblReqAtendidos.TabIndex = 21;
            this.lblReqAtendidos.Text = "Requerimentos atendidos:";
            // 
            // txtTicketsAtendidos
            // 
            this.txtTicketsAtendidos.Location = new System.Drawing.Point(446, 287);
            this.txtTicketsAtendidos.Name = "txtTicketsAtendidos";
            this.txtTicketsAtendidos.ReadOnly = true;
            this.txtTicketsAtendidos.Size = new System.Drawing.Size(113, 23);
            this.txtTicketsAtendidos.TabIndex = 24;
            // 
            // lblTicketsAtendidos
            // 
            this.lblTicketsAtendidos.AutoSize = true;
            this.lblTicketsAtendidos.Location = new System.Drawing.Point(309, 290);
            this.lblTicketsAtendidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketsAtendidos.Name = "lblTicketsAtendidos";
            this.lblTicketsAtendidos.Size = new System.Drawing.Size(130, 16);
            this.lblTicketsAtendidos.TabIndex = 23;
            this.lblTicketsAtendidos.Text = "Tickets atendidos:";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(323, 173);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.ReadOnly = true;
            this.txtTipoUsuario.Size = new System.Drawing.Size(201, 23);
            this.txtTipoUsuario.TabIndex = 26;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(267, 173);
            this.lblConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(52, 16);
            this.lblConta.TabIndex = 25;
            this.lblConta.Text = "Conta:";
            // 
            // txtCriadoEm
            // 
            this.txtCriadoEm.Location = new System.Drawing.Point(323, 208);
            this.txtCriadoEm.Name = "txtCriadoEm";
            this.txtCriadoEm.ReadOnly = true;
            this.txtCriadoEm.Size = new System.Drawing.Size(201, 23);
            this.txtCriadoEm.TabIndex = 28;
            // 
            // lblCriadoEm
            // 
            this.lblCriadoEm.AutoSize = true;
            this.lblCriadoEm.Location = new System.Drawing.Point(241, 211);
            this.lblCriadoEm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriadoEm.Name = "lblCriadoEm";
            this.lblCriadoEm.Size = new System.Drawing.Size(78, 16);
            this.lblCriadoEm.TabIndex = 27;
            this.lblCriadoEm.Text = "Criado em:";
            // 
            // FormPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 338);
            this.Controls.Add(this.txtCriadoEm);
            this.Controls.Add(this.lblCriadoEm);
            this.Controls.Add(this.txtTipoUsuario);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.txtTicketsAtendidos);
            this.Controls.Add(this.lblTicketsAtendidos);
            this.Controls.Add(this.txtReqAtendidos);
            this.Controls.Add(this.lblReqAtendidos);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDetalhesUsuario);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil do Usuário";
            this.Load += new System.EventHandler(this.FormPerfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDetalhesUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtReqAtendidos;
        private System.Windows.Forms.Label lblReqAtendidos;
        private System.Windows.Forms.TextBox txtTicketsAtendidos;
        private System.Windows.Forms.Label lblTicketsAtendidos;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtCriadoEm;
        private System.Windows.Forms.Label lblCriadoEm;
    }
}