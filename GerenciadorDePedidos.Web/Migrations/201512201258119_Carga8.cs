namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Carga8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GraficoViewModels",
                c => new
                    {
                        Grafico = c.Int(nullable: false, identity: true),
                        Janeiro = c.Double(nullable: false),
                        Fevereiro = c.Double(nullable: false),
                        Marco = c.Double(nullable: false),
                        Abril = c.Double(nullable: false),
                        Maio = c.Double(nullable: false),
                        Junho = c.Double(nullable: false),
                        Agosto = c.Double(nullable: false),
                        Setembro = c.Double(nullable: false),
                        Outubro = c.Double(nullable: false),
                        Novembro = c.Double(nullable: false),
                        Dezembro = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Grafico);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GraficoViewModels");
        }
    }
}
