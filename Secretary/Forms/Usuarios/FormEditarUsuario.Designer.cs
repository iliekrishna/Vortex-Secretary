
namespace Secretary.Forms
{
    partial class FormEditarUsuario
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
            this.panelDivisor2 = new System.Windows.Forms.Panel();
            this.panelDivisor1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.linklblAlterarSenha = new System.Windows.Forms.LinkLabel();
            this.panelAlterarSenha = new System.Windows.Forms.Panel();
            this.panelDivisor4 = new System.Windows.Forms.Panel();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.panelDivisor5 = new System.Windows.Forms.Panel();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.panelDivisor3 = new System.Windows.Forms.Panel();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.panelAlterarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDivisor2
            // 
            this.panelDivisor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor2.Location = new System.Drawing.Point(216, 163);
            this.panelDivisor2.Margin = new System.Windows.Forms.Padding(4);
            this.panelDivisor2.Name = "panelDivisor2";
            this.panelDivisor2.Size = new System.Drawing.Size(411, 1);
            this.panelDivisor2.TabIndex = 25;
            // 
            // panelDivisor1
            // 
            this.panelDivisor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor1.Location = new System.Drawing.Point(216, 111);
            this.panelDivisor1.Margin = new System.Windows.Forms.Padding(4);
            this.panelDivisor1.Name = "panelDivisor1";
            this.panelDivisor1.Size = new System.Drawing.Size(411, 1);
            this.panelDivisor1.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(53, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 32);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Editar Usuário";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(671, 233);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(162, 29);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Salvar Alterações";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cboxTipoUsuario
            // 
            this.cboxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Comum"});
            this.cboxTipoUsuario.Location = new System.Drawing.Point(216, 190);
            this.cboxTipoUsuario.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.cboxTipoUsuario.Name = "cboxTipoUsuario";
            this.cboxTipoUsuario.Size = new System.Drawing.Size(264, 24);
            this.cboxTipoUsuario.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(216, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(411, 16);
            this.txtEmail.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Location = new System.Drawing.Point(216, 86);
            this.txtNome.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(411, 16);
            this.txtNome.TabIndex = 19;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(68, 191);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(144, 18);
            this.lblTipoUsuario.TabIndex = 16;
            this.lblTipoUsuario.Text = "Tipo de Usuário:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(145, 137);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 18);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(56, 87);
            this.lblNome.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(156, 18);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome de Usuário:";
            // 
            // linklblAlterarSenha
            // 
            this.linklblAlterarSenha.ActiveLinkColor = System.Drawing.Color.Black;
            this.linklblAlterarSenha.AutoSize = true;
            this.linklblAlterarSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblAlterarSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linklblAlterarSenha.Location = new System.Drawing.Point(94, 246);
            this.linklblAlterarSenha.Name = "linklblAlterarSenha";
            this.linklblAlterarSenha.Size = new System.Drawing.Size(118, 18);
            this.linklblAlterarSenha.TabIndex = 27;
            this.linklblAlterarSenha.TabStop = true;
            this.linklblAlterarSenha.Text = "Alterar senha";
            this.linklblAlterarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblAlterarSenha_LinkClicked);
            // 
            // panelAlterarSenha
            // 
            this.panelAlterarSenha.Controls.Add(this.panelDivisor4);
            this.panelAlterarSenha.Controls.Add(this.txtSenhaNova);
            this.panelAlterarSenha.Controls.Add(this.panelDivisor5);
            this.panelAlterarSenha.Controls.Add(this.txtConfirmarSenha);
            this.panelAlterarSenha.Controls.Add(this.lblConfirmarSenha);
            this.panelAlterarSenha.Controls.Add(this.lblNovaSenha);
            this.panelAlterarSenha.Controls.Add(this.panelDivisor3);
            this.panelAlterarSenha.Controls.Add(this.txtSenhaAtual);
            this.panelAlterarSenha.Controls.Add(this.lblSenhaAtual);
            this.panelAlterarSenha.Location = new System.Drawing.Point(1, 293);
            this.panelAlterarSenha.Name = "panelAlterarSenha";
            this.panelAlterarSenha.Size = new System.Drawing.Size(884, 126);
            this.panelAlterarSenha.TabIndex = 28;
            this.panelAlterarSenha.Visible = false;
            // 
            // panelDivisor4
            // 
            this.panelDivisor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor4.Location = new System.Drawing.Point(215, 69);
            this.panelDivisor4.Margin = new System.Windows.Forms.Padding(4);
            this.panelDivisor4.Name = "panelDivisor4";
            this.panelDivisor4.Size = new System.Drawing.Size(382, 1);
            this.panelDivisor4.TabIndex = 33;
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenhaNova.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaNova.Location = new System.Drawing.Point(215, 51);
            this.txtSenhaNova.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(382, 16);
            this.txtSenhaNova.TabIndex = 32;
            // 
            // panelDivisor5
            // 
            this.panelDivisor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor5.Location = new System.Drawing.Point(215, 111);
            this.panelDivisor5.Margin = new System.Windows.Forms.Padding(4);
            this.panelDivisor5.Name = "panelDivisor5";
            this.panelDivisor5.Size = new System.Drawing.Size(382, 1);
            this.panelDivisor5.TabIndex = 31;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(215, 94);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(382, 16);
            this.txtConfirmarSenha.TabIndex = 30;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(15, 91);
            this.lblConfirmarSenha.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(194, 18);
            this.lblConfirmarSenha.TabIndex = 29;
            this.lblConfirmarSenha.Text = "Confirmar nova senha:";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.Location = new System.Drawing.Point(92, 54);
            this.lblNovaSenha.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(112, 18);
            this.lblNovaSenha.TabIndex = 28;
            this.lblNovaSenha.Text = "Nova Senha:";
            // 
            // panelDivisor3
            // 
            this.panelDivisor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor3.Location = new System.Drawing.Point(215, 27);
            this.panelDivisor3.Margin = new System.Windows.Forms.Padding(4);
            this.panelDivisor3.Name = "panelDivisor3";
            this.panelDivisor3.Size = new System.Drawing.Size(382, 1);
            this.panelDivisor3.TabIndex = 27;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaAtual.Location = new System.Drawing.Point(215, 9);
            this.txtSenhaAtual.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(382, 16);
            this.txtSenhaAtual.TabIndex = 25;
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.Location = new System.Drawing.Point(90, 10);
            this.lblSenhaAtual.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(114, 18);
            this.lblSenhaAtual.TabIndex = 24;
            this.lblSenhaAtual.Text = "Senha Atual:";
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirUsuario.Location = new System.Drawing.Point(671, 267);
            this.btnExcluirUsuario.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(162, 29);
            this.btnExcluirUsuario.TabIndex = 29;
            this.btnExcluirUsuario.Text = "Excluir Usuário";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.panelAlterarSenha);
            this.Controls.Add(this.linklblAlterarSenha);
            this.Controls.Add(this.panelDivisor2);
            this.Controls.Add(this.panelDivisor1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cboxTipoUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição Usuário";
            this.Load += new System.EventHandler(this.FormEditarUsuario_Load);
            this.panelAlterarSenha.ResumeLayout(false);
            this.panelAlterarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelDivisor2;
        private System.Windows.Forms.Panel panelDivisor1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cboxTipoUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.LinkLabel linklblAlterarSenha;
        private System.Windows.Forms.Panel panelAlterarSenha;
        private System.Windows.Forms.Panel panelDivisor4;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Panel panelDivisor5;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Panel panelDivisor3;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Button btnExcluirUsuario;
    }
}