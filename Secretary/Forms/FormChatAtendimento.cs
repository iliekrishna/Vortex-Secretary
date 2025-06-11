using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SeuProjeto
{
    public partial class FormChatAtendimento : Form
    {
        public FormChatAtendimento(string nome, string ra, string curso, string assunto, string data, string conteudo)
        {
            InitializeComponent();

            lblNome.Text = "Nome: " + nome;
            lblRA.Text = "RA: " + ra;
            lblCurso.Text = "Curso: " + curso;
            lblAssunto.Text = "Assunto: " + assunto;
            lblData.Text = "Data: " + data;
            txtHistorico.Text = "[Aluno]: " + conteudo;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResposta.Text))
            {
                txtHistorico.AppendText(Environment.NewLine + "[Secretaria]: " + txtResposta.Text);
                txtResposta.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dúvida excluída com justificativa.", "Excluir Dúvida");
            this.Close();
        }
    }
}
