
namespace Secretary.Forms.Gerenciamento
{
    partial class FormNovoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoDocumento));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeDoc = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNomeDoc = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(23, 26);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 23);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Adicionar Novo Documento";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(219, 137);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(140, 23);
            this.txtDescricao.TabIndex = 28;
            // 
            // txtNomeDoc
            // 
            this.txtNomeDoc.BackColor = System.Drawing.Color.White;
            this.txtNomeDoc.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNomeDoc.Location = new System.Drawing.Point(219, 93);
            this.txtNomeDoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNomeDoc.Name = "txtNomeDoc";
            this.txtNomeDoc.Size = new System.Drawing.Size(354, 23);
            this.txtNomeDoc.TabIndex = 27;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(36, 137);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(180, 18);
            this.lblDescricao.TabIndex = 24;
            this.lblDescricao.Text = "Prazo de atendimento:";
            // 
            // lblNomeDoc
            // 
            this.lblNomeDoc.AutoSize = true;
            this.lblNomeDoc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoc.Location = new System.Drawing.Point(38, 93);
            this.lblNomeDoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomeDoc.Name = "lblNomeDoc";
            this.lblNomeDoc.Size = new System.Drawing.Size(176, 18);
            this.lblNomeDoc.TabIndex = 26;
            this.lblNomeDoc.Text = "Nome do Documento:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(407, 184);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(166, 29);
            this.btnAdicionar.TabIndex = 32;
            this.btnAdicionar.Text = "Adicionar Documento";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(25, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 31;
            // 
            // FormNovoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(610, 234);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNomeDoc);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeDoc);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNovoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeDoc;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNomeDoc;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel3;
    }
}