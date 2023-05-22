using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class SetoresMap : EntityTypeConfiguration<Setores>
    {
        public SetoresMap()
        {
            ToTable("Setores");
            HasKey(x => x.IdSetor);
            Property(x => x.Descricao).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
