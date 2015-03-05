namespace proyectoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "usuario", c => c.String());
            AddColumn("dbo.Transaccions", "usuario", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transaccions", "usuario");
            DropColumn("dbo.Productoes", "usuario");
        }
    }
}
