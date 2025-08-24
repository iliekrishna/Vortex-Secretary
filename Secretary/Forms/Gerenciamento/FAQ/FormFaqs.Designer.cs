namespace Secretary.Forms.Gerenciamento.FAQ
{
    partial class FormFaqs
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
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.btnEditarNome = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.flowLayoutPanelPerguntas = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnAdicionarNovaPergunta = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeCategoria.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(12, 32);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(492, 31);
            this.txtNomeCategoria.TabIndex = 87;
            // 
            // btnEditarNome
            // 
            this.btnEditarNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarNome.Location = new System.Drawing.Point(520, 32);
            this.btnEditarNome.Name = "btnEditarNome";
            this.btnEditarNome.Size = new System.Drawing.Size(110, 31);
            this.btnEditarNome.TabIndex = 7;
            this.btnEditarNome.Text = "Editar Nome";
            this.btnEditarNome.UseVisualStyleBackColor = true;
            this.btnEditarNome.Click += new System.EventHandler(this.btnEditarNome_Click_1);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.btnExcluirCategoria);
            this.panelSuperior.Controls.Add(this.txtNomeCategoria);
            this.panelSuperior.Controls.Add(this.btnEditarNome);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(784, 100);
            this.panelSuperior.TabIndex = 3;
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluirCategoria.Location = new System.Drawing.Point(636, 32);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(131, 31);
            this.btnExcluirCategoria.TabIndex = 80;
            this.btnExcluirCategoria.Text = "Excluir Categoria";
            this.btnExcluirCategoria.UseVisualStyleBackColor = true;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // flowLayoutPanelPerguntas
            // 
            this.flowLayoutPanelPerguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPerguntas.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanelPerguntas.Name = "flowLayoutPanelPerguntas";
            this.flowLayoutPanelPerguntas.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowLayoutPanelPerguntas.Size = new System.Drawing.Size(784, 461);
            this.flowLayoutPanelPerguntas.TabIndex = 1;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnAdicionarNovaPergunta);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 488);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(784, 73);
            this.panelInferior.TabIndex = 89;
            // 
            // btnAdicionarNovaPergunta
            // 
            this.btnAdicionarNovaPergunta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarNovaPergunta.Location = new System.Drawing.Point(588, 19);
            this.btnAdicionarNovaPergunta.Name = "btnAdicionarNovaPergunta";
            this.btnAdicionarNovaPergunta.Size = new System.Drawing.Size(179, 33);
            this.btnAdicionarNovaPergunta.TabIndex = 1;
            this.btnAdicionarNovaPergunta.Text = "Adicionar Nova Pergunta";
            this.btnAdicionarNovaPergunta.UseVisualStyleBackColor = true;
            this.btnAdicionarNovaPergunta.Click += new System.EventHandler(this.btnAdicionarNovaPergunta_Click);
            // 
            // FormFaqs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.flowLayoutPanelPerguntas);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormFaqs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar FAQ";
            this.Load += new System.EventHandler(this.FormFaqs_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Button btnEditarNome;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPerguntas;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnAdicionarNovaPergunta;
    }
}