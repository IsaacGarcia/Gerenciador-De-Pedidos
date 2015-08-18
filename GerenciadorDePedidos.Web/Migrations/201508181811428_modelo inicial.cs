namespace GerenciadorDePedidos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modeloinicial : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.Pedidoes", "Descricao", c => c.String());
            AddColumn("dbo.Pedidoes", "Data", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pedidoes", "Valortotal", c => c.Double(nullable: false));
            DropColumn("dbo.Pedidoes", "Nome");
            DropColumn("dbo.Pedidoes", "DataDoCadastro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pedidoes", "DataDoCadastro", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pedidoes", "Nome", c => c.String());
            DropForeignKey("dbo.Items", "Pedido_Id", "dbo.Pedidoes");
            DropForeignKey("dbo.Items", "Produto_Id", "dbo.Produtoes");
            DropIndex("dbo.Items", new[] { "Pedido_Id" });
            DropIndex("dbo.Items", new[] { "Produto_Id" });
            DropColumn("dbo.Pedidoes", "Valortotal");
            DropColumn("dbo.Pedidoes", "Data");
            DropColumn("dbo.Pedidoes", "Descricao");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Items");
        }
    }
}
