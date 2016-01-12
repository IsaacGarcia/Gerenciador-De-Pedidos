namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Carga9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GraficoViewModels", "Julho", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GraficoViewModels", "Julho");
        }
    }
}
