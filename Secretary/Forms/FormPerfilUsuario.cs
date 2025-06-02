using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Secretary.Forms
{
    public partial class FormPerfilUsuario : Form
    {
        public FormPerfilUsuario(string nomeUsuario, string email)
        {
            InitializeComponent();
            txtNomeUsuario.Text = nomeUsuario;
            txtLoginUsuario.Text = email;
        }

        private void btnSalvarSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxExibirSenhaAtual_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha com base no checkbox
            txtSenhaAtual.UseSystemPasswordChar = !cboxExibirSenhaAtual.Checked;
        }

        private void cboxExibirNovaSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = !cboxExibirNovaSenha.Checked;
        }

        private void cboxExibirConfirmarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmarSenha.UseSystemPasswordChar = !cboxExibirConfirmarSenha.Checked;
        }
    }
}
