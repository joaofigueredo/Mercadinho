using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public class ProdutosMap : EntityTypeConfiguration<Produtos>
    {
        public ProdutosMap() 
        {
            ToTable("Produtos");
            //Chave primaria
            HasKey(x => x.Id);

            //Chave estrangeira
            HasRequired(x => x.Setor)
                .WithMany(s => s.Produtos)
                .HasForeignKey(s => s.IdSetor)
                .WillCascadeOnDelete(false);


            Property(x => x.Descricao).IsRequired().HasColumnType
                ("varchar").HasMaxLength(70);
            Property(x => x.Un).IsRequired().HasColumnType
                ("varchar").HasMaxLength(3);
            Property(x => x.Valor).HasColumnType("decimal").HasPrecision(10, 2);
            Property(x => x.IdSetor).HasColumnType("int");
        }
    }
}
