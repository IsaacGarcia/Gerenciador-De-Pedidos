namespace GerenciadorDePedidos.Web.Migrations
{
    using GerenciadorDePedidos.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GerenciadorDePedidos.Web.Models.GerenciadorDePedidosWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GerenciadorDePedidos.Web.Models.GerenciadorDePedidosWebContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Usuarios.Add(new Usuario { Login = "admin", Senha = "admin", Nome = "fulano", Sexo = Sexo.Masculino });

            context.Produtoes.Add(new Produto { Nome = "Detergente", Valorunitario = 200, Descricao = "Produto Bom" });

        }
    }
}
