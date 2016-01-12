namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Carga4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Sobrenome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Sobrenome");
        }
    }
}
