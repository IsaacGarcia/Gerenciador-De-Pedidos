using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models.Views
{
    public class CadastroDePedido
    {
        public Pedido Pedido { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}