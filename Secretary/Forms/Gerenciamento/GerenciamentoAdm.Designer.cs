using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms
{
    partial class GerenciamentoAdm
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



            this.labelTitulo = new System.Windows.Forms.Label();
            this.tabControlGerenciamento = new System.Windows.Forms.TabControl();
            this.tabPageDocumentos = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelDocumentos = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelUsuarios = new System.Windows.Forms.FlowLayoutPanel();


            this.tabControlGerenciamento.SuspendLayout();
            this.tabPageDocumentos.SuspendLayout();
            this.tabPageUsuarios.SuspendLayout();
            this.SuspendLayout();

            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Padding = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.labelTitulo.Size = new System.Drawing.Size(800, 80);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Gerenciamento Administrativo";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // tabControlGerenciamento
            // 
            this.tabControlGerenciamento.Controls.Add(this.tabPageDocumentos);
            this.tabControlGerenciamento.Controls.Add(this.tabPageUsuarios);
            this.tabControlGerenciamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGerenciamento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabControlGerenciamento.Location = new System.Drawing.Point(0, 80);
            this.tabControlGerenciamento.Name = "tabControlGerenciamento";
            this.tabControlGerenciamento.SelectedIndex = 0;
            this.tabControlGerenciamento.Size = new System.Drawing.Size(800, 420);
            this.tabControlGerenciamento.TabIndex = 1;
            this.tabControlGerenciamento.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControlGerenciamento.DrawItem += TabControl_DrawItem;
            this.tabControlGerenciamento.Padding = new Point(30, 3);
            this.tabControlGerenciamento.SizeMode = TabSizeMode.Fixed;
            this.tabControlGerenciamento.ItemSize = new Size(150, 35);

            // 
            // tabPageDocumentos
            // 
            this.tabPageDocumentos.BackColor = System.Drawing.Color.White;
            this.tabPageDocumentos.Controls.Add(this.flowLayoutPanelDocumentos);
            this.tabPageDocumentos.Location = new System.Drawing.Point(4, 34);
            this.tabPageDocumentos.Name = "tabPageDocumentos";
            this.tabPageDocumentos.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageDocumentos.Size = new System.Drawing.Size(792, 382);
            this.tabPageDocumentos.TabIndex = 0;
            this.tabPageDocumentos.Text = "Documentos";

            // 
            // flowLayoutPanelDocumentos
            // 
            this.flowLayoutPanelDocumentos.AutoScroll = true;
            this.flowLayoutPanelDocumentos.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDocumentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDocumentos.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelDocumentos.Name = "flowLayoutPanelDocumentos";
            this.flowLayoutPanelDocumentos.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelDocumentos.Size = new System.Drawing.Size(772, 362);
            this.flowLayoutPanelDocumentos.TabIndex = 0;
            this.flowLayoutPanelDocumentos.WrapContents = false;

            // 
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.BackColor = System.Drawing.Color.White;
            this.tabPageUsuarios.Controls.Add(this.flowLayoutPanelUsuarios);
            this.tabPageUsuarios.Location = new System.Drawing.Point(4, 34);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageUsuarios.Size = new System.Drawing.Size(792, 382);
            this.tabPageUsuarios.TabIndex = 1;
            this.tabPageUsuarios.Text = "Usuários";

            // 
            // flowLayoutPanelUsuarios
            // 
            this.flowLayoutPanelUsuarios.AutoScroll = true;
            this.flowLayoutPanelUsuarios.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUsuarios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelUsuarios.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelUsuarios.Name = "flowLayoutPanelUsuarios";
            this.flowLayoutPanelUsuarios.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelUsuarios.Size = new System.Drawing.Size(772, 362);
            this.flowLayoutPanelUsuarios.TabIndex = 0;
            this.flowLayoutPanelUsuarios.WrapContents = false;

            // 
            // GerenciamentoAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControlGerenciamento);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "GerenciamentoAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento Administrativo";
            this.tabControlGerenciamento.ResumeLayout(false);
            this.tabPageDocumentos.ResumeLayout(false);
            this.tabPageUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabControl = (TabControl)sender;
            var tabPage = tabControl.TabPages[e.Index];
            var rect = tabControl.GetTabRect(e.Index);
            var textRect = new Rectangle(rect.Left + 20, rect.Top, rect.Width - 20, rect.Height);

            bool isSelected = tabControl.SelectedIndex == e.Index;
            Color backColor = isSelected ? Color.White : Color.FromArgb(240, 240, 240);
            Color textColor = isSelected ? Color.FromArgb(0, 118, 137) : Color.Gray;
            Font textFont = isSelected ? new Font("Segoe UI", 10, FontStyle.Bold)
                                     : new Font("Segoe UI", 9, FontStyle.Regular);

            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

            TextRenderer.DrawText(e.Graphics, tabPage.Text, textFont, textRect, textColor,
                                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            if (isSelected)
            {
                using (var pen = new Pen(Color.FromArgb(0, 118, 137), 3))
                {
                    e.Graphics.DrawLine(pen, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);
                }
            }
        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TabControl tabControlGerenciamento;
        private System.Windows.Forms.TabPage tabPageDocumentos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDocumentos;
        private System.Windows.Forms.TabPage tabPageUsuarios;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUsuarios;
    }
}