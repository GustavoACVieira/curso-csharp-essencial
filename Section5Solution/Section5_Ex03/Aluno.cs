using System;
using System.Collections.Generic;
using System.Linq;

namespace Section5_Ex03 {
    internal class Aluno {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public Aluno(string Nome, double Nota) {
            this.Nome = Nome;
            this.Nota = Nota;
        }

        public Aluno() {
        }
    }
}
