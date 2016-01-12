using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models
{
    public enum TipoPessoa
    {
        Fisica, Juridica
    }
    
    
    public class Cliente
    {
        public int Id { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public EnderecoCliente EnderecoCliente { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
                
    }

    public class EnderecoCliente 
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }

    }
}