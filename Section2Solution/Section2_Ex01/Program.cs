using System;

namespace Section2_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            //E1
            int idade = 35;
            Console.WriteLine(idade);

            //E2
            string nome = "Maria";
            Console.WriteLine(nome);

            //E3
            double altura = 3.45d;
            Console.WriteLine(altura);

            //E4
            DateTime data = new DateTime(1999, 09, 04);
            Console.WriteLine(data);

            //E5
            const int ano = 12;
            Console.WriteLine(ano);

            //E6
            double? nota = 7.8d;
            Console.WriteLine(nota);

            //E13
            int x = 77;
            int y = 66;
            Console.WriteLine(x + y);
        }
    }
}