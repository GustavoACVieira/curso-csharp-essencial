using System;

namespace Section5_Array1 {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] nomes1 = new string[5] { "Ana", "Maria", "Marta", "Paulo", "Carlos" };
            //string[] nomes2 = new string[] { "Ana", "Maria", "Marta", "Paulo", "Carlos" };
            //string[] nomes3 = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

            //Usando FOR
            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine($"Elemento de índice {i} : {numeros[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < nomes1.Length; i++) {
                Console.WriteLine($"Elemento de índice {i} : {nomes1[i]}");
            }

            Console.WriteLine();

            //Usando FOREACH
            foreach (int nmr in numeros) {
                Console.WriteLine(nmr);
            }

            Console.WriteLine();

            foreach (string str in nomes1) {
                Console.WriteLine(str);
            }
        }
    }
}