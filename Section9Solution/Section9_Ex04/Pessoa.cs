using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9_Ex04 {
    internal class Pessoa {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string? Nome, int Idade) {
            this.Nome = Nome;
            this.Idade = Idade;
        }
    }
}
