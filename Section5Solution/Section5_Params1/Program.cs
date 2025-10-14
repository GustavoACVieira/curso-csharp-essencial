using System;

namespace Section5_Params1 {
    internal class Program {
        static void Main(string[] args0) {
            //Sem usar params
            int[] valores = { 1, 2, 3, 4, 5 };

            var resultado = Calcular.Soma(valores);
            Console.WriteLine(resultado);

            //Usando params
            var resultado2 = Calcular.Soma(10, 20, 30, 40, 50);
            Console.WriteLine(resultado2);
        }
    }
}