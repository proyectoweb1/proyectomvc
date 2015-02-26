namespace proyectoWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrecio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "precio", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "precio");
        }
    }
}
