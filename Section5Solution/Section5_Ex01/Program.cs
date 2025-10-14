using System;

namespace Section5_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            string[] nomesA = new string[5];
            double[] notasA = new double[5];
            double average = 0.0;

            for (int i = 0; i < nomesA.Length; i++) {
                Console.WriteLine($"Informe o nome do {i + 1} aluno: ");
                nomesA[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < notasA.Length; i++) {
                Console.WriteLine($"Informe a nota do {i + 1} aluno: ");
                notasA[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nAlunos: ");
            foreach (var nome in nomesA) {
                Console.Write($"{nome} ");
            }

            Console.WriteLine("\nNotas: ");
            foreach (var nota in notasA) {
                Console.Write($"{nota} ");
                average += nota;
            }
            average /= notasA.Length;

            Console.WriteLine($"\nMédia aritmética: {average}");

            Console.WriteLine("\nExibindo de forma legal: ");
            for (int i = 0; i < 5;i++) {
                Console.WriteLine($"{nomesA[i]}  \t|  {notasA[i]}");
            }
        }
    }
}