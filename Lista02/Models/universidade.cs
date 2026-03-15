using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista02.Models
{
    public class universidade
    {
        public string Nome { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int NumeroAlunos { get; set; }

        public List<string> Cursos { get; set; }
    }
}