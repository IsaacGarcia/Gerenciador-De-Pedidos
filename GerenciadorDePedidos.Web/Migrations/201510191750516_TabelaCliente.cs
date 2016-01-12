namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "TipoPessoa", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Nome", c => c.String());
            AddColumn("dbo.Clientes", "Cpf", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Cpf");
            DropColumn("dbo.Clientes", "Nome");
            DropColumn("dbo.Clientes", "TipoPessoa");
        }
    }
}
