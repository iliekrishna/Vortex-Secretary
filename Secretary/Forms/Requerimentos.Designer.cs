using System.Drawing;
using System.Windows.Forms;

namespace Secretary.Forms
{
    partial class Requerimentos
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.materialExpansionPanel1.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.flowLayoutPanel1);
            this.panelPrincipal.Controls.Add(this.panelFiltros);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrincipal.Location = new System.Drawing.Point(20, 20);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1171, 709);
            this.panelPrincipal.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.materialExpansionPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1171, 649);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.CancelButtonText = "Cancelar";
            this.materialExpansionPanel1.Collapse = true;
            this.materialExpansionPanel1.Controls.Add(this.button1);
            this.materialExpansionPanel1.Controls.Add(this.label16);
            this.materialExpansionPanel1.Controls.Add(this.label15);
            this.materialExpansionPanel1.Controls.Add(this.label14);
            this.materialExpansionPanel1.Controls.Add(this.label13);
            this.materialExpansionPanel1.Controls.Add(this.label12);
            this.materialExpansionPanel1.Controls.Add(this.label11);
            this.materialExpansionPanel1.Controls.Add(this.label17);
            this.materialExpansionPanel1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Description = "Status Atual";
            this.materialExpansionPanel1.ExpandHeight = 341;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(66, 21);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 15);
            this.materialExpansionPanel1.Size = new System.Drawing.Size(618, 48);
            this.materialExpansionPanel1.TabIndex = 2;
            this.materialExpansionPanel1.Title = "Tipo de Documento";
            this.materialExpansionPanel1.ValidationButtonEnable = true;
            this.materialExpansionPanel1.ValidationButtonText = "Responder";
            this.materialExpansionPanel1.SaveClick += new System.EventHandler(this.materialExpansionPanel1_SaveClick);
            this.materialExpansionPanel1.CancelClick += new System.EventHandler(this.materialExpansionPanel1_CancelClick_1);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 21);
            this.button1.TabIndex = 22;
            this.button1.Text = "Copiar e-mail";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 184);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label16.Size = new System.Drawing.Size(217, 24);
            this.label16.TabIndex = 21;
            this.label16.Text = "E-mail: teste@teste.com";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 160);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label15.Size = new System.Drawing.Size(146, 24);
            this.label15.TabIndex = 20;
            this.label15.Text = "RG: 123456789x";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 136);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label14.Size = new System.Drawing.Size(136, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "Curso Logistica";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 112);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label13.Size = new System.Drawing.Size(216, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "Telefone: 11 99999-9999";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 88);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label12.Size = new System.Drawing.Size(176, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "RA: 1234567891069";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 64);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label11.Size = new System.Drawing.Size(186, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nome: Teste da Silva";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Right;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(420, 64);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label17.Size = new System.Drawing.Size(174, 18);
            this.label17.TabIndex = 15;
            this.label17.Text = "Data: 11/11/2011";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFiltros.Controls.Add(this.panel1);
            this.panelFiltros.Controls.Add(this.comboBox1);
            this.panelFiltros.Controls.Add(this.label5);
            this.panelFiltros.Controls.Add(this.comboBox3);
            this.panelFiltros.Controls.Add(this.label8);
            this.panelFiltros.Controls.Add(this.dateTimePicker1);
            this.panelFiltros.Controls.Add(this.label7);
            this.panelFiltros.Controls.Add(this.comboBox2);
            this.panelFiltros.Controls.Add(this.label18);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(15);
            this.panelFiltros.Size = new System.Drawing.Size(1171, 60);
            this.panelFiltros.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(916, 15);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 0, 3, 3);
            this.panel1.Size = new System.Drawing.Size(236, 30);
            this.panel1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(129, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 27);
            this.button2.TabIndex = 24;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(30, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 27);
            this.button3.TabIndex = 23;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mais recente",
            "Mais antigo"});
            this.comboBox1.Location = new System.Drawing.Point(774, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 22);
            this.comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 15);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ordenar por";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Certificado de Conclusão de Curso",
            "Declaração de Conclusão de Curso",
            "Histórico Escolar",
            "Conteúdo Programático",
            "Carteira de Identidade Escolar (RA)"});
            this.comboBox3.Location = new System.Drawing.Point(478, 15);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(186, 22);
            this.comboBox3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 15);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Documento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 15);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data:";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Todos",
            "Em andamento",
            "Finalizado",
            "Cancelado"});
            this.comboBox2.Location = new System.Drawing.Point(81, 15);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 22);
            this.comboBox2.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Left;
            this.label18.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 15);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label18.Size = new System.Drawing.Size(66, 18);
            this.label18.TabIndex = 11;
            this.label18.Text = "Status";
            // 
            // Requerimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 749);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "Requerimentos";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Requerimentos";
            this.panelPrincipal.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelFiltros;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox3;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label18;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private Button button1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label17;
        private Panel panel1;
        private Button button2;
        private Button button3;
    }
}