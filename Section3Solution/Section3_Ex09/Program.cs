using System;

namespace Section3_Ex09 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("## Tabelas do 2 ao 6 ##");

            for (int i = 2; i <= 6; i++) {
                for (int j = 1; j <= 10; j++) {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}