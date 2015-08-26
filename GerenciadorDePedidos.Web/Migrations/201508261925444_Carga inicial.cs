namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cargainicial : DbMigration
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
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                        Produto_Id = c.Int(),
                        Pedido_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_Id)
                .Index(t => t.Produto_Id)
                .Index(t => t.Pedido_Id);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valorunitario = c.Double(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Data = c.DateTime(nullable: false),
                        Valortotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                        Nome = c.String(),
                        Sexo = c.Int(nullable: false),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Pedido_Id", "dbo.Pedidoes");
            DropForeignKey("dbo.Items", "Produto_Id", "dbo.Produtoes");
            DropForeignKey("dbo.Clientes", "EnderecoCliente_Id", "dbo.EnderecoClientes");
            DropIndex("dbo.Items", new[] { "Pedido_Id" });
            DropIndex("dbo.Items", new[] { "Produto_Id" });
            DropIndex("dbo.Clientes", new[] { "EnderecoCliente_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Items");
            DropTable("dbo.EnderecoClientes");
            DropTable("dbo.Clientes");
        }
    }
}
