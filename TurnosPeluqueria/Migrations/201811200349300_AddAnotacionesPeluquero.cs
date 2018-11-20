namespace TurnosPeluqueria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnotacionesPeluquero : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Peluqueroes", "Usuario", c => c.String(nullable: false));
            AlterColumn("dbo.Peluqueroes", "Passw", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Peluqueroes", "Passw", c => c.String());
            AlterColumn("dbo.Peluqueroes", "Usuario", c => c.String());
        }
    }
}
