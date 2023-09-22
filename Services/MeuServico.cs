using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Services
{
    public class MeuServico : IMeuServico
    {
        public MeuServico()
        {
        }

        string IMeuServico.saudacao(string nome)
        {
            return $"Olá, {nome}!";
        }
    }
}