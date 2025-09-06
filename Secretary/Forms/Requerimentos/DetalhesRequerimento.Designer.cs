namespace Secretary.Forms
{
    partial class DetalhesRequerimento
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
            this.btnBaixarMidia = new System.Windows.Forms.Button();
            this.panelDivisor1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtDataPedido = new System.Windows.Forms.TextBox();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.lblTituloDadosSolicitante = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtRespostaEnviada = new System.Windows.Forms.TextBox();
            this.lblMensagemResposta = new System.Windows.Forms.Label();
            this.lblRespondidoPor = new System.Windows.Forms.Label();
            this.lblVinculo = new System.Windows.Forms.Label();
            this.txtVinculo = new System.Windows.Forms.TextBox();
            this.panelDivisor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaixarMidia
            // 
            this.btnBaixarMidia.Location = new System.Drawing.Point(758, 214);
            this.btnBaixarMidia.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixarMidia.Name = "btnBaixarMidia";
            this.btnBaixarMidia.Size = new System.Drawing.Size(145, 28);
            this.btnBaixarMidia.TabIndex = 68;
            this.btnBaixarMidia.Text = "Baixar Mídia";
            this.btnBaixarMidia.UseVisualStyleBackColor = true;
            this.btnBaixarMidia.Click += new System.EventHandler(this.btnBaixarMidia_Click_1);
            // 
            // panelDivisor1
            // 
            this.panelDivisor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor1.Controls.Add(this.label3);
            this.panelDivisor1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDivisor1.Location = new System.Drawing.Point(235, 35);
            this.panelDivisor1.Name = "panelDivisor1";
            this.panelDivisor1.Size = new System.Drawing.Size(700, 1);
            this.panelDivisor1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-94, -9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dados do solicitante";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(41, 178);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 16);
            this.lblStatus.TabIndex = 64;
            this.lblStatus.Text = "Status:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(473, 220);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(61, 16);
            this.lblMotivo.TabIndex = 63;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(17, 220);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(95, 16);
            this.lblDocumento.TabIndex = 62;
            this.lblDocumento.Text = "Documento:";
            // 
            // txtStatus
            // 
            this.txtStatus.ForeColor = System.Drawing.Color.Maroon;
            this.txtStatus.Location = new System.Drawing.Point(106, 175);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(237, 23);
            this.txtStatus.TabIndex = 61;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(541, 217);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(193, 23);
            this.txtMotivo.TabIndex = 60;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(119, 217);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(332, 23);
            this.txtDocumento.TabIndex = 59;
            // 
            // txtDataPedido
            // 
            this.txtDataPedido.Location = new System.Drawing.Point(637, 175);
            this.txtDataPedido.Name = "txtDataPedido";
            this.txtDataPedido.ReadOnly = true;
            this.txtDataPedido.Size = new System.Drawing.Size(202, 23);
            this.txtDataPedido.TabIndex = 58;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(517, 175);
            this.lblDataPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(113, 16);
            this.lblDataPedido.TabIndex = 57;
            this.lblDataPedido.Text = "Data do pedido:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(637, 117);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(298, 23);
            this.txtTelefone.TabIndex = 56;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(561, 117);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 16);
            this.lblTelefone.TabIndex = 55;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(637, 88);
            this.txtRG.Name = "txtRG";
            this.txtRG.ReadOnly = true;
            this.txtRG.Size = new System.Drawing.Size(300, 23);
            this.txtRG.TabIndex = 54;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(600, 88);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(30, 16);
            this.lblRg.TabIndex = 53;
            this.lblRg.Text = "RG:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(637, 59);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(300, 23);
            this.txtCPF.TabIndex = 52;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(592, 59);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 16);
            this.lblCPF.TabIndex = 51;
            this.lblCPF.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(356, 23);
            this.txtEmail.TabIndex = 50;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(45, 146);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 16);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(106, 117);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(356, 23);
            this.txtCurso.TabIndex = 48;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(49, 117);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(50, 16);
            this.lblCurso.TabIndex = 47;
            this.lblCurso.Text = "Curso:";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(106, 88);
            this.txtRA.Name = "txtRA";
            this.txtRA.ReadOnly = true;
            this.txtRA.Size = new System.Drawing.Size(356, 23);
            this.txtRA.TabIndex = 46;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(68, 88);
            this.lblRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(30, 16);
            this.lblRA.TabIndex = 45;
            this.lblRA.Text = "RA:";
            // 
            // lblTituloDadosSolicitante
            // 
            this.lblTituloDadosSolicitante.AutoSize = true;
            this.lblTituloDadosSolicitante.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDadosSolicitante.Location = new System.Drawing.Point(13, 24);
            this.lblTituloDadosSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDadosSolicitante.Name = "lblTituloDadosSolicitante";
            this.lblTituloDadosSolicitante.Size = new System.Drawing.Size(220, 18);
            this.lblTituloDadosSolicitante.TabIndex = 44;
            this.lblTituloDadosSolicitante.Text = "Dados do Requerimento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(356, 23);
            this.txtNome.TabIndex = 43;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(49, 59);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 42;
            this.lblNome.Text = "Nome:";
            // 
            // txtRespostaEnviada
            // 
            this.txtRespostaEnviada.Location = new System.Drawing.Point(145, 262);
            this.txtRespostaEnviada.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespostaEnviada.Multiline = true;
            this.txtRespostaEnviada.Name = "txtRespostaEnviada";
            this.txtRespostaEnviada.ReadOnly = true;
            this.txtRespostaEnviada.Size = new System.Drawing.Size(770, 82);
            this.txtRespostaEnviada.TabIndex = 98;
            // 
            // lblMensagemResposta
            // 
            this.lblMensagemResposta.AutoSize = true;
            this.lblMensagemResposta.Location = new System.Drawing.Point(13, 262);
            this.lblMensagemResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagemResposta.Name = "lblMensagemResposta";
            this.lblMensagemResposta.Size = new System.Drawing.Size(129, 16);
            this.lblMensagemResposta.TabIndex = 39;
            this.lblMensagemResposta.Text = "Resposta enviada:";
            // 
            // lblRespondidoPor
            // 
            this.lblRespondidoPor.AutoSize = true;
            this.lblRespondidoPor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespondidoPor.Location = new System.Drawing.Point(19, 367);
            this.lblRespondidoPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespondidoPor.Name = "lblRespondidoPor";
            this.lblRespondidoPor.Size = new System.Drawing.Size(114, 16);
            this.lblRespondidoPor.TabIndex = 69;
            this.lblRespondidoPor.Text = "Respondido por:";
            // 
            // lblVinculo
            // 
            this.lblVinculo.AutoSize = true;
            this.lblVinculo.Location = new System.Drawing.Point(569, 148);
            this.lblVinculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVinculo.Name = "lblVinculo";
            this.lblVinculo.Size = new System.Drawing.Size(60, 16);
            this.lblVinculo.TabIndex = 100;
            this.lblVinculo.Text = "Vínculo:";
            // 
            // txtVinculo
            // 
            this.txtVinculo.ForeColor = System.Drawing.Color.Maroon;
            this.txtVinculo.Location = new System.Drawing.Point(636, 146);
            this.txtVinculo.Name = "txtVinculo";
            this.txtVinculo.ReadOnly = true;
            this.txtVinculo.Size = new System.Drawing.Size(299, 23);
            this.txtVinculo.TabIndex = 99;
            // 
            // DetalhesRequerimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 408);
            this.Controls.Add(this.lblVinculo);
            this.Controls.Add(this.txtVinculo);
            this.Controls.Add(this.lblRespondidoPor);
            this.Controls.Add(this.btnBaixarMidia);
            this.Controls.Add(this.panelDivisor1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtDataPedido);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.lblTituloDadosSolicitante);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtRespostaEnviada);
            this.Controls.Add(this.lblMensagemResposta);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DetalhesRequerimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do Requerimento";
            this.panelDivisor1.ResumeLayout(false);
            this.panelDivisor1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaixarMidia;
        private System.Windows.Forms.Panel panelDivisor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtDataPedido;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.Label lblTituloDadosSolicitante;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRespostaEnviada;
        private System.Windows.Forms.Label lblMensagemResposta;
        private System.Windows.Forms.Label lblRespondidoPor;
        private System.Windows.Forms.Label lblVinculo;
        private System.Windows.Forms.TextBox txtVinculo;
    }
}