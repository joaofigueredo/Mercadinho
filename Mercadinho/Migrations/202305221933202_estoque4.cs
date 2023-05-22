namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estoque4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "Un", c => c.String(nullable: false, maxLength: 3, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "Un");
        }
    }
}
