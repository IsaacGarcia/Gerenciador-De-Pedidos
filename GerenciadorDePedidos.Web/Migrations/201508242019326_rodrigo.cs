namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rodrigo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(),
                        RazaoSocial = c.String(),
                        NomeFantasia = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        EnderecoCliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EnderecoClientes", t => t.EnderecoCliente_Id)
                .Index(t => t.EnderecoCliente_Id);
            
            CreateTable(
                "dbo.EnderecoClientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rua = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Cep = c.String(),
                        Complemento = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "EnderecoCliente_Id", "dbo.EnderecoClientes");
            DropIndex("dbo.Clientes", new[] { "EnderecoCliente_Id" });
            DropTable("dbo.EnderecoClientes");
            DropTable("dbo.Clientes");
        }
    }
}
