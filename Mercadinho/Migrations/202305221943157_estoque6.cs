namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estoque6 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Clientes", name: "Nome", newName: "NomeCliente");
            AlterColumn("dbo.Clientes", "NomeCliente", c => c.String(maxLength: 70, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "NomeCliente", c => c.String());
            RenameColumn(table: "dbo.Clientes", name: "NomeCliente", newName: "Nome");
        }
    }
}
