namespace Secretary.Forms
{
    partial class FormEditarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarDocumento));
            this.chbPagamentoTaxa = new System.Windows.Forms.CheckBox();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtnInativo = new System.Windows.Forms.RadioButton();
            this.rbtnAtivo = new System.Windows.Forms.RadioButton();
            this.lblNumID = new System.Windows.Forms.Label();
            this.lblNomeRequerimento = new System.Windows.Forms.Label();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeRequerimento = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbTipoGratuidade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbPagamentoTaxa
            // 
            this.chbPagamentoTaxa.AutoSize = true;
            this.chbPagamentoTaxa.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamentoTaxa.Location = new System.Drawing.Point(27, 210);
            this.chbPagamentoTaxa.Name = "chbPagamentoTaxa";
            this.chbPagamentoTaxa.Size = new System.Drawing.Size(444, 22);
            this.chbPagamentoTaxa.TabIndex = 85;
            this.chbPagamentoTaxa.Text = "Necessário pagamento de taxa em caso de segunda via";
            this.chbPagamentoTaxa.UseVisualStyleBackColor = true;
            // 
            // panelDivisor
            // 
            this.panelDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor.Location = new System.Drawing.Point(27, 48);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(200, 1);
            this.panelDivisor.TabIndex = 75;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(23, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(204, 23);
            this.lblTitulo.TabIndex = 76;
            this.lblTitulo.Text = "Editar Documento";
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Location = new System.Drawing.Point(279, 165);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(71, 20);
            this.rbtnInativo.TabIndex = 77;
            this.rbtnInativo.Text = "Inativo";
            // 
            // rbtnAtivo
            // 
            this.rbtnAtivo.AutoSize = true;
            this.rbtnAtivo.Checked = true;
            this.rbtnAtivo.Location = new System.Drawing.Point(209, 165);
            this.rbtnAtivo.Name = "rbtnAtivo";
            this.rbtnAtivo.Size = new System.Drawing.Size(59, 20);
            this.rbtnAtivo.TabIndex = 78;
            this.rbtnAtivo.TabStop = true;
            this.rbtnAtivo.Text = "Ativo";
            // 
            // lblNumID
            // 
            this.lblNumID.AutoSize = true;
            this.lblNumID.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNumID.Location = new System.Drawing.Point(135, 164);
            this.lblNumID.Name = "lblNumID";
            this.lblNumID.Size = new System.Drawing.Size(63, 18);
            this.lblNumID.TabIndex = 79;
            this.lblNumID.Text = "Status:";
            // 
            // lblNomeRequerimento
            // 
            this.lblNomeRequerimento.AutoSize = true;
            this.lblNomeRequerimento.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblNomeRequerimento.Location = new System.Drawing.Point(23, 78);
            this.lblNomeRequerimento.Name = "lblNomeRequerimento";
            this.lblNomeRequerimento.Size = new System.Drawing.Size(174, 18);
            this.lblNomeRequerimento.TabIndex = 81;
            this.lblNomeRequerimento.Text = "Nome do documento:";
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(204, 118);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(149, 23);
            this.txtPrazo.TabIndex = 82;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnSalvar.Location = new System.Drawing.Point(403, 312);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(166, 28);
            this.btnSalvar.TabIndex = 83;
            this.btnSalvar.Text = "Salvar Alteração";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeRequerimento
            // 
            this.txtNomeRequerimento.Location = new System.Drawing.Point(204, 78);
            this.txtNomeRequerimento.Name = "txtNomeRequerimento";
            this.txtNomeRequerimento.Size = new System.Drawing.Size(343, 23);
            this.txtNomeRequerimento.TabIndex = 84;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblDescricao.Location = new System.Drawing.Point(18, 119);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(180, 18);
            this.lblDescricao.TabIndex = 86;
            this.lblDescricao.Text = "Prazo de atendimento:";
            // 
            // cbTipoGratuidade
            // 
            this.cbTipoGratuidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoGratuidade.Enabled = false;
            this.cbTipoGratuidade.FormattingEnabled = true;
            this.cbTipoGratuidade.Items.AddRange(new object[] {
            "Nenhuma",
            "Curso",
            "Período letivo"});
            this.cbTipoGratuidade.Location = new System.Drawing.Point(204, 254);
            this.cbTipoGratuidade.Name = "cbTipoGratuidade";
            this.cbTipoGratuidade.Size = new System.Drawing.Size(234, 24);
            this.cbTipoGratuidade.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label1.Location = new System.Drawing.Point(33, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 87;
            this.label1.Text = "Limite de gratuidade:";
            // 
            // FormEditarDocumento
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(595, 358);
            this.Controls.Add(this.cbTipoGratuidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.chbPagamentoTaxa);
            this.Controls.Add(this.panelDivisor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.rbtnInativo);
            this.Controls.Add(this.rbtnAtivo);
            this.Controls.Add(this.lblNumID);
            this.Controls.Add(this.lblNomeRequerimento);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeRequerimento);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbPagamentoTaxa;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtnInativo;
        private System.Windows.Forms.RadioButton rbtnAtivo;
        private System.Windows.Forms.Label lblNumID;
        private System.Windows.Forms.Label lblNomeRequerimento;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeRequerimento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbTipoGratuidade;
        private System.Windows.Forms.Label label1;
    }
}
