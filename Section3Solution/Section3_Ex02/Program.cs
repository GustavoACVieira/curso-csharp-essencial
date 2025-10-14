using System;

namespace Section3_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            int a, b, c;

            Console.WriteLine("Cálculo da equação do segundo grau (ax^2+bx+c): ");
            Console.Write("Informe o valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor de c: ");
            c = int.Parse(Console.ReadLine());

            int delta = (int)Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0) {
                Console.WriteLine("As raízes são imaginárias;\r\nSem solução para os números reais");
            } else if (delta == 0) {
                Console.WriteLine("Raizes iguais");
            } else {
                Console.WriteLine("Ambas as raízes são reais e diferentes");

                int x1 = (int)(-b + Math.Sqrt(delta)) / 2 * a;
                int x2 = (int)(-b - Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine($"Primeira raiz x1 = {x1}");
                Console.WriteLine($"Segunda raiz x2 = {x2}");
            }

        }
    }
}