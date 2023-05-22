using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    internal class DataContext : DbContext
    {
        public DataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mercadinho;Integrated Security=True;
                                    Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False") { }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Setores> Setores { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutosMap());
            modelBuilder.Configurations.Add(new ClientesMap());
            modelBuilder.Configurations.Add(new SetoresMap());

        }
    }
}
