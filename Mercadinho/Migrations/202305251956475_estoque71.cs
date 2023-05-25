namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estoque71 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Produtos", "IdSetor");
            AddForeignKey("dbo.Produtos", "IdSetor", "dbo.Setores", "IdSetor");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "IdSetor", "dbo.Setores");
            DropIndex("dbo.Produtos", new[] { "IdSetor" });
        }
    }
}
