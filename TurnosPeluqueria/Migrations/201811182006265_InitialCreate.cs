namespace TurnosPeluqueria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Dni = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        PeluqueroId = c.Int(nullable: false),
                        Horario = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Peluqueroes", t => t.PeluqueroId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.PeluqueroId);
            
            CreateTable(
                "dbo.Peluqueroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Dni = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnoes", "PeluqueroId", "dbo.Peluqueroes");
            DropForeignKey("dbo.Turnoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Turnoes", new[] { "PeluqueroId" });
            DropIndex("dbo.Turnoes", new[] { "ClienteId" });
            DropTable("dbo.Peluqueroes");
            DropTable("dbo.Turnoes");
            DropTable("dbo.Clientes");
        }
    }
}
