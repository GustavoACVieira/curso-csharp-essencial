using System;

namespace Section3Solution {
    internal class Program {
        static void Main(string[] args) {
            //int i = 1;

            /* GoTo
        repetir:
            Console.WriteLine($"i = {i}");

            i++;
            if (i <= 10) 
                goto repetir;

            */

            /* While
            while (i <= 10) {
                Console.WriteLine($"i = {i}");
                i++;
            }
            */

            /*While I
            Console.WriteLine("Informe um número para a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            while (i <= 10) {
                Console.WriteLine($"{num} x {i} = {num * i}");
                i++;
            }
            */

            /*While II
            while (true) {
                Console.WriteLine("\nInforme um numero inteiro: (Para sair tecle 999)");
                int numero = Convert.ToInt32((Console.ReadLine()));

                if (numero == 999) {
                    break;
                }

                if (numero % 2 == 0) {
                    Console.WriteLine($"{numero} é PAR");
                } else {
                    Console.WriteLine($"{numero} é IMPAR");
                }
            }
            */

            /* do while
            do {
                Console.WriteLine($"i = {i}");
                i++;

                if (i > 7)
                    break;

            } while (i <= 10);
            */

            /* For I
            Console.WriteLine("Informe um número para a tabuada: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
            */

            /* For II
            for ( ; ; ) {
                Console.WriteLine("Tecle algo (X sai) ");

                string opcao = Console.ReadLine();

                Console.WriteLine(opcao.ToUpper());

                if (opcao == "x" || opcao == "X") {
                    Console.WriteLine("Tchau...");
                    break;
                }
            }
            */

            Console.WriteLine("Fim do processamento...");
        }
    }
}