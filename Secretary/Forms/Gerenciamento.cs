using System;
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
    public partial class Gerenciamento : Form
    {
        public Gerenciamento()
        {
            InitializeComponent();
        }

        private void btnDetalhesCertificado_Click(object sender, EventArgs e)
        {
            // Cria o fundo escurecido pegando a tela toda
            Form overlay = new Form();
            overlay.FormBorderStyle = FormBorderStyle.None;
            overlay.BackColor = Color.Black;
            overlay.Opacity = 0.5;
            overlay.StartPosition = FormStartPosition.Manual;
            overlay.Bounds = Screen.PrimaryScreen.Bounds;
            overlay.ShowInTaskbar = false;
            overlay.TopMost = true; // Garante que fique por cima

            // Mostra o fundo escurecido
            overlay.Show();

            FormEditarRequerimento chat = new FormEditarRequerimento(lblCertificado.Text);


            chat.StartPosition = FormStartPosition.CenterScreen;
            chat.TopMost = true; // Garante que fique sobre a overlay

            // Mostra o formulário de atendimento
            chat.ShowDialog();

            // Fecha o fundo escurecido após o atendimento
            overlay.Close();

        }

        private void btnAdicionarRequerimento_Click(object sender, EventArgs e)
        {

        }
    }
}
