namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Carga1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pedidoes", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pedidoes", "Data", c => c.DateTime(nullable: false));
        }
    }
}
