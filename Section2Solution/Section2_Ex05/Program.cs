using System;

namespace Section2_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            char letra1 = char.Parse(Console.ReadLine());
            char letra2 = char.Parse(Console.ReadLine());
            char letra3 = char.Parse(Console.ReadLine());

            Console.WriteLine(letra3 + " - " + letra2 + " - " + letra1);
            Console.WriteLine();
            Console.WriteLine($"{letra3} - {letra2} - {letra1}");
        }
    }
}