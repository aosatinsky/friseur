namespace TurnosPeluqueria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarAnotaciones : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Nombre", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Apellido", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "User", c => c.String(nullable: false));
            AlterColumn("dbo.Clientes", "Passw", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Passw", c => c.String());
            AlterColumn("dbo.Clientes", "User", c => c.String());
            AlterColumn("dbo.Clientes", "Apellido", c => c.String());
            AlterColumn("dbo.Clientes", "Nombre", c => c.String());
            DropColumn("dbo.Clientes", "email");
        }
    }
}
