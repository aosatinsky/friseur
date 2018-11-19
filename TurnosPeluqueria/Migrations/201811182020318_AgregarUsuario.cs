namespace TurnosPeluqueria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "User", c => c.String());
            AddColumn("dbo.Clientes", "Passw", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Passw");
            DropColumn("dbo.Clientes", "User");
        }
    }
}
