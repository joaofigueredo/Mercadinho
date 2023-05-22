namespace Mercadinho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estoque3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtos", "Descricao", c => c.String(nullable: false, maxLength: 70, unicode: false));
            AlterColumn("dbo.Produtos", "Valor", c => c.Decimal(nullable: false, precision: 10, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Produtos", "Descricao", c => c.String());
        }
    }
}
