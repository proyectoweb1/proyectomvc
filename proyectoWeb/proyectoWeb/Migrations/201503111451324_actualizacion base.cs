namespace proyectoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacionbase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transaccions", "ProductoCambioId", c => c.Int(nullable: false));
            AddColumn("dbo.Transaccions", "Comentario", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transaccions", "Comentario");
            DropColumn("dbo.Transaccions", "ProductoCambioId");
        }
    }
}
