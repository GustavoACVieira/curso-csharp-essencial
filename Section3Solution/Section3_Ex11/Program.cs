using System;

namespace Section3_Ex11 {
    internal class Program {
        static void Main(string[] args) {
            int num1, num2;
            char operando;

            Console.Write("Informe o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nInforme o operando (+, -, /, *): ");
            operando = char.Parse(Console.ReadLine());
            Console.Write("\nInforme o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (operando == '+') {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            } else if (operando == '-') {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            } else if (operando == '/') {
                if (num2 == 0) {
                    Console.WriteLine("Não existe divisão por zero!!!");
                    Console.WriteLine($"{num1} / {num2} = \u221E");
                } else {
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                }
            } else {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
        }
    }
}