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
    public partial class FrmSetoresCadastro : Form
    {
        public FrmSetoresCadastro(int id, string operacao = "a")
        {
            InitializeComponent();

            if (id != 0)
            {
                ObterSetor(id);
            }

            //visualizar
            if (operacao == "v")
            {
                Text = "Visualizar setor";
                SalvarToolStripButton1.Visible = false;
                TravarFormulario();
            }
            //Excluir
            else if (operacao == "e")
            {
                Text = "Excluir setor";
                SalvarToolStripButton1.Visible = false;
                ExcluirToolStripButton1.Visible = true;
                TravarFormulario();
            }
        }

        private void TravarFormulario()
        {
            txtId.ReadOnly = true;
            txtDescricao.ReadOnly = true;
        }

        private void ObterSetor(int id)
        {
            //Colocando o id no textBox
            txtId.Text = id.ToString();

            try
            {
                using (var context = new DataContext())
                {
                    //procura no banco o id que foi passado
                    var setor = context.Setores.Find(id);
                    if (setor != null)
                    {
                        //Senão for nulo os dados serão colocados no Formulário
                        txtDescricao.Text = setor.Descricao;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar o setor.\n" + ex.Message);
            }
        }
        private void SalvarToolStripButton1_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                Close();
            }
        }
        private bool Salvar()
        {
            var setor = new Setores();

            //pega os dados do formulario e adiciona no objeto produto

            setor.IdSetor = Convert.ToInt32("0" + txtId.Text);
            setor.Descricao = txtDescricao.Text;

            try
            {
                using (var context = new DataContext())
                {
                    //Se id = 0 adicionar
                    if (setor.IdSetor == 0)
                    {
                        context.Setores.Add(setor);
                    }
                    //Se id != 0 Modificar
                    else
                    {
                        context.Entry(setor).State = System.Data.Entity.EntityState.Modified;
                    }

                    //Salva os dados no context
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar setor.\n" + ex.Message);
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
            try
            {
                using (var context = new DataContext())
                {
                    var setor = new Setores();

                    setor.IdSetor = Convert.ToInt32(txtId.Text);
                    var entry = context.Entry(setor);

                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        context.Setores.Attach(setor);
                    }
                    context.Setores.Remove(setor);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
              
                if(ex.HResult == -2146233087)
                {
                    MessageBox.Show("Falha ao excluir o setor.\n setor está sendo usado em produtos.");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir setor." + ex.Message);
                }

                return false;
            }
        }
    }
}
