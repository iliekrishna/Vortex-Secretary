using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Secretary.Models;
using Secretary.DAO;

namespace Secretary.Forms
{
    public partial class EditarDadosSolicitante : Form
    {
        private Requerimento requerimento;

        // Construtor que recebe o objeto Requerimento
        public EditarDadosSolicitante(Requerimento requerimento)
        {
            InitializeComponent();
            this.requerimento = requerimento;
            this.Load += EditarDadosSolicitante_Load;
        }

        private void EditarDadosSolicitante_Load(object sender, EventArgs e)
        {
            // Preencher os campos com os dados do requerimento
            txtNome.Text = requerimento.Nome;
            txtRA.Text = requerimento.RA;
            txtCurso.Text = requerimento.Curso;
            txtCPF.Text = requerimento.CPF;
            txtRG.Text = requerimento.RG;
            txtEmail.Text = requerimento.Email;
            txtTelefone.Text = requerimento.Telefone;
            txtVinculo.Text = requerimento.TipoVinculo;
            

            // Campos que não podem ser editados
            txtVinculo.Enabled = false;
            txtTelefone.Enabled = false;
            
        }

        // Botão salvar (exemplo)
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Atualizar os dados editáveis no objeto
            requerimento.Nome = txtNome.Text.Trim();
            requerimento.RA = txtRA.Text.Trim();
            requerimento.Curso = txtCurso.Text.Trim();
            requerimento.CPF = txtCPF.Text.Trim();
            requerimento.RG = txtRG.Text.Trim();
            requerimento.Email = txtEmail.Text.Trim();

            // Aqui você deve chamar o método para atualizar no banco de dados
            RequerimentoDAO.AtualizarDadosSolicitante(requerimento);

            MessageBox.Show("Dados atualizados com sucesso!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

