namespace Secretary
{
    partial class FormNovaFaq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaFaq));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.btnNovaCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(32, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 38;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(392, 382);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(144, 29);
            this.btnAdicionar.TabIndex = 39;
            this.btnAdicionar.Text = "Adicionar Pergunta";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // txtResposta
            // 
            this.txtResposta.BackColor = System.Drawing.Color.White;
            this.txtResposta.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtResposta.Location = new System.Drawing.Point(120, 177);
            this.txtResposta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(416, 188);
            this.txtResposta.TabIndex = 37;
            // 
            // txtPergunta
            // 
            this.txtPergunta.BackColor = System.Drawing.Color.White;
            this.txtPergunta.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtPergunta.Location = new System.Drawing.Point(120, 133);
            this.txtPergunta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(416, 23);
            this.txtPergunta.TabIndex = 36;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(34, 177);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(84, 18);
            this.lblResposta.TabIndex = 34;
            this.lblResposta.Text = "Resposta:";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(36, 133);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(81, 18);
            this.lblPergunta.TabIndex = 35;
            this.lblPergunta.Text = "Pergunta:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 23);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Adicionar Nova Pergunta";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(30, 92);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(87, 18);
            this.lblCategoria.TabIndex = 40;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(120, 88);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(287, 24);
            this.cboxCategoria.TabIndex = 41;
            // 
            // btnNovaCategoria
            // 
            this.btnNovaCategoria.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaCategoria.Location = new System.Drawing.Point(422, 88);
            this.btnNovaCategoria.Name = "btnNovaCategoria";
            this.btnNovaCategoria.Size = new System.Drawing.Size(114, 29);
            this.btnNovaCategoria.TabIndex = 42;
            this.btnNovaCategoria.Text = "Nova Categoria";
            this.btnNovaCategoria.UseVisualStyleBackColor = true;
            this.btnNovaCategoria.Click += new System.EventHandler(this.btnNovaCategoria_Click);
            // 
            // FormNovaFaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(610, 423);
            this.Controls.Add(this.btnNovaCategoria);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNovaFaq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovaFaq";
            this.Load += new System.EventHandler(this.FormNovaFaq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Button btnNovaCategoria;
    }
}