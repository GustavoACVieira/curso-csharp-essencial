using System;

namespace Section5_Array2 {
    internal class Program {
        static void Main(string[] args) {
            string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos", "Beatriz" };

            Console.WriteLine("\nExibindo array original: ");
            ExibeArray(nomes);

            Console.WriteLine("\nInvertendo a ordem do array: ");
            Array.Reverse(nomes);
            ExibeArray(nomes);

            Console.WriteLine("\nOrdenando o array: ");
            Array.Sort(nomes);
            ExibeArray(nomes);

            Console.WriteLine("\nLocalizando um item no array:");
            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();
            var indice = Array.BinarySearch(nomes, nome);

            if (indice >= 0) 
                Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}");
            else
                Console.WriteLine($"\n{nome} não foi encontrado");
        }

        static void ExibeArray(string[] nomes) {
            foreach (string nome in nomes) {
                Console.Write($"{nome} ");
            }
            Console.WriteLine();
        }
    }
}