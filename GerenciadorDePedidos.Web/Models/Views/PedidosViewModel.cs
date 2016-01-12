using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models.Views
{
    public class PedidosViewModel
    {
        public int? diaMinimo { get; set; }
        public int? mesMinimo { get; set; }
        public int? anoMinimo { get; set; }
        public int? diaMaximo { get; set; }
        public int? mesMaximo { get; set; }
        public int? anoMaximo { get; set; }
        public string NomeCliente { get; set; }
        public string cpfCliente { get; set; }
        public double? valorMinimo { get; set; }
        public double? valorMaximo { get; set; }


    }
}