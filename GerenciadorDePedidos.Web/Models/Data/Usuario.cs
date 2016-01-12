using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GerenciadorDePedidos.Web.Models
{
    public enum Sexo
    {
        Masculino, Feminino
    }
    
    public class Usuario
    {
        
        public int Id { get; set; } 
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public string Endereco { get; set; }

        public void TrocarSenha(string senha)
        {
            Senha = senha;

        }

        public void TrocarLogin(string login)
        {

            Login = login;

        }

        public void TrocarEmail(string email)
        {

            Email = email;

        }


        
    }
}