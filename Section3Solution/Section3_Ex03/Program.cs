using System;

namespace Section3_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            int i = 1;
            int sum = 0;

            Console.WriteLine("While: ");
            Console.WriteLine("Os 10 primeiros números naturais são: ");
            while (i <= 10) {
                Console.Write($"{i} ");
                sum += i;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine($"A soma dos números é: {sum}");

            i = 1;
            sum = 0;

            Console.WriteLine("\nDo While: ");
            Console.WriteLine("Os 10 primeiros números naturais são: ");
            do {
                Console.Write($"{i} ");
                sum += i;
                i++;
            } while (i <= 10);
            Console.WriteLine();
            Console.WriteLine($"A soma dos números é: {sum}");

            sum = 0;

            Console.WriteLine("\nFor: ");
            Console.WriteLine("Os 10 primeiros números naturais são: ");
            for (int iF = 1; iF <= 10; iF++) {
                Console.Write($"{iF} ");
                sum += iF;
            }
            Console.WriteLine();
            Console.WriteLine($"A soma dos números é: {sum}");
        }
    }
}