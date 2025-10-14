using System;

namespace Section4_Estruturas1 {
    internal class Program {
        public struct Cliente {
            public string? Nome { get; set; }
            public int Idade { get; set; }

            public Cliente(string? Nome, int Idade) {
                this.Nome = Nome;
                this.Idade = Idade;
            }
        }

        static void Main(string[] args) {
            Cliente cliente = new Cliente();
            cliente.Nome = "Maria";
            cliente.Idade = 19;

            Console.WriteLine($"{cliente.Nome} {cliente.Idade}");
        }
    }
}