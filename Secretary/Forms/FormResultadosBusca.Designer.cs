namespace Secretary.Forms
{
    partial class FormResultadosBusca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblTermoBusca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTotalResultados = new System.Windows.Forms.Label();
            this.lblContUsuarios = new System.Windows.Forms.Label();
            this.lblContAtendimentos = new System.Windows.Forms.Label();
            this.lblContRequerimentos = new System.Windows.Forms.Label();
            this.cmbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfoAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDicaDoubleClick = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTopo.Controls.Add(this.lblTermoBusca);
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(900, 70);
            this.panelTopo.TabIndex = 0;
            // 
            // lblTermoBusca
            // 
            this.lblTermoBusca.AutoSize = true;
            this.lblTermoBusca.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermoBusca.ForeColor = System.Drawing.Color.White;
            this.lblTermoBusca.Location = new System.Drawing.Point(20, 42);
            this.lblTermoBusca.Name = "lblTermoBusca";
            this.lblTermoBusca.Size = new System.Drawing.Size(150, 17);
            this.lblTermoBusca.TabIndex = 1;
            this.lblTermoBusca.Text = "Resultados para: \"\"";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Resultados da Busca";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelFiltros.Controls.Add(this.btnFechar);
            this.panelFiltros.Controls.Add(this.lblTotalResultados);
            this.panelFiltros.Controls.Add(this.lblContUsuarios);
            this.panelFiltros.Controls.Add(this.lblContAtendimentos);
            this.panelFiltros.Controls.Add(this.lblContRequerimentos);
            this.panelFiltros.Controls.Add(this.cmbFiltroTipo);
            this.panelFiltros.Controls.Add(this.lblFiltro);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 70);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(900, 50);
            this.panelFiltros.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(810, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 30);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTotalResultados
            // 
            this.lblTotalResultados.AutoSize = true;
            this.lblTotalResultados.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalResultados.Location = new System.Drawing.Point(620, 17);
            this.lblTotalResultados.Name = "lblTotalResultados";
            this.lblTotalResultados.Size = new System.Drawing.Size(106, 14);
            this.lblTotalResultados.TabIndex = 5;
            this.lblTotalResultados.Text = "Total: 0 resultado(s)";
            // 
            // lblContUsuarios
            // 
            this.lblContUsuarios.AutoSize = true;
            this.lblContUsuarios.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblContUsuarios.Location = new System.Drawing.Point(500, 18);
            this.lblContUsuarios.Name = "lblContUsuarios";
            this.lblContUsuarios.Size = new System.Drawing.Size(74, 13);
            this.lblContUsuarios.TabIndex = 4;
            this.lblContUsuarios.Text = "Usuários: 0";
            // 
            // lblContAtendimentos
            // 
            this.lblContAtendimentos.AutoSize = true;
            this.lblContAtendimentos.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContAtendimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblContAtendimentos.Location = new System.Drawing.Point(370, 18);
            this.lblContAtendimentos.Name = "lblContAtendimentos";
            this.lblContAtendimentos.Size = new System.Drawing.Size(104, 13);
            this.lblContAtendimentos.TabIndex = 3;
            this.lblContAtendimentos.Text = "Atendimentos: 0";
            // 
            // lblContRequerimentos
            // 
            this.lblContRequerimentos.AutoSize = true;
            this.lblContRequerimentos.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContRequerimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblContRequerimentos.Location = new System.Drawing.Point(230, 18);
            this.lblContRequerimentos.Name = "lblContRequerimentos";
            this.lblContRequerimentos.Size = new System.Drawing.Size(110, 13);
            this.lblContRequerimentos.TabIndex = 2;
            this.lblContRequerimentos.Text = "Requerimentos: 0";
            // 
            // cmbFiltroTipo
            // 
            this.cmbFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTipo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroTipo.FormattingEnabled = true;
            this.cmbFiltroTipo.Items.AddRange(new object[] {
            "Todos",
            "Requerimento",
            "Atendimento",
            "Usuário"});
            this.cmbFiltroTipo.Location = new System.Drawing.Point(80, 14);
            this.cmbFiltroTipo.Name = "cmbFiltroTipo";
            this.cmbFiltroTipo.Size = new System.Drawing.Size(130, 22);
            this.cmbFiltroTipo.TabIndex = 1;
            this.cmbFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroTipo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(20, 18);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(52, 14);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtrar:";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipo,
            this.colTitulo,
            this.colDescricao,
            this.colStatus,
            this.colData,
            this.colInfoAdicional,
            this.colId});
            this.dgvResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvResultados.Location = new System.Drawing.Point(0, 120);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(900, 400);
            this.dgvResultados.TabIndex = 2;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 100;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "Nome";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Width = 180;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 200;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 90;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 120;
            // 
            // colInfoAdicional
            // 
            this.colInfoAdicional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInfoAdicional.HeaderText = "Informações Adicionais";
            this.colInfoAdicional.Name = "colInfoAdicional";
            this.colInfoAdicional.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // lblDicaDoubleClick
            // 
            this.lblDicaDoubleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDicaDoubleClick.AutoSize = true;
            this.lblDicaDoubleClick.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDicaDoubleClick.ForeColor = System.Drawing.Color.Gray;
            this.lblDicaDoubleClick.Location = new System.Drawing.Point(12, 528);
            this.lblDicaDoubleClick.Name = "lblDicaDoubleClick";
            this.lblDicaDoubleClick.Size = new System.Drawing.Size(282, 13);
            this.lblDicaDoubleClick.TabIndex = 3;
            this.lblDicaDoubleClick.Text = "Dê um duplo clique em um item para ver detalhes";
            // 
            // FormResultadosBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lblDicaDoubleClick);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResultadosBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados da Busca";
            this.Load += new System.EventHandler(this.FormResultadosBusca_Load);
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTermoBusca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.ComboBox cmbFiltroTipo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblContRequerimentos;
        private System.Windows.Forms.Label lblContAtendimentos;
        private System.Windows.Forms.Label lblContUsuarios;
        private System.Windows.Forms.Label lblTotalResultados;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfoAdicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.Label lblDicaDoubleClick;
    }
}
