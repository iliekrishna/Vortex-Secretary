
namespace Secretary.Forms
{
    partial class GerenciamentoDocumentos
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
            this.panelGerenciamentoForms = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGerenciamentoItens = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.panelGerenciamentoForms.SuspendLayout();
            this.panelGerenciamentoItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGerenciamentoForms
            // 
            this.panelGerenciamentoForms.Controls.Add(this.label1);
            this.panelGerenciamentoForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGerenciamentoForms.Location = new System.Drawing.Point(20, 20);
            this.panelGerenciamentoForms.Name = "panelGerenciamentoForms";
            this.panelGerenciamentoForms.Padding = new System.Windows.Forms.Padding(30);
            this.panelGerenciamentoForms.Size = new System.Drawing.Size(1240, 100);
            this.panelGerenciamentoForms.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerenciamento de Formulários";
            // 
            // panelGerenciamentoItens
            // 
            this.panelGerenciamentoItens.Controls.Add(this.panelFormularios);
            this.panelGerenciamentoItens.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGerenciamentoItens.Location = new System.Drawing.Point(20, 120);
            this.panelGerenciamentoItens.Name = "panelGerenciamentoItens";
            this.panelGerenciamentoItens.Size = new System.Drawing.Size(1240, 357);
            this.panelGerenciamentoItens.TabIndex = 5;
            // 
            // panelFormularios
            // 
            this.panelFormularios.AutoScroll = true;
            this.panelFormularios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFormularios.Location = new System.Drawing.Point(0, 0);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1240, 357);
            this.panelFormularios.TabIndex = 3;
            // 
            // GerenciamentoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1280, 595);
            this.Controls.Add(this.panelGerenciamentoItens);
            this.Controls.Add(this.panelGerenciamentoForms);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GerenciamentoDocumentos";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Gerenciamento";
            this.Load += new System.EventHandler(this.Gerenciamento_Load);
            this.panelGerenciamentoForms.ResumeLayout(false);
            this.panelGerenciamentoForms.PerformLayout();
            this.panelGerenciamentoItens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGerenciamentoForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGerenciamentoItens;
        private System.Windows.Forms.Panel panelFormularios;
    }
}