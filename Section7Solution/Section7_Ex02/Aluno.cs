
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7_Ex02 {
    internal class Aluno {
        public string? Nome {  get; set; }
        public int Nota { get; set; }

        public Aluno(string? Nome,  int Nota) {
            this.Nome = Nome;
            this.Nota = Nota;
        }
    }
}
