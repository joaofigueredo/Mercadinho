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

            using (var context = new DataContext())
            {
                //dataGridView1.DataSource =  (from Produtos in context.Produtos select Produtos).ToList();

                var lista = from produtos in context.Produtos
                            join setores in context.Setores
                            on produtos.IdSetor equals setores.IdSetor
                            into produtosGrupo
                            from setores in produtosGrupo.DefaultIfEmpty()
                            select new { setores, produtos };

                ConfigurarGrade();

                foreach (var item in lista)
                {
                    dataGridView1.Rows.Add(item.produtos.Id, item.produtos.Descricao, item.produtos.Un,
                            item.produtos.Valor.ToString("N2"), item.produtos.IdSetor, item.setores.Descricao);
                }

            }


        }

        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);


            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns["id"].Width = 80;
            dataGridView1.Columns["id"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["id"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("descricao", "Descrição");
            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["descricao"].Width = 250;

            dataGridView1.Columns.Add("Un", "Un");
            dataGridView1.Columns["Un"].Width = 50;
            dataGridView1.Columns["Un"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Un"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("Valor", "Valor");
            dataGridView1.Columns["Valor"].Width = 90;
            dataGridView1.Columns["Valor"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Valor"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("idSetor", "Id Setor");
            dataGridView1.Columns["idSetor"].Width = 80;
            dataGridView1.Columns["idSetor"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["idSetor"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns.Add("descricaoSeetor", "Descrição do Setor");
            dataGridView1.Columns["descricaoSeetor"].Width = 250;
        }

        private void AlterarToolStripButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new FrmProdutosCadastro(id))
            {
                frm.ShowDialog();
            }
        }

        private void AdicionarToolStripButton_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var frm = new FrmProdutosCadastro(id))
            {
                frm.ShowDialog();
            }
        }

        private void VisualizarToolStripButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new FrmProdutosCadastro(id, "v"))
            {
                frm.ShowDialog();
            }
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            using (var frm = new FrmProdutosCadastro(id, "e"))
            {
                frm.ShowDialog();
            }
        }
    }
}
