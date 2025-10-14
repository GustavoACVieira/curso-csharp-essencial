using System;

namespace Section2_Ex07 {
    internal class Program {
        static void Main(string[] args) {
            int a = 1;
            int b = 12;
            int c = -13;

            double delta = (Math.Pow(b, 2)) - 4 * a * c;

            double x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
            double x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine("X1 = " + x1);
            Console.WriteLine("X2 = " + x2);
        }
    }
}