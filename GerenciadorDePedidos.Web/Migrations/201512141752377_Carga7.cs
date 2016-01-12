namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Carga7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedidoes", "IdCliente", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pedidoes", "IdCliente");
        }
    }
}
