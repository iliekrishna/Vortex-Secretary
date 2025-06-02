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
            this.lbl = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarSair = new System.Windows.Forms.Button();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.linklblAlterarFoto = new System.Windows.Forms.LinkLabel();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblSenhaNova = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboxExibirSenhaAtual = new System.Windows.Forms.CheckBox();
            this.cboxExibirNovaSenha = new System.Windows.Forms.CheckBox();
            this.cboxExibirConfirmarSenha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(256, 69);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(182, 18);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Detalhes do usuário";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // btnSalvarSair
            // 
            this.btnSalvarSair.Location = new System.Drawing.Point(503, 335);
            this.btnSalvarSair.Name = "btnSalvarSair";
            this.btnSalvarSair.Size = new System.Drawing.Size(110, 23);
            this.btnSalvarSair.TabIndex = 21;
            this.btnSalvarSair.Text = "Salvar e sair";
            this.btnSalvarSair.UseVisualStyleBackColor = true;
            this.btnSalvarSair.Click += new System.EventHandler(this.btnSalvarSair_Click);
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(323, 136);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(360, 23);
            this.txtLoginUsuario.TabIndex = 20;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(323, 105);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(276, 23);
            this.txtNomeUsuario.TabIndex = 19;
            // 
            // linklblAlterarFoto
            // 
            this.linklblAlterarFoto.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblAlterarFoto.AutoSize = true;
            this.linklblAlterarFoto.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linklblAlterarFoto.Location = new System.Drawing.Point(67, 201);
            this.linklblAlterarFoto.Name = "linklblAlterarFoto";
            this.linklblAlterarFoto.Size = new System.Drawing.Size(141, 16);
            this.linklblAlterarFoto.TabIndex = 18;
            this.linklblAlterarFoto.TabStop = true;
            this.linklblAlterarFoto.Text = "Alterar foto de perfil";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(369, 265);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(244, 23);
            this.txtNovaSenha.TabIndex = 26;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(369, 234);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(244, 23);
            this.txtSenhaAtual.TabIndex = 25;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // lblSenhaNova
            // 
            this.lblSenhaNova.AutoSize = true;
            this.lblSenhaNova.Location = new System.Drawing.Point(267, 268);
            this.lblSenhaNova.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaNova.Name = "lblSenhaNova";
            this.lblSenhaNova.Size = new System.Drawing.Size(90, 16);
            this.lblSenhaNova.TabIndex = 24;
            this.lblSenhaNova.Text = "Nova senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Senha atual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Alterar Senha";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(369, 294);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(244, 23);
            this.txtConfirmarSenha.TabIndex = 28;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(240, 297);
            this.lblConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(119, 16);
            this.lblConfirmarSenha.TabIndex = 27;
            this.lblConfirmarSenha.Text = "Confirmar senha:";
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
            // cboxExibirSenhaAtual
            // 
            this.cboxExibirSenhaAtual.AutoSize = true;
            this.cboxExibirSenhaAtual.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxExibirSenhaAtual.ForeColor = System.Drawing.Color.Black;
            this.cboxExibirSenhaAtual.Location = new System.Drawing.Point(619, 237);
            this.cboxExibirSenhaAtual.Name = "cboxExibirSenhaAtual";
            this.cboxExibirSenhaAtual.Size = new System.Drawing.Size(60, 18);
            this.cboxExibirSenhaAtual.TabIndex = 29;
            this.cboxExibirSenhaAtual.Text = "Exibir";
            this.cboxExibirSenhaAtual.UseVisualStyleBackColor = true;
            this.cboxExibirSenhaAtual.CheckedChanged += new System.EventHandler(this.cboxExibirSenhaAtual_CheckedChanged);
            // 
            // cboxExibirNovaSenha
            // 
            this.cboxExibirNovaSenha.AutoSize = true;
            this.cboxExibirNovaSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxExibirNovaSenha.ForeColor = System.Drawing.Color.Black;
            this.cboxExibirNovaSenha.Location = new System.Drawing.Point(619, 267);
            this.cboxExibirNovaSenha.Name = "cboxExibirNovaSenha";
            this.cboxExibirNovaSenha.Size = new System.Drawing.Size(60, 18);
            this.cboxExibirNovaSenha.TabIndex = 30;
            this.cboxExibirNovaSenha.Text = "Exibir";
            this.cboxExibirNovaSenha.UseVisualStyleBackColor = true;
            this.cboxExibirNovaSenha.CheckedChanged += new System.EventHandler(this.cboxExibirNovaSenha_CheckedChanged);
            // 
            // cboxExibirConfirmarSenha
            // 
            this.cboxExibirConfirmarSenha.AutoSize = true;
            this.cboxExibirConfirmarSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxExibirConfirmarSenha.ForeColor = System.Drawing.Color.Black;
            this.cboxExibirConfirmarSenha.Location = new System.Drawing.Point(619, 297);
            this.cboxExibirConfirmarSenha.Name = "cboxExibirConfirmarSenha";
            this.cboxExibirConfirmarSenha.Size = new System.Drawing.Size(60, 18);
            this.cboxExibirConfirmarSenha.TabIndex = 31;
            this.cboxExibirConfirmarSenha.Text = "Exibir";
            this.cboxExibirConfirmarSenha.UseVisualStyleBackColor = true;
            this.cboxExibirConfirmarSenha.CheckedChanged += new System.EventHandler(this.cboxExibirConfirmarSenha_CheckedChanged);
            // 
            // FormPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 474);
            this.Controls.Add(this.cboxExibirConfirmarSenha);
            this.Controls.Add(this.cboxExibirNovaSenha);
            this.Controls.Add(this.cboxExibirSenhaAtual);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.lblSenhaNova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvarSair);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.linklblAlterarFoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPerfilUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil do Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarSair;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.LinkLabel linklblAlterarFoto;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label lblSenhaNova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.CheckBox cboxExibirSenhaAtual;
        private System.Windows.Forms.CheckBox cboxExibirNovaSenha;
        private System.Windows.Forms.CheckBox cboxExibirConfirmarSenha;
    }
}