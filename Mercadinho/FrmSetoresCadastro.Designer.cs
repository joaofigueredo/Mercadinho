namespace Mercadinho
{
    partial class FrmSetoresCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetoresCadastro));
            toolStrip1 = new ToolStrip();
            SalvarToolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ExcluirToolStripButton1 = new ToolStripButton();
            txtDescricao = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SalvarToolStripButton1, toolStripSeparator1, ExcluirToolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 20;
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
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Location = new Point(151, 90);
            txtDescricao.MaxLength = 70;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(463, 27);
            txtDescricao.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(151, 55);
            txtId.MaxLength = 7;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(151, 27);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 94);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 11;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 59);
            label1.Name = "label1";
            label1.Size = new Size(25, 23);
            label1.TabIndex = 10;
            label1.Text = "Id";
            // 
            // FrmSetoresCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 217);
            Controls.Add(toolStrip1);
            Controls.Add(txtDescricao);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSetoresCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Setores";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton SalvarToolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ExcluirToolStripButton1;
        private TextBox txtDescricao;
        private TextBox txtId;
        private Label label2;
        private Label label1;
    }
}