using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista02.Models
{
    public class Peca
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }
    }
}