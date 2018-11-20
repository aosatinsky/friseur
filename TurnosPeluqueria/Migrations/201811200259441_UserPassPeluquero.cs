namespace TurnosPeluqueria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserPassPeluquero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Peluqueroes", "Usuario", c => c.String());
            AddColumn("dbo.Peluqueroes", "Passw", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Peluqueroes", "Passw");
            DropColumn("dbo.Peluqueroes", "Usuario");
        }
    }
}
