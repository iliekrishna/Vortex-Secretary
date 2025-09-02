using System;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;
using Secretary.DAO;
using Secretary.Models;

namespace Secretary.Forms.Requerimentos
{
    public partial class DetalhesRequerimento : Form
    {
        private int idRequerimento;

        public DetalhesRequerimento(int idRequerimento)
        {
            InitializeComponent();
            this.idRequerimento = idRequerimento;
            this.Load += DetalhesRequerimento_Load;
        }

        private void DetalhesRequerimento_Load(object sender, EventArgs e)
        { /*
            try
            {
                // Busca os dados do requerimento pelo ID
                Requerimento r = RequerimentoDAO.BuscarPorId(idRequerimento);
                if (r == null)
                {
                    MessageBox.Show("Requerimento não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Exemplo: preencha controles do formulário com os dados do requerimento
                lblNome.Text = r.Nome;
                lblRA.Text = r.RA;
                lblCurso.Text = r.Curso;
                lblDocumento.Text = r.NomeDocumento;
                lblStatus.Text = r.StatusDocumento;
                lblDataPedido.Text = r.DataPedido?.ToString("dd/MM/yyyy HH:mm") ?? "";
                lblDataResposta.Text = r.DataResposta?.ToString("dd/MM/yyyy HH:mm") ?? "";
                txtResposta.Text = r.Resposta ?? "";

                // Se tiver um label ou textbox para mostrar quem respondeu:
                lblUsuarioResposta.Text = r.IdUsuario.HasValue ? $"Respondido por usuário ID: {r.IdUsuario}" : "Sem resposta ainda";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}