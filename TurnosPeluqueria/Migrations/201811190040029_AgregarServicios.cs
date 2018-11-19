namespace TurnosPeluqueria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarServicios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Precio = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Servicios");
        }
    }
}
