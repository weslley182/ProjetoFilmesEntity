﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFilmes.App.Entidades
{
    public class Funcionario: Pessoa
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
