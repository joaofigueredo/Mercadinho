namespace Mercadinho
{
    partial class FrmProdutosCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutosCadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtValor = new TextBox();
            txtDescricao = new TextBox();
            txtUn = new TextBox();
            cmbSetores = new ComboBox();
            toolStrip1 = new ToolStrip();
            SalvarToolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ExcluirToolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 90);
            label1.Name = "label1";
            label1.Size = new Size(25, 23);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 125);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 168);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 2;
            label3.Text = "Un. Medida";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 218);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 3;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(69, 266);
            label5.Name = "label5";
            label5.Size = new Size(50, 23);
            label5.TabIndex = 4;
            label5.Text = "Setor";
            label5.Click += label5_Click;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(201, 86);
            txtId.MaxLength = 7;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(151, 27);
            txtId.TabIndex = 5;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            txtValor.BorderStyle = BorderStyle.FixedSingle;
            txtValor.Location = new Point(201, 214);
            txtValor.MaxLength = 9;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(151, 27);
            txtValor.TabIndex = 6;
            txtValor.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Location = new Point(201, 121);
            txtDescricao.MaxLength = 70;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(463, 27);
            txtDescricao.TabIndex = 6;
            // 
            // txtUn
            // 
            txtUn.BorderStyle = BorderStyle.FixedSingle;
            txtUn.CharacterCasing = CharacterCasing.Upper;
            txtUn.Location = new Point(201, 164);
            txtUn.MaxLength = 2;
            txtUn.Name = "txtUn";
            txtUn.Size = new Size(151, 27);
            txtUn.TabIndex = 7;
            txtUn.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbSetores
            // 
            cmbSetores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSetores.FormattingEnabled = true;
            cmbSetores.Location = new Point(201, 261);
            cmbSetores.Name = "cmbSetores";
            cmbSetores.Size = new Size(151, 28);
            cmbSetores.TabIndex = 8;
            cmbSetores.SelectedIndexChanged += cmbSetores_SelectedIndexChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SalvarToolStripButton1, toolStripSeparator1, ExcluirToolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // SalvarToolStripButton1
            // 
            SalvarToolStripButton1.Image = (Image)resources.GetObject("SalvarToolStripButton1.Image");
            SalvarToolStripButton1.ImageTransparentColor = Color.Magenta;
            SalvarToolStripButton1.Name = "SalvarToolStripButton1";
            SalvarToolStripButton1.Size = new Size(73, 24);
            SalvarToolStripButton1.Text = "Salvar";
            SalvarToolStripButton1.Click += SalvarToolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // ExcluirToolStripButton1
            // 
            ExcluirToolStripButton1.Image = (Image)resources.GetObject("ExcluirToolStripButton1.Image");
            ExcluirToolStripButton1.ImageTransparentColor = Color.Magenta;
            ExcluirToolStripButton1.Name = "ExcluirToolStripButton1";
            ExcluirToolStripButton1.Size = new Size(76, 24);
            ExcluirToolStripButton1.Text = "Excluir";
            ExcluirToolStripButton1.Visible = false;
            ExcluirToolStripButton1.Click += ExcluirToolStripButton1_Click;
            // 
            // FrmProdutosCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(cmbSetores);
            Controls.Add(txtUn);
            Controls.Add(txtDescricao);
            Controls.Add(txtValor);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProdutosCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtValor;
        private TextBox txtDescricao;
        private TextBox txtUn;
        private ComboBox cmbSetores;
        private ToolStrip toolStrip1;
        private ToolStripButton SalvarToolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ExcluirToolStripButton1;
    }
}