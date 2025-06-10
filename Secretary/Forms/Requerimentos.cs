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
    public partial class Requerimentos : Form
    {

        public Requerimentos()
        {
            InitializeComponent();
        }

        private void materialExpansionPanel1_CancelClick_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Deseja CANCELAR esta solicitação?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                // Lógica para excluir do banco ou da lista
                MessageBox.Show("Solicitação cancelada com sucesso.");
            }
        }
        private void materialExpansionPanel1_SaveClick(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de detalhes para esta solicitação.");

            var respostaForm = new ResponderSolicitacao();
            if (respostaForm.ShowDialog() == DialogResult.OK)
            {
                string mensagem = respostaForm.Resposta;

                // Aqui você pode salvar no banco ou marcar como respondido
                MessageBox.Show("Mensagem registrada:\n" + mensagem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label16.Text);
            MessageBox.Show("E-mail copiado para a área de transferência!");
        }
    }
}