using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models
{
    public class GerenciadorDePedidosWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation: 
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GerenciadorDePedidosWebContext() : base("name=GerenciadorDePedidosWebContext")
        {
        }

        public DbSet<Pedido> Pedidoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public System.Data.Entity.DbSet<GerenciadorDePedidos.Web.Models.Produto> Produtoes { get; set; }
<<<<<<< HEAD:GerenciadorDePedidos.Web/Models/Data/GerenciadorDePedidosWebContext.cs

        public System.Data.Entity.DbSet<GerenciadorDePedidos.Web.Models.Item> Items { get; set; }
=======
        public System.Data.Entity.DbSet<GerenciadorDePedidos.Web.Models.Cliente> Clientes { get; set; }
>>>>>>> origin/master:GerenciadorDePedidos.Web/Models/GerenciadorDePedidosWebContext.cs
    }
}
