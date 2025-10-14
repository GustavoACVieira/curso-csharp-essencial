using System;

namespace Section2_EntradaDeDados1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("A sua idade é: " + idade);
        }
    }
}