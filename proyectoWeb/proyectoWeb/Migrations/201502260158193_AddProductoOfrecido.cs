namespace proyectoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductoOfrecido : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transaccions", "ProductoOfrecidoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transaccions", "ProductoOfrecidoId");
            AddForeignKey("dbo.Transaccions", "ProductoOfrecidoId", "dbo.Productoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaccions", "ProductoOfrecidoId", "dbo.Productoes");
            DropIndex("dbo.Transaccions", new[] { "ProductoOfrecidoId" });
            DropColumn("dbo.Transaccions", "ProductoOfrecidoId");
        }
    }
}
