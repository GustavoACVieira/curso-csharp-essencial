using System;

namespace Section2_Ex11 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe a temperatura em Celsius: ");
            int celsius = int.Parse(Console.ReadLine());

            int kelvin = celsius + 273;
            int farhenheit = (celsius * 9) / 5 + 32;

            Console.WriteLine("Temperatura em kelvin: " + kelvin + "K");
            Console.WriteLine("Temperatura em farhenheit: " + farhenheit + "F");
        }
    }
}