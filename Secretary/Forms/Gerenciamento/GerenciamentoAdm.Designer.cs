using System;
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
            this.tabControlUsuariosAtivoInativo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelUsuariosInativos = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageFaq = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelFaq = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlGerenciamento.SuspendLayout();
            this.tabPageDocumentos.SuspendLayout();
            this.tabPageUsuarios.SuspendLayout();
            this.tabControlUsuariosAtivoInativo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.labelTitulo.Text = "Gerenciamento Administrativo";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControlGerenciamento
            // 
            this.tabControlGerenciamento.Controls.Add(this.tabPageDocumentos);
            this.tabControlGerenciamento.Controls.Add(this.tabPageUsuarios);
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
            this.tabControlGerenciamento.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl_DrawItem);
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
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUsuarios.Controls.Add(this.tabControlUsuariosAtivoInativo);
            this.tabPageUsuarios.Location = new System.Drawing.Point(4, 39);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageUsuarios.Size = new System.Drawing.Size(792, 377);
            this.tabPageUsuarios.TabIndex = 1;
            this.tabPageUsuarios.Text = "Usuários";
            // 
            // tabControlUsuariosAtivoInativo
            // 
            this.tabControlUsuariosAtivoInativo.Controls.Add(this.tabPage1);
            this.tabControlUsuariosAtivoInativo.Controls.Add(this.tabPage2);
            this.tabControlUsuariosAtivoInativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUsuariosAtivoInativo.Location = new System.Drawing.Point(10, 10);
            this.tabControlUsuariosAtivoInativo.Name = "tabControlUsuariosAtivoInativo";
            this.tabControlUsuariosAtivoInativo.Padding = new System.Drawing.Point(10, 5);
            this.tabControlUsuariosAtivoInativo.SelectedIndex = 0;
            this.tabControlUsuariosAtivoInativo.Size = new System.Drawing.Size(772, 357);
            this.tabControlUsuariosAtivoInativo.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanelUsuarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ativos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelUsuarios
            // 
            this.flowLayoutPanelUsuarios.AutoScroll = true;
            this.flowLayoutPanelUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUsuarios.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelUsuarios.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelUsuarios.Name = "flowLayoutPanelUsuarios";
            this.flowLayoutPanelUsuarios.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelUsuarios.Size = new System.Drawing.Size(758, 318);
            this.flowLayoutPanelUsuarios.TabIndex = 1;
            this.flowLayoutPanelUsuarios.WrapContents = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanelUsuariosInativos);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inativos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelUsuariosInativos
            // 
            this.flowLayoutPanelUsuariosInativos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUsuariosInativos.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelUsuariosInativos.Name = "flowLayoutPanelUsuariosInativos";
            this.flowLayoutPanelUsuariosInativos.Size = new System.Drawing.Size(758, 318);
            this.flowLayoutPanelUsuariosInativos.TabIndex = 0;
            this.flowLayoutPanelUsuariosInativos.AutoScroll = true;
            this.flowLayoutPanelUsuariosInativos.Padding = new Padding(5);
            this.flowLayoutPanelUsuariosInativos.WrapContents = false;
            this.flowLayoutPanelUsuariosInativos.FlowDirection = FlowDirection.TopDown;
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
            // GerenciamentoAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.tabControlUsuariosAtivoInativo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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

                case "tabPageUsuarios":
                    CarregarUsuarios();
                    break;

                case "tabPageFaq":
                    CarregarFaq();
                    break;
            }
        }
        #endregion

        private Label labelTitulo;
        private TabControl tabControlGerenciamento;
        private TabPage tabPageDocumentos;
        private FlowLayoutPanel flowLayoutPanelDocumentos;
        private TabPage tabPageUsuarios;
        private TabPage tabPageFaq;
        private FlowLayoutPanel flowLayoutPanelFaq;
        private TabControl tabControlUsuariosAtivoInativo;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanelUsuarios;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanelUsuariosInativos;
    }
}