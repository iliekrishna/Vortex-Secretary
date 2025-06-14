﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretary.Forms
{
    public partial class ResponderSolicitacao : Form
    {
        public string Resposta { get; private set; }

        public ResponderSolicitacao()
        {
            InitializeComponent();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                MessageBox.Show("Digite uma resposta antes de enviar.");
                return;
            }

            Resposta = txtResposta.Text;
            MessageBox.Show("Resposta enviada com sucesso!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
