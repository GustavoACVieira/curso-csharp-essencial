using System;

namespace Section3_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            for ( ; ; ) {
                Console.WriteLine("\nInforme um número natural maior que zero: (informe 999 para sair)");
                int num = int.Parse(Console.ReadLine());

                if (num <= 0) {
                    Console.WriteLine("Número inválido!");
                } else if (num == 999) {
                    break;
                }

                Console.WriteLine("\n## TABELA ##\n");
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"{num} x {i} = {num * i}");
                }
            }
        }
    }
}