namespace Mercadinho
{
    partial class FrmProdutosRelatorio
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
            btnGerarRelatorio = new Button();
            cmbSetores = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerarRelatorio.Location = new Point(189, 209);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(272, 29);
            btnGerarRelatorio.TabIndex = 3;
            btnGerarRelatorio.Text = "Gerar relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // cmbSetores
            // 
            cmbSetores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSetores.FormattingEnabled = true;
            cmbSetores.Location = new Point(267, 135);
            cmbSetores.Name = "cmbSetores";
            cmbSetores.Size = new Size(194, 28);
            cmbSetores.TabIndex = 10;
            cmbSetores.SelectedIndexChanged += cmbSetores_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(189, 135);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 9;
            label5.Text = "Setor";
            // 
            // FrmProdutosRelatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSetores);
            Controls.Add(label5);
            Controls.Add(btnGerarRelatorio);
            Name = "FrmProdutosRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório de produtos";
            Shown += FrmProdutosRelatorio_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGerarRelatorio;
        private ComboBox cmbSetores;
        private Label label5;
    }
}