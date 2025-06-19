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
    }
}
