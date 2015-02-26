namespace proyectoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FotoEliminada : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Productoes", "foto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "foto", c => c.String());
        }
    }
}
