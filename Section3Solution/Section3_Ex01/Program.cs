using System;

namespace Section3_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Encontre o maior dentre 3 números: ");
            int num1, num2, num3;

            Console.Write("\nPrimeiro Número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nSegundo Número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("\nTerceiro Número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3) {
                Console.WriteLine($"O primeiro número: {num1} é o maior");
            } else if (num2 > num1 && num2 > num3) {
                Console.WriteLine($"O segundo número: {num2} é o maior");
            } else {
                Console.WriteLine($"O terceiro número: {num3} é o maior");
            }

        }
    }
}