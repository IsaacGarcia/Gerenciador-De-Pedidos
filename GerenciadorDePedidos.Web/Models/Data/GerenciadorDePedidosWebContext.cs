﻿using System;
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
    
        public GerenciadorDePedidosWebContext() : base("GerenciadorDePedidosWebContext")
        {
        }

        public DbSet<Pedido> Pedidoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtoes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        

    }
}
