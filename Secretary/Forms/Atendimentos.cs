using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeuProjeto;




namespace Secretary.Forms
{
    public partial class Atendimentos : Form
    {
        public Atendimentos()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
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

                // Cria e configura o formulário de atendimento centralizado na tela
                FormChatAtendimento chat = new FormChatAtendimento(
                    "Lucas da Silva",
                    "123456",
                    "ADS",
                    "Solicitação de Histórico",
                    "23/05/2025",
                    "Olá, gostaria de saber como solicitar meu histórico escolar."
                );
                chat.StartPosition = FormStartPosition.CenterScreen;
                chat.TopMost = true; // Garante que fique sobre a overlay

                // Mostra o formulário de atendimento
                chat.ShowDialog();

                // Fecha o fundo escurecido após o atendimento
                overlay.Close();
        }
    }
}
