using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex05 {
    internal class Professor : Pessoa {
        public Professor(string? Nome) : base(Nome) {
        }

        public void Explicando() {
            Console.WriteLine($"O {Nome} está explicando!");
        }
    }
}
