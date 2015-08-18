﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Sample.CI.Models
{
    public class Usuario
    {
        
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        
    }
}