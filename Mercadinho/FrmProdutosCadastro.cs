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
    public partial class FrmProdutosCadastro : Form
    {
        public FrmProdutosCadastro(int id, string operacao = "a")
        {
            InitializeComponent();

            PopularSetores();

            if (id != 0)
            {
                Obterproduto(id);
            }

            //visualizar
            if (operacao == "v")
            {
                Text = "Visualizar produto";
                SalvarToolStripButton1.Visible = false;
                TravarFormulario();
            }
            //Excluir
            else if (operacao == "e")
            {
                Text = "Excluir produto";
                SalvarToolStripButton1.Visible = false;
                ExcluirToolStripButton1.Visible = true;
                TravarFormulario();
            }
        }

        private void TravarFormulario()
        {
            txtDescricao.ReadOnly = true;
            txtUn.ReadOnly = true;
            txtValor.ReadOnly = true;
            cmbSetores.Enabled = false;
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

                    //Utiliza o idSetor para encontrar e mostra a descrição do setor
                    cmbSetores.DataSource = listaSetores.ToList();
                    cmbSetores.DisplayMember = "Descricao";
                    cmbSetores.ValueMember = "IdSetor";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar setores.\n" + ex.Message);
            }
        }

        private void Obterproduto(int id)
        {
            //Colocando o id no textBox
            txtId.Text = id.ToString();

            try
            {
                using (var context = new DataContext())
                {
                    //procura no banco o id que foi passado
                    var produto = context.Produtos.Find(id);
                    if (produto != null)
                    {
                        //Senão for nulo os dados serão colocados no Formulário
                        txtDescricao.Text = produto.Descricao;
                        txtUn.Text = produto.Un;
                        txtValor.Text = produto.Valor.ToString("N2");
                        cmbSetores.SelectedValue = produto.IdSetor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar.\n" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SalvarToolStripButton1_Click(object sender, EventArgs e)
        {
            if (Salvar())
                Close();
        }

        private bool Salvar()
        {
            var produto = new Produtos();

            //pega os dados do formulario e adiciona no objeto produto

            produto.Descricao = txtDescricao.Text;
            produto.Un = txtUn.Text;
            produto.Valor = Convert.ToDecimal(txtValor.Text);
            produto.IdSetor = Convert.ToInt32(cmbSetores.SelectedValue);

            try
            {
                using (var context = new DataContext())
                {
                    //Se id = 0 adicionar
                    if (produto.Id == 0)
                    {
                        context.Produtos.Add(produto);
                    }
                    //Se id != 0 Modificar
                    else
                    {
                        context.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                    }

                    //Salva os dados no context
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao enviar.\n" + ex.Message);
                return false;
            }
        }

        private void ExcluirToolStripButton1_Click(object sender, EventArgs e)
        {
            if (Excluir())
            {
                Close();
            }
        }

        private bool Excluir()
        {
            try{
                using(var context = new DataContext())
                {
                    var produto = new Produtos();

                    produto.Id = Convert.ToInt32(txtId.Text);
                    var entry = context.Entry(produto);

                    if(entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        context.Produtos.Attach(produto);
                    }
                    context.Produtos.Remove(produto);
                    context.SaveChanges();
                    return true; 
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Falha ao excluir" + ex.Message);
                return false;
            }

        }
    }
}
