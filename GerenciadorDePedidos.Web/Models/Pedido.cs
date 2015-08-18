using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDoCadastro { get; set; }
    }
}