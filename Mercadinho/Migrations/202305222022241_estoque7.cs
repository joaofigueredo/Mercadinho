namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estoque7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Setores",
                c => new
                    {
                        IdSetor = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdSetor);
            
            AddColumn("dbo.Produtos", "IdSetor", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "IdSetor");
            DropTable("dbo.Setores");
        }
    }
}
