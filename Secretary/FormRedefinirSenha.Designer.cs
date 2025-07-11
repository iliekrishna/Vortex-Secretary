namespace Secretary
{
    partial class FormRedefinirSenha
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRedefinirSenha));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.panelBaixo = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelEsquerda = new System.Windows.Forms.Panel();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnRedefinir = new System.Windows.Forms.Button();
            this.cboxMostrarSenha = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Transparent;
            this.panelTopo.Controls.Add(this.btnMinimizar);
            this.panelTopo.Controls.Add(this.btnFechar);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(615, 66);
            this.panelTopo.TabIndex = 9;
            // 
            // panelBaixo
            // 
            this.panelBaixo.BackColor = System.Drawing.Color.Transparent;
            this.panelBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBaixo.Location = new System.Drawing.Point(150, 366);
            this.panelBaixo.Name = "panelBaixo";
            this.panelBaixo.Size = new System.Drawing.Size(465, 62);
            this.panelBaixo.TabIndex = 10;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.Transparent;
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Controls.Add(this.cboxMostrarSenha);
            this.panelCentral.Controls.Add(this.btnRedefinir);
            this.panelCentral.Controls.Add(this.txtConfirmarSenha);
            this.panelCentral.Controls.Add(this.lblConfirmarSenha);
            this.panelCentral.Controls.Add(this.txtNovaSenha);
            this.panelCentral.Controls.Add(this.lblNovaSenha);
            this.panelCentral.Controls.Add(this.txtCodigo);
            this.panelCentral.Controls.Add(this.lblCodigo);
            this.panelCentral.Controls.Add(this.txtEmail);
            this.panelCentral.Controls.Add(this.lblEmail);
            this.panelCentral.Controls.Add(this.label1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(150, 66);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Padding = new System.Windows.Forms.Padding(30, 15, 40, 30);
            this.panelCentral.Size = new System.Drawing.Size(315, 300);
            this.panelCentral.TabIndex = 10;
            // 
            // panelEsquerda
            // 
            this.panelEsquerda.BackColor = System.Drawing.Color.Transparent;
            this.panelEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerda.Location = new System.Drawing.Point(0, 66);
            this.panelEsquerda.Name = "panelEsquerda";
            this.panelEsquerda.Size = new System.Drawing.Size(150, 362);
            this.panelEsquerda.TabIndex = 11;
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.Color.Transparent;
            this.panelDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDireita.Location = new System.Drawing.Point(465, 66);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(150, 300);
            this.panelDireita.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 25);
            this.label1.Size = new System.Drawing.Size(219, 48);
            this.label1.TabIndex = 23;
            this.label1.Text = "Redefinir Senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(30, 199);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(245, 14);
            this.txtConfirmarSenha.TabIndex = 31;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            this.txtConfirmarSenha.Enter += new System.EventHandler(this.txtConfirmarSenha_Enter);
            this.txtConfirmarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmarSenha_KeyDown);
            this.txtConfirmarSenha.Leave += new System.EventHandler(this.txtConfirmarSenha_Leave);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovaSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNovaSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNovaSenha.Location = new System.Drawing.Point(30, 156);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(245, 14);
            this.txtNovaSenha.TabIndex = 29;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            this.txtNovaSenha.Enter += new System.EventHandler(this.txtNovaSenha_Enter);
            this.txtNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovaSenha_KeyDown);
            this.txtNovaSenha.Leave += new System.EventHandler(this.txtNovaSenha_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.Location = new System.Drawing.Point(30, 112);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(245, 14);
            this.txtCodigo.TabIndex = 27;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(30, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 14);
            this.txtEmail.TabIndex = 25;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AccessibleDescription = "";
            this.btnMinimizar.AccessibleName = "";
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimizar.Location = new System.Drawing.Point(542, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 30);
            this.btnMinimizar.TabIndex = 33;
            this.btnMinimizar.Text = "—";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.AccessibleDescription = "";
            this.btnFechar.AccessibleName = "";
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.Location = new System.Drawing.Point(578, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 30);
            this.btnFechar.TabIndex = 36;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(30, 170);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Padding = new System.Windows.Forms.Padding(0, 7, 5, 9);
            this.lblConfirmarSenha.Size = new System.Drawing.Size(24, 29);
            this.lblConfirmarSenha.TabIndex = 30;
            this.lblConfirmarSenha.Text = "   ";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNovaSenha.ForeColor = System.Drawing.Color.Transparent;
            this.lblNovaSenha.Location = new System.Drawing.Point(30, 126);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Padding = new System.Windows.Forms.Padding(0, 7, 5, 10);
            this.lblNovaSenha.Size = new System.Drawing.Size(20, 30);
            this.lblNovaSenha.TabIndex = 28;
            this.lblNovaSenha.Text = "  ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodigo.ForeColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Location = new System.Drawing.Point(30, 87);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Padding = new System.Windows.Forms.Padding(0, 7, 5, 5);
            this.lblCodigo.Size = new System.Drawing.Size(20, 25);
            this.lblCodigo.TabIndex = 26;
            this.lblCodigo.Text = "  ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(30, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.lblEmail.Size = new System.Drawing.Size(10, 10);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "   ";
            // 
            // btnRedefinir
            // 
            this.btnRedefinir.BackColor = System.Drawing.Color.Transparent;
            this.btnRedefinir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRedefinir.FlatAppearance.BorderSize = 0;
            this.btnRedefinir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedefinir.ForeColor = System.Drawing.Color.Black;
            this.btnRedefinir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRedefinir.Location = new System.Drawing.Point(113, 267);
            this.btnRedefinir.Name = "btnRedefinir";
            this.btnRedefinir.Size = new System.Drawing.Size(89, 25);
            this.btnRedefinir.TabIndex = 33;
            this.btnRedefinir.Text = "Redefinir";
            this.btnRedefinir.UseVisualStyleBackColor = false;
            this.btnRedefinir.Click += new System.EventHandler(this.btnRedefinir_Click);
            // 
            // cboxMostrarSenha
            // 
            this.cboxMostrarSenha.AutoSize = true;
            this.cboxMostrarSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cboxMostrarSenha.Location = new System.Drawing.Point(18, 231);
            this.cboxMostrarSenha.Name = "cboxMostrarSenha";
            this.cboxMostrarSenha.Size = new System.Drawing.Size(107, 17);
            this.cboxMostrarSenha.TabIndex = 34;
            this.cboxMostrarSenha.Text = "Mostrar senha";
            this.cboxMostrarSenha.UseVisualStyleBackColor = true;
            this.cboxMostrarSenha.CheckedChanged += new System.EventHandler(this.cboxMostrarSenha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 10);
            this.label2.TabIndex = 35;
            this.label2.Text = "E-mail";
            // 
            // FormRedefinirSenha
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 428);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelDireita);
            this.Controls.Add(this.panelBaixo);
            this.Controls.Add(this.panelEsquerda);
            this.Controls.Add(this.panelTopo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRedefinirSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redefinir Senha";
            this.panelTopo.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelBaixo;
        private System.Windows.Forms.Panel panelEsquerda;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnRedefinir;
        private System.Windows.Forms.CheckBox cboxMostrarSenha;
        private System.Windows.Forms.Label label2;
    }
}