using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Un{ get; set; }
        public decimal Valor { get; set; }

        public int IdSetor { get; set; }

        public virtual Setores Setor { get; set; }

        public Produtos(int id, string descricao, string un, decimal valor, int idSetor, string setorDescricao)
        {
            Id = id;
            Descricao = descricao;
            Un = un;
            Valor = valor;
            IdSetor = idSetor;

            var setor = new Setores();
            setor.IdSetor = idSetor;
            setor.Descricao = setorDescricao;

            Setor = setor;


        }

        public Produtos()
        {
        }
    }
}
