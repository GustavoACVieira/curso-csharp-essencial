using System;

namespace Section2_Ex09 {
    internal class Program {
        static void Main(string[] args) {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(x % 2 == 0 ? "X é par" : "X é impar");
            Console.WriteLine(y % 2 == 0 ? "Y é par" : "Y é impar");
        }
    }
}