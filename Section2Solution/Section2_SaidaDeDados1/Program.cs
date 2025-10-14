using System;

namespace Section2_SaidaDeDados1 {
    internal class Program {
        static void Main(string[] args) {
            int idade = 25;
            string nome = "Maria";

            Console.WriteLine(nome + " tem " + idade + " anos");
            Console.WriteLine("-------------");
            Console.WriteLine($"{nome} tem {idade} anos");
            Console.WriteLine("-------------");
            Console.WriteLine("{0} tem {1} anos", nome, idade);
            Console.WriteLine();

            string local = "C:\\Users\\Nectar\\Downloads\\poesias.txt";

            string frase = "Ele falou: \"Não fui eu\"";

            string bolo = "\nBolo\tde\tChocolate";

            Console.WriteLine(local);
            Console.WriteLine(bolo);
        }
    }
}