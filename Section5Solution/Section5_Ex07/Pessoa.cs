using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex07 {
    internal class Pessoa {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa() {
        }

        public Pessoa(string? Nome, int Idade) {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public static void Exibir(ArrayList lista) {
            foreach (Pessoa item in lista) {
                Console.WriteLine($"Nome: {item.Nome} - Idade: {item.Idade}");
            }
        }
    }
}
