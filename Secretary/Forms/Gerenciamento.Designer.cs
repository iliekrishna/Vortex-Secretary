
namespace Secretary.Forms
{
    partial class Gerenciamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelRA = new System.Windows.Forms.Panel();
            this.rbtnAtivoRA = new System.Windows.Forms.RadioButton();
            this.rbtnInativoRA = new System.Windows.Forms.RadioButton();
            this.btnDetalhesRA = new System.Windows.Forms.Button();
            this.lblRA = new System.Windows.Forms.Label();
            this.panelContProg = new System.Windows.Forms.Panel();
            this.rbtnAtivoContProg = new System.Windows.Forms.RadioButton();
            this.rbtnInativoContProg = new System.Windows.Forms.RadioButton();
            this.btnDetalhesContProg = new System.Windows.Forms.Button();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.panelHistorico = new System.Windows.Forms.Panel();
            this.rbtnAtivoHistorico = new System.Windows.Forms.RadioButton();
            this.rbtnInativoHistorico = new System.Windows.Forms.RadioButton();
            this.btnDetalhesHistorico = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.panelDeclaracao = new System.Windows.Forms.Panel();
            this.rbtnAtivoDeclaracao = new System.Windows.Forms.RadioButton();
            this.rbtnInativoDeclaracao = new System.Windows.Forms.RadioButton();
            this.btnDetalhesDeclaracao = new System.Windows.Forms.Button();
            this.lblDeclaracao = new System.Windows.Forms.Label();
            this.panelCertificado = new System.Windows.Forms.Panel();
            this.rbtnAtivoCertificado = new System.Windows.Forms.RadioButton();
            this.rbtnInativoCertificado = new System.Windows.Forms.RadioButton();
            this.btnDetalhesCertificado = new System.Windows.Forms.Button();
            this.lblCertificado = new System.Windows.Forms.Label();
            this.btnAdicionarRequerimento = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelRA.SuspendLayout();
            this.panelContProg.SuspendLayout();
            this.panelHistorico.SuspendLayout();
            this.panelDeclaracao.SuspendLayout();
            this.panelCertificado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciamento de Formulários";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.panelRA);
            this.panelPrincipal.Controls.Add(this.panelContProg);
            this.panelPrincipal.Controls.Add(this.panelHistorico);
            this.panelPrincipal.Controls.Add(this.panelDeclaracao);
            this.panelPrincipal.Controls.Add(this.panelCertificado);
            this.panelPrincipal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrincipal.Location = new System.Drawing.Point(43, 160);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(803, 349);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelRA
            // 
            this.panelRA.Controls.Add(this.rbtnAtivoRA);
            this.panelRA.Controls.Add(this.rbtnInativoRA);
            this.panelRA.Controls.Add(this.btnDetalhesRA);
            this.panelRA.Controls.Add(this.lblRA);
            this.panelRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRA.Location = new System.Drawing.Point(0, 200);
            this.panelRA.Name = "panelRA";
            this.panelRA.Padding = new System.Windows.Forms.Padding(5, 10, 20, 15);
            this.panelRA.Size = new System.Drawing.Size(799, 50);
            this.panelRA.TabIndex = 4;
            // 
            // rbtnAtivoRA
            // 
            this.rbtnAtivoRA.AutoSize = true;
            this.rbtnAtivoRA.Checked = true;
            this.rbtnAtivoRA.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnAtivoRA.Location = new System.Drawing.Point(415, 10);
            this.rbtnAtivoRA.Name = "rbtnAtivoRA";
            this.rbtnAtivoRA.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.rbtnAtivoRA.Size = new System.Drawing.Size(84, 25);
            this.rbtnAtivoRA.TabIndex = 5;
            this.rbtnAtivoRA.TabStop = true;
            this.rbtnAtivoRA.Text = "Ativo";
            this.rbtnAtivoRA.UseVisualStyleBackColor = true;
            // 
            // rbtnInativoRA
            // 
            this.rbtnInativoRA.AutoSize = true;
            this.rbtnInativoRA.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnInativoRA.Location = new System.Drawing.Point(499, 10);
            this.rbtnInativoRA.Name = "rbtnInativoRA";
            this.rbtnInativoRA.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.rbtnInativoRA.Size = new System.Drawing.Size(157, 25);
            this.rbtnInativoRA.TabIndex = 4;
            this.rbtnInativoRA.Text = "Inativo";
            this.rbtnInativoRA.UseVisualStyleBackColor = true;
            // 
            // btnDetalhesRA
            // 
            this.btnDetalhesRA.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetalhesRA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhesRA.Location = new System.Drawing.Point(656, 10);
            this.btnDetalhesRA.Margin = new System.Windows.Forms.Padding(20);
            this.btnDetalhesRA.Name = "btnDetalhesRA";
            this.btnDetalhesRA.Size = new System.Drawing.Size(123, 25);
            this.btnDetalhesRA.TabIndex = 3;
            this.btnDetalhesRA.Text = "Editar detalhes";
            this.btnDetalhesRA.UseVisualStyleBackColor = true;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRA.Location = new System.Drawing.Point(5, 10);
            this.lblRA.Name = "lblRA";
            this.lblRA.Padding = new System.Windows.Forms.Padding(70, 5, 0, 0);
            this.lblRA.Size = new System.Drawing.Size(339, 23);
            this.lblRA.TabIndex = 0;
            this.lblRA.Text = "Carteira de Identidade Escolar (RA)";
            // 
            // panelContProg
            // 
            this.panelContProg.Controls.Add(this.rbtnAtivoContProg);
            this.panelContProg.Controls.Add(this.rbtnInativoContProg);
            this.panelContProg.Controls.Add(this.btnDetalhesContProg);
            this.panelContProg.Controls.Add(this.lblConteudo);
            this.panelContProg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContProg.Location = new System.Drawing.Point(0, 150);
            this.panelContProg.Name = "panelContProg";
            this.panelContProg.Padding = new System.Windows.Forms.Padding(5, 10, 20, 15);
            this.panelContProg.Size = new System.Drawing.Size(799, 50);
            this.panelContProg.TabIndex = 3;
            // 
            // rbtnAtivoContProg
            // 
            this.rbtnAtivoContProg.AutoSize = true;
            this.rbtnAtivoContProg.Checked = true;
            this.rbtnAtivoContProg.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnAtivoContProg.Location = new System.Drawing.Point(415, 10);
            this.rbtnAtivoContProg.Name = "rbtnAtivoContProg";
            this.rbtnAtivoContProg.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.rbtnAtivoContProg.Size = new System.Drawing.Size(84, 25);
            this.rbtnAtivoContProg.TabIndex = 5;
            this.rbtnAtivoContProg.TabStop = true;
            this.rbtnAtivoContProg.Text = "Ativo";
            this.rbtnAtivoContProg.UseVisualStyleBackColor = true;
            // 
            // rbtnInativoContProg
            // 
            this.rbtnInativoContProg.AutoSize = true;
            this.rbtnInativoContProg.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnInativoContProg.Location = new System.Drawing.Point(499, 10);
            this.rbtnInativoContProg.Name = "rbtnInativoContProg";
            this.rbtnInativoContProg.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.rbtnInativoContProg.Size = new System.Drawing.Size(157, 25);
            this.rbtnInativoContProg.TabIndex = 4;
            this.rbtnInativoContProg.Text = "Inativo";
            this.rbtnInativoContProg.UseVisualStyleBackColor = true;
            // 
            // btnDetalhesContProg
            // 
            this.btnDetalhesContProg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetalhesContProg.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhesContProg.Location = new System.Drawing.Point(656, 10);
            this.btnDetalhesContProg.Margin = new System.Windows.Forms.Padding(20);
            this.btnDetalhesContProg.Name = "btnDetalhesContProg";
            this.btnDetalhesContProg.Size = new System.Drawing.Size(123, 25);
            this.btnDetalhesContProg.TabIndex = 3;
            this.btnDetalhesContProg.Text = "Editar detalhes";
            this.btnDetalhesContProg.UseVisualStyleBackColor = true;
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblConteudo.Location = new System.Drawing.Point(5, 10);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Padding = new System.Windows.Forms.Padding(70, 5, 0, 0);
            this.lblConteudo.Size = new System.Drawing.Size(256, 23);
            this.lblConteudo.TabIndex = 0;
            this.lblConteudo.Text = "Conteúdo Programático";
            // 
            // panelHistorico
            // 
            this.panelHistorico.Controls.Add(this.rbtnAtivoHistorico);
            this.panelHistorico.Controls.Add(this.rbtnInativoHistorico);
            this.panelHistorico.Controls.Add(this.btnDetalhesHistorico);
            this.panelHistorico.Controls.Add(this.lblHistorico);
            this.panelHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHistorico.Location = new System.Drawing.Point(0, 100);
            this.panelHistorico.Name = "panelHistorico";
            this.panelHistorico.Padding = new System.Windows.Forms.Padding(5, 10, 20, 15);
            this.panelHistorico.Size = new System.Drawing.Size(799, 50);
            this.panelHistorico.TabIndex = 2;
            // 
            // rbtnAtivoHistorico
            // 
            this.rbtnAtivoHistorico.AutoSize = true;
            this.rbtnAtivoHistorico.Checked = true;
            this.rbtnAtivoHistorico.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnAtivoHistorico.Location = new System.Drawing.Point(415, 10);
            this.rbtnAtivoHistorico.Name = "rbtnAtivoHistorico";
            this.rbtnAtivoHistorico.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.rbtnAtivoHistorico.Size = new System.Drawing.Size(84, 25);
            this.rbtnAtivoHistorico.TabIndex = 5;
            this.rbtnAtivoHistorico.TabStop = true;
            this.rbtnAtivoHistorico.Text = "Ativo";
            this.rbtnAtivoHistorico.UseVisualStyleBackColor = true;
            // 
            // rbtnInativoHistorico
            // 
            this.rbtnInativoHistorico.AutoSize = true;
            this.rbtnInativoHistorico.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnInativoHistorico.Location = new System.Drawing.Point(499, 10);
            this.rbtnInativoHistorico.Name = "rbtnInativoHistorico";
            this.rbtnInativoHistorico.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.rbtnInativoHistorico.Size = new System.Drawing.Size(157, 25);
            this.rbtnInativoHistorico.TabIndex = 4;
            this.rbtnInativoHistorico.Text = "Inativo";
            this.rbtnInativoHistorico.UseVisualStyleBackColor = true;
            // 
            // btnDetalhesHistorico
            // 
            this.btnDetalhesHistorico.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetalhesHistorico.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhesHistorico.Location = new System.Drawing.Point(656, 10);
            this.btnDetalhesHistorico.Margin = new System.Windows.Forms.Padding(20);
            this.btnDetalhesHistorico.Name = "btnDetalhesHistorico";
            this.btnDetalhesHistorico.Size = new System.Drawing.Size(123, 25);
            this.btnDetalhesHistorico.TabIndex = 3;
            this.btnDetalhesHistorico.Text = "Editar detalhes";
            this.btnDetalhesHistorico.UseVisualStyleBackColor = true;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHistorico.Location = new System.Drawing.Point(5, 10);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Padding = new System.Windows.Forms.Padding(70, 5, 0, 0);
            this.lblHistorico.Size = new System.Drawing.Size(201, 23);
            this.lblHistorico.TabIndex = 0;
            this.lblHistorico.Text = "Histórico Escolar";
            // 
            // panelDeclaracao
            // 
            this.panelDeclaracao.Controls.Add(this.rbtnAtivoDeclaracao);
            this.panelDeclaracao.Controls.Add(this.rbtnInativoDeclaracao);
            this.panelDeclaracao.Controls.Add(this.btnDetalhesDeclaracao);
            this.panelDeclaracao.Controls.Add(this.lblDeclaracao);
            this.panelDeclaracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeclaracao.Location = new System.Drawing.Point(0, 50);
            this.panelDeclaracao.Name = "panelDeclaracao";
            this.panelDeclaracao.Padding = new System.Windows.Forms.Padding(5, 10, 20, 15);
            this.panelDeclaracao.Size = new System.Drawing.Size(799, 50);
            this.panelDeclaracao.TabIndex = 1;
            // 
            // rbtnAtivoDeclaracao
            // 
            this.rbtnAtivoDeclaracao.AutoSize = true;
            this.rbtnAtivoDeclaracao.Checked = true;
            this.rbtnAtivoDeclaracao.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnAtivoDeclaracao.Location = new System.Drawing.Point(415, 10);
            this.rbtnAtivoDeclaracao.Name = "rbtnAtivoDeclaracao";
            this.rbtnAtivoDeclaracao.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.rbtnAtivoDeclaracao.Size = new System.Drawing.Size(84, 25);
            this.rbtnAtivoDeclaracao.TabIndex = 5;
            this.rbtnAtivoDeclaracao.TabStop = true;
            this.rbtnAtivoDeclaracao.Text = "Ativo";
            this.rbtnAtivoDeclaracao.UseVisualStyleBackColor = true;
            // 
            // rbtnInativoDeclaracao
            // 
            this.rbtnInativoDeclaracao.AutoSize = true;
            this.rbtnInativoDeclaracao.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnInativoDeclaracao.Location = new System.Drawing.Point(499, 10);
            this.rbtnInativoDeclaracao.Name = "rbtnInativoDeclaracao";
            this.rbtnInativoDeclaracao.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.rbtnInativoDeclaracao.Size = new System.Drawing.Size(157, 25);
            this.rbtnInativoDeclaracao.TabIndex = 4;
            this.rbtnInativoDeclaracao.Text = "Inativo";
            this.rbtnInativoDeclaracao.UseVisualStyleBackColor = true;
            // 
            // btnDetalhesDeclaracao
            // 
            this.btnDetalhesDeclaracao.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetalhesDeclaracao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhesDeclaracao.Location = new System.Drawing.Point(656, 10);
            this.btnDetalhesDeclaracao.Margin = new System.Windows.Forms.Padding(20);
            this.btnDetalhesDeclaracao.Name = "btnDetalhesDeclaracao";
            this.btnDetalhesDeclaracao.Size = new System.Drawing.Size(123, 25);
            this.btnDetalhesDeclaracao.TabIndex = 3;
            this.btnDetalhesDeclaracao.Text = "Editar detalhes";
            this.btnDetalhesDeclaracao.UseVisualStyleBackColor = true;
            // 
            // lblDeclaracao
            // 
            this.lblDeclaracao.AutoSize = true;
            this.lblDeclaracao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDeclaracao.Location = new System.Drawing.Point(5, 10);
            this.lblDeclaracao.Name = "lblDeclaracao";
            this.lblDeclaracao.Padding = new System.Windows.Forms.Padding(70, 5, 0, 0);
            this.lblDeclaracao.Size = new System.Drawing.Size(337, 23);
            this.lblDeclaracao.TabIndex = 0;
            this.lblDeclaracao.Text = "Declaração de Conclusão de Curso";
            // 
            // panelCertificado
            // 
            this.panelCertificado.Controls.Add(this.rbtnAtivoCertificado);
            this.panelCertificado.Controls.Add(this.rbtnInativoCertificado);
            this.panelCertificado.Controls.Add(this.btnDetalhesCertificado);
            this.panelCertificado.Controls.Add(this.lblCertificado);
            this.panelCertificado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCertificado.Location = new System.Drawing.Point(0, 0);
            this.panelCertificado.Name = "panelCertificado";
            this.panelCertificado.Padding = new System.Windows.Forms.Padding(5, 10, 20, 15);
            this.panelCertificado.Size = new System.Drawing.Size(799, 50);
            this.panelCertificado.TabIndex = 0;
            // 
            // rbtnAtivoCertificado
            // 
            this.rbtnAtivoCertificado.AutoSize = true;
            this.rbtnAtivoCertificado.Checked = true;
            this.rbtnAtivoCertificado.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnAtivoCertificado.Location = new System.Drawing.Point(415, 10);
            this.rbtnAtivoCertificado.Name = "rbtnAtivoCertificado";
            this.rbtnAtivoCertificado.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.rbtnAtivoCertificado.Size = new System.Drawing.Size(84, 25);
            this.rbtnAtivoCertificado.TabIndex = 5;
            this.rbtnAtivoCertificado.TabStop = true;
            this.rbtnAtivoCertificado.Text = "Ativo";
            this.rbtnAtivoCertificado.UseVisualStyleBackColor = true;
            // 
            // rbtnInativoCertificado
            // 
            this.rbtnInativoCertificado.AutoSize = true;
            this.rbtnInativoCertificado.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnInativoCertificado.Location = new System.Drawing.Point(499, 10);
            this.rbtnInativoCertificado.Name = "rbtnInativoCertificado";
            this.rbtnInativoCertificado.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.rbtnInativoCertificado.Size = new System.Drawing.Size(157, 25);
            this.rbtnInativoCertificado.TabIndex = 4;
            this.rbtnInativoCertificado.Text = "Inativo";
            this.rbtnInativoCertificado.UseVisualStyleBackColor = true;
            // 
            // btnDetalhesCertificado
            // 
            this.btnDetalhesCertificado.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDetalhesCertificado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhesCertificado.Location = new System.Drawing.Point(656, 10);
            this.btnDetalhesCertificado.Margin = new System.Windows.Forms.Padding(20);
            this.btnDetalhesCertificado.Name = "btnDetalhesCertificado";
            this.btnDetalhesCertificado.Size = new System.Drawing.Size(123, 25);
            this.btnDetalhesCertificado.TabIndex = 3;
            this.btnDetalhesCertificado.Text = "Editar detalhes";
            this.btnDetalhesCertificado.UseVisualStyleBackColor = true;
            this.btnDetalhesCertificado.Click += new System.EventHandler(this.btnDetalhesCertificado_Click);
            // 
            // lblCertificado
            // 
            this.lblCertificado.AutoSize = true;
            this.lblCertificado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCertificado.Location = new System.Drawing.Point(5, 10);
            this.lblCertificado.Name = "lblCertificado";
            this.lblCertificado.Padding = new System.Windows.Forms.Padding(70, 5, 0, 0);
            this.lblCertificado.Size = new System.Drawing.Size(328, 23);
            this.lblCertificado.TabIndex = 0;
            this.lblCertificado.Text = "Certificado de conclusão de curso";
            // 
            // btnAdicionarRequerimento
            // 
            this.btnAdicionarRequerimento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarRequerimento.Location = new System.Drawing.Point(41, 547);
            this.btnAdicionarRequerimento.Name = "btnAdicionarRequerimento";
            this.btnAdicionarRequerimento.Size = new System.Drawing.Size(143, 42);
            this.btnAdicionarRequerimento.TabIndex = 3;
            this.btnAdicionarRequerimento.Text = "Adicionar Novo Requerimento";
            this.btnAdicionarRequerimento.UseVisualStyleBackColor = true;
            this.btnAdicionarRequerimento.Click += new System.EventHandler(this.btnAdicionarRequerimento_Click);
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 630);
            this.Controls.Add(this.btnAdicionarRequerimento);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Gerenciamento";
            this.Text = "Gerenciamento";
            this.panelPrincipal.ResumeLayout(false);
            this.panelRA.ResumeLayout(false);
            this.panelRA.PerformLayout();
            this.panelContProg.ResumeLayout(false);
            this.panelContProg.PerformLayout();
            this.panelHistorico.ResumeLayout(false);
            this.panelHistorico.PerformLayout();
            this.panelDeclaracao.ResumeLayout(false);
            this.panelDeclaracao.PerformLayout();
            this.panelCertificado.ResumeLayout(false);
            this.panelCertificado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCertificado;
        private System.Windows.Forms.Label lblCertificado;
        private System.Windows.Forms.RadioButton rbtnAtivoCertificado;
        private System.Windows.Forms.RadioButton rbtnInativoCertificado;
        private System.Windows.Forms.Button btnDetalhesCertificado;
        private System.Windows.Forms.Panel panelContProg;
        private System.Windows.Forms.RadioButton rbtnAtivoContProg;
        private System.Windows.Forms.RadioButton rbtnInativoContProg;
        private System.Windows.Forms.Button btnDetalhesContProg;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.Panel panelHistorico;
        private System.Windows.Forms.RadioButton rbtnAtivoHistorico;
        private System.Windows.Forms.RadioButton rbtnInativoHistorico;
        private System.Windows.Forms.Button btnDetalhesHistorico;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Panel panelDeclaracao;
        private System.Windows.Forms.RadioButton rbtnAtivoDeclaracao;
        private System.Windows.Forms.RadioButton rbtnInativoDeclaracao;
        private System.Windows.Forms.Button btnDetalhesDeclaracao;
        private System.Windows.Forms.Label lblDeclaracao;
        private System.Windows.Forms.Button btnAdicionarRequerimento;
        private System.Windows.Forms.Panel panelRA;
        private System.Windows.Forms.RadioButton rbtnAtivoRA;
        private System.Windows.Forms.RadioButton rbtnInativoRA;
        private System.Windows.Forms.Button btnDetalhesRA;
        private System.Windows.Forms.Label lblRA;
    }
}