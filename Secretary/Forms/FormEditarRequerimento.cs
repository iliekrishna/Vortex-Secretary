using SeuProjeto;
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
    public partial class FormEditarRequerimento : Form
    {
        public FormEditarRequerimento(String nomeRequerimento)
        {
            InitializeComponent();

            txtNomeRequerimento.Text = nomeRequerimento;
            txtPrazo.Text = "2 dias úteis (EXEMPLO)";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
