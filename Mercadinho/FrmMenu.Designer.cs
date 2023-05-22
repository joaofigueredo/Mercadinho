namespace Mercadinho
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSetores = new Button();
            btnProdutos = new Button();
            SuspendLayout();
            // 
            // btnSetores
            // 
            btnSetores.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetores.Location = new Point(298, 138);
            btnSetores.Name = "btnSetores";
            btnSetores.Size = new Size(94, 29);
            btnSetores.TabIndex = 0;
            btnSetores.Text = "Setores";
            btnSetores.UseVisualStyleBackColor = true;
            btnSetores.Click += button1_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProdutos.Location = new Point(298, 207);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(94, 29);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProdutos);
            Controls.Add(btnSetores);
            Name = "FrmMenu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSetores;
        private Button btnProdutos;
    }
}