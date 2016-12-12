using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SophiaTest.Models
{
    public class Registro
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Contato { get; set; }

        public int Telefone { get; set; }

        public string Conteudo { get; set; }
            
        public DateTime DataHora { get; set; }
    }
}