namespace Secretary.Forms
{
    partial class GerenciamentoDocumentos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // panelFormularios
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 60);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(800, 540);
            this.panelFormularios.TabIndex = 0;

            // labelTitulo
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Padding = new System.Windows.Forms.Padding(20, 15, 0, 15);
            this.labelTitulo.Size = new System.Drawing.Size(800, 60);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Gerenciamento de Formulários";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // GerenciamentoDocumentos
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "GerenciamentoDocumentos";
            this.Text = "Gerenciamento de Formulários";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Label labelTitulo;
    }
}