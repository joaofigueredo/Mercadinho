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
    public partial class FrmSetores : Form
    {
        public FrmSetores()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from Setores in context.Setores select Setores).ToList();
            }

            ConfigurarGrade();
        }

        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);
            

            dataGridView1.Columns["idSetor"].HeaderText = "Id do Setor";
            dataGridView1.Columns["idSetor"].Width = 80;
            dataGridView1.Columns["idSetor"].HeaderCell.Style.Alignment = 
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["idSetor"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["descricao"].Width = 250;
        }
    }
}
