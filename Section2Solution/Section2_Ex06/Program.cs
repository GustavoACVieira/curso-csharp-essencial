using System;

namespace Section2_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe 2 valores do tipo double: ");
            double value1 = double.Parse(Console.ReadLine());
            double value2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nOperações: ");
            Console.WriteLine("Soma: " + (value1 + value2));
            Console.WriteLine("Subtração: " + (value1 - value2));
            Console.WriteLine("Multiplicação: " + (value1 * value2));
            Console.WriteLine("Exponenciação: " + Math.Pow(value1, value2));
            Console.WriteLine("Divisão: " + (value1 / value2));
            Console.WriteLine("Módulo: " + (value1 % value2));
        }
    }
}