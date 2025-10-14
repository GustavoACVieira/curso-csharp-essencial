using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex05 {
    internal class Aluno : Pessoa {
        public Aluno(string? Nome) : base(Nome) {
        }

        public void Estudar() {
            Console.WriteLine($"{Nome} está estudando!");
        }
    }
}
