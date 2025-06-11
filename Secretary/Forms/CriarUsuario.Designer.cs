namespace Secretary.Forms
{
    partial class CriarUsuario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(65, 154);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Location = new System.Drawing.Point(140, 154);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(442, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(77, 282);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(50, 18);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Location = new System.Drawing.Point(140, 237);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(442, 20);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(140, 197);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(442, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(65, 237);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(65, 18);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(65, 197);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 18);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // cboxTipoUsuario
            // 
            this.cboxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Comum"});
            this.cboxTipoUsuario.Location = new System.Drawing.Point(140, 279);
            this.cboxTipoUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboxTipoUsuario.Name = "cboxTipoUsuario";
            this.cboxTipoUsuario.Size = new System.Drawing.Size(199, 26);
            this.cboxTipoUsuario.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(462, 311);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 32);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblDescrição
            // 
            this.lblDescrição.AllowDrop = true;
            this.lblDescrição.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrição.Location = new System.Drawing.Point(65, 75);
            this.lblDescrição.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(506, 42);
            this.lblDescrição.TabIndex = 2;
            this.lblDescrição.Text = "Preencha todos os campos abaixo para adicionar um novo usuário ao sistema.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(62, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(450, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "👤 Cadastro de Novo Usuário";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(140, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(140, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(140, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(68, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 1);
            this.panel4.TabIndex = 11;
            // 
            // CriarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(673, 380);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescrição);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cboxTipoUsuario);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CriarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboxTipoUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}