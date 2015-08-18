using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Item> Itens { get; set; }
        public DateTime Data { get; set; }
        public double Valortotal { get; set; }

    }
    public class Item
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }

    }
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valorunitario { get; set; }
        public string Descricao { get; set; }
    }
}