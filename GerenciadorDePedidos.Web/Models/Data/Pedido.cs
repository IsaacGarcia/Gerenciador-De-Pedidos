using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models
{

    public class Pedido
    {
        public int Id { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public Cliente Cliente { get; set; }
        public int IdCliente { get; set; }
        public string Descricao { get; set; }
        public List<Item> Itens { get; set; }
        public double Valortotal { get; set; }

        public int GetClienteId()
        {
            return Cliente.Id;
        }

        public Pedido()
        {
            this.Itens = new List<Item>();

        }

        public void Adiciona(Item item)
        {
            this.Itens.Add(item);

        }

        public void Acrescenta(double valor)
        {
            Valortotal += valor;

        }

    }


    public class Item
    {
        public int Id { get; set; }
        public int IdDoPedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }

        public double CalcularTotal()
        {
            return Produto.Valorunitario * Quantidade;
        }

    }
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valorunitario { get; set; }
        public string Descricao { get; set; }
    }
}