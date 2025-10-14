using System;

namespace Section2_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            int? valor = null;
            valor = 3;
            int? num = valor ?? 8;
            int? mult = valor * num ?? 24;


            if (mult.HasValue) {
                Console.WriteLine(mult);
            } else {
                Console.WriteLine("Não tem valor");
            }
        }
    }
}