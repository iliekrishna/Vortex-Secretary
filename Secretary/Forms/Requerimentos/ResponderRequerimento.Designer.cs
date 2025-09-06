namespace Secretary.Forms
{
    partial class ResponderRequerimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponderRequerimento));
            this.lblMensagemResposta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTituloDadosSolicitante = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDataPedido = new System.Windows.Forms.TextBox();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelDivisor1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResponder = new System.Windows.Forms.Label();
            this.panelDivisor2 = new System.Windows.Forms.Panel();
            this.lblTituloResponder = new System.Windows.Forms.Label();
            this.btnBaixarMidia = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.btnEnviarDocumento = new System.Windows.Forms.Button();
            this.lblVinculo = new System.Windows.Forms.Label();
            this.txtVinculo = new System.Windows.Forms.TextBox();
            this.panelDivisor1.SuspendLayout();
            this.panelDivisor2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagemResposta
            // 
            this.lblMensagemResposta.AutoSize = true;
            this.lblMensagemResposta.Location = new System.Drawing.Point(13, 336);
            this.lblMensagemResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagemResposta.Name = "lblMensagemResposta";
            this.lblMensagemResposta.Size = new System.Drawing.Size(168, 16);
            this.lblMensagemResposta.TabIndex = 0;
            this.lblMensagemResposta.Text = "Mensagem de Resposta:";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(189, 333);
            this.txtResposta.Margin = new System.Windows.Forms.Padding(4);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(543, 82);
            this.txtResposta.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(740, 381);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(172, 28);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Finalizar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 56);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(356, 23);
            this.txtNome.TabIndex = 5;
            // 
            // lblTituloDadosSolicitante
            // 
            this.lblTituloDadosSolicitante.AutoSize = true;
            this.lblTituloDadosSolicitante.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDadosSolicitante.Location = new System.Drawing.Point(13, 21);
            this.lblTituloDadosSolicitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDadosSolicitante.Name = "lblTituloDadosSolicitante";
            this.lblTituloDadosSolicitante.Size = new System.Drawing.Size(183, 18);
            this.lblTituloDadosSolicitante.TabIndex = 6;
            this.lblTituloDadosSolicitante.Text = "Dados do solicitante";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(98, 85);
            this.txtRA.Name = "txtRA";
            this.txtRA.ReadOnly = true;
            this.txtRA.Size = new System.Drawing.Size(356, 23);
            this.txtRA.TabIndex = 8;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(60, 85);
            this.lblRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(30, 16);
            this.lblRA.TabIndex = 7;
            this.lblRA.Text = "RA:";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(98, 114);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(356, 23);
            this.txtCurso.TabIndex = 10;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(41, 114);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(50, 16);
            this.lblCurso.TabIndex = 9;
            this.lblCurso.Text = "Curso:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(356, 23);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 143);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtDataPedido
            // 
            this.txtDataPedido.Location = new System.Drawing.Point(618, 175);
            this.txtDataPedido.Name = "txtDataPedido";
            this.txtDataPedido.ReadOnly = true;
            this.txtDataPedido.Size = new System.Drawing.Size(202, 23);
            this.txtDataPedido.TabIndex = 20;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(498, 175);
            this.lblDataPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(113, 16);
            this.lblDataPedido.TabIndex = 19;
            this.lblDataPedido.Text = "Data do pedido:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(618, 114);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(299, 23);
            this.txtTelefone.TabIndex = 18;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(542, 115);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 16);
            this.lblTelefone.TabIndex = 17;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(618, 85);
            this.txtRG.Name = "txtRG";
            this.txtRG.ReadOnly = true;
            this.txtRG.Size = new System.Drawing.Size(300, 23);
            this.txtRG.TabIndex = 16;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(581, 85);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(30, 16);
            this.lblRg.TabIndex = 15;
            this.lblRg.Text = "RG:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(618, 56);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(300, 23);
            this.txtCPF.TabIndex = 14;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(573, 57);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 16);
            this.lblCPF.TabIndex = 13;
            this.lblCPF.Text = "CPF:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(109, 221);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(332, 23);
            this.txtDocumento.TabIndex = 21;
            // 
            // txtStatus
            // 
            this.txtStatus.ForeColor = System.Drawing.Color.Maroon;
            this.txtStatus.Location = new System.Drawing.Point(98, 172);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(237, 23);
            this.txtStatus.TabIndex = 23;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(7, 224);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(95, 16);
            this.lblDocumento.TabIndex = 24;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(33, 175);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 16);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status:";
            // 
            // panelDivisor1
            // 
            this.panelDivisor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor1.Controls.Add(this.label3);
            this.panelDivisor1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDivisor1.Location = new System.Drawing.Point(199, 32);
            this.panelDivisor1.Name = "panelDivisor1";
            this.panelDivisor1.Size = new System.Drawing.Size(740, 1);
            this.panelDivisor1.TabIndex = 34;
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
            // lblResponder
            // 
            this.lblResponder.AutoSize = true;
            this.lblResponder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponder.Location = new System.Drawing.Point(13, 295);
            this.lblResponder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponder.Name = "lblResponder";
            this.lblResponder.Size = new System.Drawing.Size(104, 18);
            this.lblResponder.TabIndex = 35;
            this.lblResponder.Text = "Responder";
            // 
            // panelDivisor2
            // 
            this.panelDivisor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivisor2.Controls.Add(this.lblTituloResponder);
            this.panelDivisor2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDivisor2.Location = new System.Drawing.Point(119, 306);
            this.panelDivisor2.Name = "panelDivisor2";
            this.panelDivisor2.Size = new System.Drawing.Size(820, 1);
            this.panelDivisor2.TabIndex = 37;
            // 
            // lblTituloResponder
            // 
            this.lblTituloResponder.AutoSize = true;
            this.lblTituloResponder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResponder.Location = new System.Drawing.Point(-94, -9);
            this.lblTituloResponder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloResponder.Name = "lblTituloResponder";
            this.lblTituloResponder.Size = new System.Drawing.Size(183, 18);
            this.lblTituloResponder.TabIndex = 35;
            this.lblTituloResponder.Text = "Dados do solicitante";
            // 
            // btnBaixarMidia
            // 
            this.btnBaixarMidia.Location = new System.Drawing.Point(740, 221);
            this.btnBaixarMidia.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaixarMidia.Name = "btnBaixarMidia";
            this.btnBaixarMidia.Size = new System.Drawing.Size(140, 28);
            this.btnBaixarMidia.TabIndex = 38;
            this.btnBaixarMidia.Text = "Baixar Mídia";
            this.btnBaixarMidia.UseVisualStyleBackColor = true;
            this.btnBaixarMidia.Click += new System.EventHandler(this.btnBaixarMidia_Click_1);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(530, 222);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(193, 23);
            this.txtMotivo.TabIndex = 22;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(462, 225);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(61, 16);
            this.lblMotivo.TabIndex = 25;
            this.lblMotivo.Text = "Motivo:";
            // 
            // btnEnviarDocumento
            // 
            this.btnEnviarDocumento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarDocumento.Location = new System.Drawing.Point(740, 341);
            this.btnEnviarDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviarDocumento.Name = "btnEnviarDocumento";
            this.btnEnviarDocumento.Size = new System.Drawing.Size(172, 28);
            this.btnEnviarDocumento.TabIndex = 39;
            this.btnEnviarDocumento.Text = "Anexar Documento";
            this.btnEnviarDocumento.UseVisualStyleBackColor = true;
            this.btnEnviarDocumento.Click += new System.EventHandler(this.btnEnviarDocumento_Click);
            // 
            // lblVinculo
            // 
            this.lblVinculo.AutoSize = true;
            this.lblVinculo.Location = new System.Drawing.Point(551, 145);
            this.lblVinculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVinculo.Name = "lblVinculo";
            this.lblVinculo.Size = new System.Drawing.Size(60, 16);
            this.lblVinculo.TabIndex = 41;
            this.lblVinculo.Text = "Vínculo:";
            // 
            // txtVinculo
            // 
            this.txtVinculo.ForeColor = System.Drawing.Color.Maroon;
            this.txtVinculo.Location = new System.Drawing.Point(618, 143);
            this.txtVinculo.Name = "txtVinculo";
            this.txtVinculo.ReadOnly = true;
            this.txtVinculo.Size = new System.Drawing.Size(299, 23);
            this.txtVinculo.TabIndex = 40;
            // 
            // ResponderRequerimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(952, 448);
            this.Controls.Add(this.lblVinculo);
            this.Controls.Add(this.txtVinculo);
            this.Controls.Add(this.btnEnviarDocumento);
            this.Controls.Add(this.btnBaixarMidia);
            this.Controls.Add(this.panelDivisor2);
            this.Controls.Add(this.lblResponder);
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
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblMensagemResposta);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResponderRequerimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responder";
            this.panelDivisor1.ResumeLayout(false);
            this.panelDivisor1.PerformLayout();
            this.panelDivisor2.ResumeLayout(false);
            this.panelDivisor2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagemResposta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTituloDadosSolicitante;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDataPedido;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelDivisor1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResponder;
        private System.Windows.Forms.Panel panelDivisor2;
        private System.Windows.Forms.Label lblTituloResponder;
        private System.Windows.Forms.Button btnBaixarMidia;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button btnEnviarDocumento;
        private System.Windows.Forms.Label lblVinculo;
        private System.Windows.Forms.TextBox txtVinculo;
    }
}