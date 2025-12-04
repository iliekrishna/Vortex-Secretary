using Secretary.Models;
using Secretary.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms.Gerenciamento
{
    public partial class FormNovoDocumento : Form
    {
        public FormNovoDocumento()
        {
            InitializeComponent();

            // Eventos
            rdbSim.CheckedChanged += RdbSim_CheckedChanged;
            rdbNao.CheckedChanged += RdbNao_CheckedChanged;

            // Inicia ocultando o painel
            panelCampoImagem.Visible = false;
        }

        private void RdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked)
            {
                this.Size = new Size(610, 470);
                panelCampoImagem.Visible = true;
                btnAdicionar.Location = new Point(396, 380);
            }
        }

        private void RdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked)
            {
                this.Size = new Size(610, 310);
                panelCampoImagem.Visible = false;
                btnAdicionar.Location = new Point(396, 225);
            }
        }
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNomeDoc.Text.Trim();
            string descricao = txtDescricao.Text.Trim();

            DocumentoDAO dao = new DocumentoDAO();

            if (dao.ExisteDocumento(nome))
            {
                MessageBox.Show("Já existe um documento com esse nome.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Preencha todos os campos.",
                    "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Salvando documento
                DocumentoDisponivel novoDoc = new DocumentoDisponivel
                {
                    Nome = nome,
                    Descricao = descricao,
                    NecessitaImagem = rdbSim.Checked,
                    StatusAtual = "Disponível"
                };

                dao.Inserir(novoDoc);

                int idNovo = dao.ObterUltimoIdInserido();

                // Se tiver campo de imagem, salva campo também
                if (rdbSim.Checked)
                {
                    CampoDocumentoDAO cdao = new CampoDocumentoDAO();

                    CampoDocumento campo = new CampoDocumento
                    {
                        IdDocumento = idNovo,
                        NomeCampo = txtNomeCampo.Text.Trim(),
                        TipoCampo = "img",
                        Obrigatorio = chkObrigatorio.Checked
                    };

                    cdao.Inserir(campo);
                }

                MessageBox.Show("Documento adicionado com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
