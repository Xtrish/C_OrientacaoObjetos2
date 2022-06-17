﻿using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.ParceriaComercial
{
    public class ParceiroComercial:Autenticavel
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
     
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
