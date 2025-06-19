namespace Secretary.Forms
{
    partial class GerenciamentoAdm
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
            this.lblGerenciamentoFormularios = new System.Windows.Forms.Label();
            this.panelTituloGerenciamentoForms = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelTituloGerenciadorDeUsu = new System.Windows.Forms.Panel();
            this.lblGerenciamentoDeUsuarios = new System.Windows.Forms.Label();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.panelTituloGerenciamentoForms.SuspendLayout();
            this.panelTituloGerenciadorDeUsu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGerenciamentoFormularios
            // 
            this.lblGerenciamentoFormularios.AutoSize = true;
            this.lblGerenciamentoFormularios.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGerenciamentoFormularios.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.lblGerenciamentoFormularios.Location = new System.Drawing.Point(30, 30);
            this.lblGerenciamentoFormularios.Name = "lblGerenciamentoFormularios";
            this.lblGerenciamentoFormularios.Size = new System.Drawing.Size(337, 25);
            this.lblGerenciamentoFormularios.TabIndex = 2;
            this.lblGerenciamentoFormularios.Text = "Gerenciamento de Formulários";
            // 
            // panelTituloGerenciamentoForms
            // 
            this.panelTituloGerenciamentoForms.Controls.Add(this.lblGerenciamentoFormularios);
            this.panelTituloGerenciamentoForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloGerenciamentoForms.Location = new System.Drawing.Point(20, 20);
            this.panelTituloGerenciamentoForms.Name = "panelTituloGerenciamentoForms";
            this.panelTituloGerenciamentoForms.Padding = new System.Windows.Forms.Padding(30);
            this.panelTituloGerenciamentoForms.Size = new System.Drawing.Size(1240, 100);
            this.panelTituloGerenciamentoForms.TabIndex = 5;
            // 
            // panelFormularios
            // 
            this.panelFormularios.AutoScroll = true;
            this.panelFormularios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormularios.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormularios.Location = new System.Drawing.Point(20, 120);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1240, 340);
            this.panelFormularios.TabIndex = 9;
            // 
            // panelTituloGerenciadorDeUsu
            // 
            this.panelTituloGerenciadorDeUsu.Controls.Add(this.lblGerenciamentoDeUsuarios);
            this.panelTituloGerenciadorDeUsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloGerenciadorDeUsu.Location = new System.Drawing.Point(20, 460);
            this.panelTituloGerenciadorDeUsu.Name = "panelTituloGerenciadorDeUsu";
            this.panelTituloGerenciadorDeUsu.Padding = new System.Windows.Forms.Padding(30, 40, 30, 10);
            this.panelTituloGerenciadorDeUsu.Size = new System.Drawing.Size(1240, 129);
            this.panelTituloGerenciadorDeUsu.TabIndex = 11;
            // 
            // lblGerenciamentoDeUsuarios
            // 
            this.lblGerenciamentoDeUsuarios.AutoSize = true;
            this.lblGerenciamentoDeUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGerenciamentoDeUsuarios.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.lblGerenciamentoDeUsuarios.Location = new System.Drawing.Point(30, 40);
            this.lblGerenciamentoDeUsuarios.Name = "lblGerenciamentoDeUsuarios";
            this.lblGerenciamentoDeUsuarios.Size = new System.Drawing.Size(304, 25);
            this.lblGerenciamentoDeUsuarios.TabIndex = 2;
            this.lblGerenciamentoDeUsuarios.Text = "Gerenciamento de Usuários";
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.AutoScroll = true;
            this.panelUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsuarios.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUsuarios.Location = new System.Drawing.Point(20, 589);
            this.panelUsuarios.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelUsuarios.Size = new System.Drawing.Size(1240, 329);
            this.panelUsuarios.TabIndex = 12;
            // 
            // GerenciamentoAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1297, 749);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.panelTituloGerenciadorDeUsu);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.panelTituloGerenciamentoForms);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GerenciamentoAdm";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 60);
            this.Text = "GerenciamentoAdm";
            this.Load += new System.EventHandler(this.GerenciamentoAdm_Load);
            this.panelTituloGerenciamentoForms.ResumeLayout(false);
            this.panelTituloGerenciamentoForms.PerformLayout();
            this.panelTituloGerenciadorDeUsu.ResumeLayout(false);
            this.panelTituloGerenciadorDeUsu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGerenciamentoFormularios;
        private System.Windows.Forms.Panel panelTituloGerenciamentoForms;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Panel panelTituloGerenciadorDeUsu;
        private System.Windows.Forms.Label lblGerenciamentoDeUsuarios;
        private System.Windows.Forms.Panel panelUsuarios;
    }
}