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
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSoliAtendidas = new System.Windows.Forms.TextBox();
            this.lblSoliAtendidas = new System.Windows.Forms.Label();
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
            // txtSoliAtendidas
            // 
            this.txtSoliAtendidas.Location = new System.Drawing.Point(436, 175);
            this.txtSoliAtendidas.Name = "txtSoliAtendidas";
            this.txtSoliAtendidas.ReadOnly = true;
            this.txtSoliAtendidas.Size = new System.Drawing.Size(113, 23);
            this.txtSoliAtendidas.TabIndex = 22;
            // 
            // lblSoliAtendidas
            // 
            this.lblSoliAtendidas.AutoSize = true;
            this.lblSoliAtendidas.Location = new System.Drawing.Point(267, 177);
            this.lblSoliAtendidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoliAtendidas.Name = "lblSoliAtendidas";
            this.lblSoliAtendidas.Size = new System.Drawing.Size(161, 16);
            this.lblSoliAtendidas.TabIndex = 21;
            this.lblSoliAtendidas.Text = "Solicitações atendidas:";
            // 
            // FormPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 258);
            this.Controls.Add(this.txtSoliAtendidas);
            this.Controls.Add(this.lblSoliAtendidas);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.txtNomeUsuario);
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
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtSoliAtendidas;
        private System.Windows.Forms.Label lblSoliAtendidas;
    }
}