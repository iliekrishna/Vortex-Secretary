using Secretary.DAO;
using Secretary.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms.Gerenciamento.Documento
{
    public partial class FormAdicionarCampo : Form
    {
        private int _idDocumento;
        private CampoDocumento _campoEditar;
        private bool _modoEdicao = false;

        public FormAdicionarCampo(int idDocumento, CampoDocumento campoEditar = null)
        {
            InitializeComponent();

            _idDocumento = idDocumento;
            _campoEditar = campoEditar;
            _modoEdicao = campoEditar != null;

            comboBox1.SelectedIndexChanged += ComboBoxTipoCampo_SelectedIndexChanged;

            // Configura tamanho inicial
            this.Size = new Size(600, 264);
            panel1.Visible = false;

            if (_modoEdicao)
                CarregarDadosParaEdicao();
        }

        private void CarregarDadosParaEdicao()
        {
            lblTitulo.Text = "Editar Campo";
            btnAdicionar.Text = "Salvar Alterações";

            txtNomeCampo.Text = _campoEditar.NomeCampo;
            chkObrigatorio.Checked = _campoEditar.Obrigatorio;
            comboBox1.SelectedItem = ConverterTipoParaCombo(_campoEditar.TipoCampo);

            // Caso seja seleção, exibir painel e carregar opções
            if (_campoEditar.TipoCampo == "seleção")
            {
                panel1.Visible = true;
                this.Size = new Size(600, 475);
                btnAdicionar.Location = new Point(391, 385);

                // Carrega opções no TextBox (linha por linha)
                CampoDocumentoDAO dao = new CampoDocumentoDAO();
                var opcoes = dao.ListarOpcoes(_campoEditar.IdCampo);

                txtOpcoes.Text = string.Join(Environment.NewLine, opcoes);
            }
        }

        private string ConverterTipoParaCombo(string tipo)
        {
            switch (tipo)
            {
                case "texto": return "Texto";
                case "imagem": return "Imagem"; 
                case "seleção": return "Seleção";
                default: return "Texto";
            }
        }

        private string ConverterComboParaTipo(string combo)
        {
            switch (combo)
            {
                case "Texto": return "texto";
                case "Imagem": return "imagem";
                case "Seleção": return "seleção";
                default: return "texto";
            }
        }

        private void ComboBoxTipoCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = comboBox1.SelectedItem.ToString();

            if (tipoSelecionado == "Seleção")
            {
                panel1.Visible = true;
                this.Size = new Size(600, 475);
                btnAdicionar.Location = new Point(391, 385);
                this.CenterToScreen();

            }
            else
            {
                panel1.Visible = false;
                this.Size = new Size(600, 264);
                btnAdicionar.Location = new Point(395, 189);
                this.CenterToScreen();

            }
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            // =====================
            // VALIDAÇÕES OBRIGATÓRIAS
            // =====================
            string nomeCampo = txtNomeCampo.Text.Trim();
            if (string.IsNullOrEmpty(nomeCampo))
            {
                MessageBox.Show("Digite o nome do campo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCampo.Focus();
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione o tipo do campo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            string tipoCampoSelecionado = comboBox1.SelectedItem.ToString();
            string tipoCampo = ConverterComboParaTipo(tipoCampoSelecionado);

            if (tipoCampo == "seleção")
            {
                string opcoesTexto = txtOpcoes.Text.Trim();
                if (string.IsNullOrEmpty(opcoesTexto))
                {
                    MessageBox.Show("Para o tipo 'Seleção', é obrigatório preencher as opções.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOpcoes.Focus();
                    return;
                }

                // Verifica se há pelo menos uma opção válida (não vazia)
                string[] opcoes = opcoesTexto.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (opcoes.Length == 0)
                {
                    MessageBox.Show("Para o tipo 'Seleção', é obrigatório informar pelo menos uma opção válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOpcoes.Focus();
                    return;
                }
            }

            // =====================
            // PROCESSAMENTO APÓS VALIDAÇÕES
            // =====================
            bool obrigatorio = chkObrigatorio.Checked;
            CampoDocumentoDAO dao = new CampoDocumentoDAO();

            if (_modoEdicao)
            {
                // =====================
                // MODO EDIÇÃO
                // =====================
                dao.RemoverOpcoes(_campoEditar.IdCampo);

                _campoEditar.NomeCampo = nomeCampo;
                _campoEditar.TipoCampo = tipoCampo;
                _campoEditar.Obrigatorio = obrigatorio;

                dao.Atualizar(_campoEditar);

                // Só adicionar opções se o novo tipo for "seleção"
                if (tipoCampo == "seleção")
                {
                    string[] opcoes = txtOpcoes.Text.Split(
                        new[] { "\r\n", "\n" },
                        StringSplitOptions.RemoveEmptyEntries
                    );

                    foreach (var opc in opcoes)
                        dao.AdicionarOpcao(_campoEditar.IdCampo, opc.Trim());
                }

                MessageBox.Show("Campo atualizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                // =====================
                // MODO CRIAÇÃO
                // =====================
                CampoDocumento novo = new CampoDocumento
                {
                    IdDocumento = _idDocumento,
                    NomeCampo = nomeCampo,
                    TipoCampo = tipoCampo,
                    Obrigatorio = obrigatorio
                };

                int idCampoCriado = dao.Inserir(novo);

                if (tipoCampo == "seleção")
                {
                    string[] opcoes = txtOpcoes.Text.Split(
                        new[] { "\r\n", "\n" },
                        StringSplitOptions.RemoveEmptyEntries
                    );

                    foreach (var opc in opcoes)
                        dao.AdicionarOpcao(idCampoCriado, opc.Trim());
                }

                MessageBox.Show("Campo adicionado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
