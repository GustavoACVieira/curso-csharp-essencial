using System;

namespace Section3_Ex08 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= num; i++)
                fat *= i;

            Console.WriteLine($"O fatorial de {num} é: {fat}");
        }
    }
}