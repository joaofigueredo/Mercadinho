namespace Mercadinho
{
    partial class FrmSetores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetores));
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            AdicionarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            AlterarToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            VisualizarToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ExcluirToolStripButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(801, 392);
            dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { AdicionarToolStripButton, toolStripSeparator1, AlterarToolStripButton, toolStripSeparator2, VisualizarToolStripButton, toolStripSeparator3, ExcluirToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // AdicionarToolStripButton
            // 
            AdicionarToolStripButton.Image = (Image)resources.GetObject("AdicionarToolStripButton.Image");
            AdicionarToolStripButton.ImageTransparentColor = Color.Magenta;
            AdicionarToolStripButton.Name = "AdicionarToolStripButton";
            AdicionarToolStripButton.Size = new Size(97, 24);
            AdicionarToolStripButton.Text = "Adicionar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // AlterarToolStripButton
            // 
            AlterarToolStripButton.Image = (Image)resources.GetObject("AlterarToolStripButton.Image");
            AlterarToolStripButton.ImageTransparentColor = Color.Magenta;
            AlterarToolStripButton.Name = "AlterarToolStripButton";
            AlterarToolStripButton.Size = new Size(78, 24);
            AlterarToolStripButton.Text = "Alterar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // VisualizarToolStripButton
            // 
            VisualizarToolStripButton.Image = (Image)resources.GetObject("VisualizarToolStripButton.Image");
            VisualizarToolStripButton.ImageTransparentColor = Color.Magenta;
            VisualizarToolStripButton.Name = "VisualizarToolStripButton";
            VisualizarToolStripButton.Size = new Size(96, 24);
            VisualizarToolStripButton.Text = "Visualizar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // ExcluirToolStripButton
            // 
            ExcluirToolStripButton.Image = (Image)resources.GetObject("ExcluirToolStripButton.Image");
            ExcluirToolStripButton.ImageTransparentColor = Color.Magenta;
            ExcluirToolStripButton.Name = "ExcluirToolStripButton";
            ExcluirToolStripButton.Size = new Size(76, 24);
            ExcluirToolStripButton.Text = "Excluir";
            // 
            // FrmSetores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Name = "FrmSetores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Setores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton AdicionarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton AlterarToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton VisualizarToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ExcluirToolStripButton;
    }
}