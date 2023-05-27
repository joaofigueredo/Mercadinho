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
    public partial class FrmProdutosRelatorio : Form
    {
        public FrmProdutosRelatorio()
        {
            InitializeComponent();

            PopularSetores();
        }

        private void cmbSetores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopularSetores()
        {
            try
            {
                using (var context = new DataContext())
                {
                    //lista com os setores do banco
                    var listaSetores = from setores in context.Setores
                                       select setores;

                    var lista = listaSetores.ToList();
                    //Inserir todos os setores (Prepend adiciona no inicio da lista)
                    lista = lista.Prepend(new Setores()
                    {
                        IdSetor = 0,
                        Descricao = "Todos os setores",
                        Produtos = null
                    }).ToList();

                    //Utiliza o idSetor para encontrar e mostra a descrição do setor
                    cmbSetores.DataSource = lista;
                    cmbSetores.DisplayMember = "Descricao";
                    cmbSetores.ValueMember = "IdSetor";
                    //Deixar a aba de setores em branco
                    cmbSetores.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar setores.\n" + ex.Message);
            }
        }

        private void FrmProdutosRelatorio_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            PopularSetores();
        }
    }
}
