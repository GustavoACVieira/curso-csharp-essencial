using System;
namespace Section4 {
    internal class Pessoa {
        public static int IdadeMinima;

        public string? Nome;
        public int Idade;

        public Pessoa(string? Nome, int Idade) {
            Console.WriteLine("\nExecutando o construtor parametrizado");
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public Pessoa() { }

        static Pessoa() {
            Console.WriteLine("\nExecutando o construtor estático");
            Console.WriteLine("\nInicializando o campo IdadeMinima");
            IdadeMinima = 18;
        }
    }
}
