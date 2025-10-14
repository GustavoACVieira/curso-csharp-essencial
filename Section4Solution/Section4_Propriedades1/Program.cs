using System;

namespace Section4_Propriedades1 {
    internal class Program {
        static void Main(string[] args) {
            Produto p1 = new();

            p1.Nome = "Caderno";
            p1.Preco = 4.99;
            p1.EstoqueMinimo = 10;

            p1.Exibir();
        }
    }
}