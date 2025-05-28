namespace Secretary
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelDireita = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblFazerLogin = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.panelDivisor1 = new System.Windows.Forms.Panel();
            this.panelDivisor2 = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.linkLabelEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.cboxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.panelEsquerda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.Color.Transparent;
            this.panelDireita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDireita.BackgroundImage")));
            this.panelDireita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDireita.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDireita.Location = new System.Drawing.Point(0, 0);
            this.panelDireita.Margin = new System.Windows.Forms.Padding(4);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(631, 467);
            this.panelDireita.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.AccessibleDescription = "";
            this.btnFechar.AccessibleName = "";
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.Location = new System.Drawing.Point(393, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 30);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "X";
            this.toolTip.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AccessibleDescription = "";
            this.btnMinimizar.AccessibleName = "";
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimizar.Location = new System.Drawing.Point(357, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 30);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.Text = "—";
            this.toolTip.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(64, 180);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(305, 16);
            this.txtUsuario.TabIndex = 15;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Location = new System.Drawing.Point(64, 259);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(305, 16);
            this.txtSenha.TabIndex = 16;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            // 
            // lblFazerLogin
            // 
            this.lblFazerLogin.AutoSize = true;
            this.lblFazerLogin.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFazerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFazerLogin.Location = new System.Drawing.Point(57, 67);
            this.lblFazerLogin.Name = "lblFazerLogin";
            this.lblFazerLogin.Size = new System.Drawing.Size(209, 42);
            this.lblFazerLogin.TabIndex = 0;
            this.lblFazerLogin.Text = "Fazer Login";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(60, 150);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 22);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSenha.Location = new System.Drawing.Point(60, 227);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(68, 22);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // panelDivisor1
            // 
            this.panelDivisor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDivisor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDivisor1.Location = new System.Drawing.Point(64, 200);
            this.panelDivisor1.Name = "panelDivisor1";
            this.panelDivisor1.Size = new System.Drawing.Size(305, 2);
            this.panelDivisor1.TabIndex = 5;
            // 
            // panelDivisor2
            // 
            this.panelDivisor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDivisor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDivisor2.Location = new System.Drawing.Point(64, 279);
            this.panelDivisor2.Name = "panelDivisor2";
            this.panelDivisor2.Size = new System.Drawing.Size(305, 2);
            this.panelDivisor2.TabIndex = 10;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Red;
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(64, 356);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(305, 45);
            this.btnEntrar.TabIndex = 17;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // linkLabelEsqueciSenha
            // 
            this.linkLabelEsqueciSenha.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelEsqueciSenha.AutoSize = true;
            this.linkLabelEsqueciSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEsqueciSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelEsqueciSenha.Location = new System.Drawing.Point(258, 258);
            this.linkLabelEsqueciSenha.Name = "linkLabelEsqueciSenha";
            this.linkLabelEsqueciSenha.Size = new System.Drawing.Size(111, 17);
            this.linkLabelEsqueciSenha.TabIndex = 6;
            this.linkLabelEsqueciSenha.TabStop = true;
            this.linkLabelEsqueciSenha.Text = "Esqueci a senha";
            this.linkLabelEsqueciSenha.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // cboxMostrarSenha
            // 
            this.cboxMostrarSenha.AutoSize = true;
            this.cboxMostrarSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboxMostrarSenha.Location = new System.Drawing.Point(64, 296);
            this.cboxMostrarSenha.Name = "cboxMostrarSenha";
            this.cboxMostrarSenha.Size = new System.Drawing.Size(112, 21);
            this.cboxMostrarSenha.TabIndex = 18;
            this.cboxMostrarSenha.Text = "Mostrar Senha";
            this.cboxMostrarSenha.UseVisualStyleBackColor = true;
            this.cboxMostrarSenha.CheckedChanged += new System.EventHandler(this.cboxMostrarSenha_CheckedChanged);
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEsquerda.Controls.Add(this.btnMinimizar);
            this.panelEsquerda.Controls.Add(this.btnFechar);
            this.panelEsquerda.Controls.Add(this.cboxMostrarSenha);
            this.panelEsquerda.Controls.Add(this.linkLabelEsqueciSenha);
            this.panelEsquerda.Controls.Add(this.btnEntrar);
            this.panelEsquerda.Controls.Add(this.panelDivisor2);
            this.panelEsquerda.Controls.Add(this.panelDivisor1);
            this.panelEsquerda.Controls.Add(this.lblSenha);
            this.panelEsquerda.Controls.Add(this.lblUsuario);
            this.panelEsquerda.Controls.Add(this.lblFazerLogin);
            this.panelEsquerda.Controls.Add(this.txtSenha);
            this.panelEsquerda.Controls.Add(this.txtUsuario);
            this.panelEsquerda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEsquerda.Location = new System.Drawing.Point(631, 0);
            this.panelEsquerda.Margin = new System.Windows.Forms.Padding(4);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(434, 467);
            this.panelEsquerda.TabIndex = 1;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 467);
            this.Controls.Add(this.panelEsquerda);
            this.Controls.Add(this.panelDireita);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelEsquerda.ResumeLayout(false);
            this.panelEsquerda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblFazerLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Panel panelDivisor1;
        private System.Windows.Forms.Panel panelDivisor2;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel linkLabelEsqueciSenha;
        private System.Windows.Forms.CheckBox cboxMostrarSenha;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelEsquerda;
    }
}

