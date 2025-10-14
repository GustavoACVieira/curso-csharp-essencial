using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7_Ex04 {
    internal class Aluno {
        public string? Nome;
        public int Idade;
        public string? Sexo;

        public Aluno(string? Nome, int Idade, string? Sexo) {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Sexo = Sexo;
        }
    }
}
