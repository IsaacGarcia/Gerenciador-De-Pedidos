namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CargaPedido : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedidoes", "Dia", c => c.Int(nullable: false));
            AddColumn("dbo.Pedidoes", "Mes", c => c.Int(nullable: false));
            AddColumn("dbo.Pedidoes", "Ano", c => c.Int(nullable: false));
            AddColumn("dbo.Pedidoes", "Cliente_Id", c => c.Int());
            CreateIndex("dbo.Pedidoes", "Cliente_Id");
            AddForeignKey("dbo.Pedidoes", "Cliente_Id", "dbo.Clientes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Pedidoes", new[] { "Cliente_Id" });
            DropColumn("dbo.Pedidoes", "Cliente_Id");
            DropColumn("dbo.Pedidoes", "Ano");
            DropColumn("dbo.Pedidoes", "Mes");
            DropColumn("dbo.Pedidoes", "Dia");
        }
    }
}
