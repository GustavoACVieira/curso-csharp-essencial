using System;

namespace Section2_TiposDeDados3 {
    internal class Program {
        static void Main(string[] args) {
            bool ativo = true;
            Boolean inativo = false;

            Console.WriteLine(ativo);
            Console.WriteLine(inativo);
            Console.WriteLine();

            Console.WriteLine(10 == 15);
            Console.WriteLine(10 == 10);
            Console.WriteLine();

            int x2 = 10;
            int y2 = 15;

            Console.WriteLine(x2 > y2);
            Console.WriteLine();

            char letra1 = 'A';
            char letra2 = '\u0041';
            char letra3 = '\u00E5';

            Console.WriteLine(letra1);
            Console.WriteLine(letra2);
            Console.WriteLine(letra3);
            Console.WriteLine();
        }
    }
}