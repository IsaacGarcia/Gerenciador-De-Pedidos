using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models.Views
{
    public class CadastroDePedido
    {
        public Pedido Pedido { get; set; }
        
        public List<Item> Itens { get; set; }

        public CadastroDePedido()
        {
            this.Itens = new List<Item>();
            
        }

        public void Adiciona(Item item)
        {
            Pedido.Itens.Add(item);

        }

    }
}