using Mercadinho;

namespace Mercadinho
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmSetores())
            {
                frm.ShowDialog();
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmProdutos())
            {
                frm.ShowDialog();
            }
        }
    }
}
