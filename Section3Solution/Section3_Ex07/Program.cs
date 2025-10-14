using System;

namespace Section3_Ex07 {
    internal class Program {
        static void Main(string[] args) {
            int i, j, linhas;

            Console.Write("Informe o número de linhas : ");
            linhas = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= linhas; i++) {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}