using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();

            using(var context = new DataContext())
            {
                dataGridView1.DataSource =  (from Produtos in context.Produtos select Produtos).ToList();

            }
        }
    }
}
