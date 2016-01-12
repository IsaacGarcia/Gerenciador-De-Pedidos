using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models.Views
{
    public class PedidoView
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string CodigoCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string EmailCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
        public double ValorTotal { get; set; }

    }
}