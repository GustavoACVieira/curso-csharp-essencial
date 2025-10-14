using System;

namespace Section2_Ex10 {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("-6 + x * 5 = " + (-6 + x * 5));
            Console.WriteLine("(13-2) * x = " + ((13 - 2) * x));
            Console.WriteLine(" (x + -2) * (20 / x) = " + ((x + -2) * (20 / x)));
            Console.WriteLine("(12 + x) / (x - 4) = " + ((12 + x) / (x - 4)));
            Console.WriteLine("3 * x^2 + x + 10 = " + (3 * Math.Pow(x, 2) + x + 10));
            Console.WriteLine("pi * x^2 = " + (Math.PI * Math.Pow(x, 2)));
        }
    }
}