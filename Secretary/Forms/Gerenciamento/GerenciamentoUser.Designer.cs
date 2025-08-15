using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms
{
    partial class GerenciamentoUser
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
            this.tabPageFaq = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelFaq = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlGerenciamento.SuspendLayout();
            this.tabPageDocumentos.SuspendLayout();
            this.tabPageFaq.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Verdana", 18F);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Padding = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.labelTitulo.Size = new System.Drawing.Size(800, 80);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Gerenciamento de Usuário";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControlGerenciamento
            // 
            this.tabControlGerenciamento.Controls.Add(this.tabPageDocumentos);
            this.tabControlGerenciamento.Controls.Add(this.tabPageFaq);
            this.tabControlGerenciamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGerenciamento.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tabControlGerenciamento.ItemSize = new System.Drawing.Size(150, 35);
            this.tabControlGerenciamento.Location = new System.Drawing.Point(0, 80);
            this.tabControlGerenciamento.Name = "tabControlGerenciamento";
            this.tabControlGerenciamento.Padding = new System.Drawing.Point(30, 3);
            this.tabControlGerenciamento.SelectedIndex = 0;
            this.tabControlGerenciamento.Size = new System.Drawing.Size(800, 420);
            this.tabControlGerenciamento.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlGerenciamento.TabIndex = 1;
            this.tabControlGerenciamento.SelectedIndexChanged += new System.EventHandler(this.tabControlGerenciamento_SelectedIndexChanged);
            // 
            // tabPageDocumentos
            // 
            this.tabPageDocumentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageDocumentos.Controls.Add(this.flowLayoutPanelDocumentos);
            this.tabPageDocumentos.Location = new System.Drawing.Point(4, 39);
            this.tabPageDocumentos.Name = "tabPageDocumentos";
            this.tabPageDocumentos.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageDocumentos.Size = new System.Drawing.Size(792, 377);
            this.tabPageDocumentos.TabIndex = 0;
            this.tabPageDocumentos.Text = "Documentos";
            // 
            // flowLayoutPanelDocumentos
            // 
            this.flowLayoutPanelDocumentos.AutoScroll = true;
            this.flowLayoutPanelDocumentos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDocumentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDocumentos.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelDocumentos.Name = "flowLayoutPanelDocumentos";
            this.flowLayoutPanelDocumentos.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelDocumentos.Size = new System.Drawing.Size(772, 357);
            this.flowLayoutPanelDocumentos.TabIndex = 0;
            this.flowLayoutPanelDocumentos.WrapContents = false;
            // 
            // tabPageFaq
            // 
            this.tabPageFaq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageFaq.Controls.Add(this.flowLayoutPanelFaq);
            this.tabPageFaq.Location = new System.Drawing.Point(4, 39);
            this.tabPageFaq.Name = "tabPageFaq";
            this.tabPageFaq.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageFaq.Size = new System.Drawing.Size(792, 377);
            this.tabPageFaq.TabIndex = 2;
            this.tabPageFaq.Text = "FAQ";
            // 
            // flowLayoutPanelFaq
            // 
            this.flowLayoutPanelFaq.AutoScroll = true;
            this.flowLayoutPanelFaq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelFaq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFaq.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFaq.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelFaq.Name = "flowLayoutPanelFaq";
            this.flowLayoutPanelFaq.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelFaq.Size = new System.Drawing.Size(772, 357);
            this.flowLayoutPanelFaq.TabIndex = 0;
            this.flowLayoutPanelFaq.WrapContents = false;
            // 
            // GerenciamentoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControlGerenciamento);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "GerenciamentoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuário";
            this.tabControlGerenciamento.ResumeLayout(false);
            this.tabPageDocumentos.ResumeLayout(false);
            this.tabPageFaq.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void tabControlGerenciamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlGerenciamento.SelectedTab.Name)
            {
                case "tabPageDocumentos":
                    CarregarDocumentosDisponiveis();
                    break;

                case "tabPageFaq":
                    CarregarFaq();
                    break;
            }
        }
        #endregion

        private Label labelTitulo;
        private TabPage tabPageFaq;
        private FlowLayoutPanel flowLayoutPanelFaq;
        private TabPage tabPageDocumentos;
        private FlowLayoutPanel flowLayoutPanelDocumentos;
        private TabControl tabControlGerenciamento;
    }
}
