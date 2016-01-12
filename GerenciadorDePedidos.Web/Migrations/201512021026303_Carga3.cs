namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Carga3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "IdDoPedido", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "IdDoPedido");
        }
    }
}
