using System;

namespace Section3_Ex10 {
    internal class Program {
        static void Main(string[] args) {
            bool condicao = true;

            while (condicao) {
                Console.WriteLine("Informe a nota do aluno: (informe 999 para sair)");
                int nota = int.Parse(Console.ReadLine());

                switch (nota) {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Avaliação: F");
                        break;
                    case 5:
                        Console.WriteLine("Avaliação: E");
                        break;
                    case 6:
                        Console.WriteLine("Avaliação: C");
                        break;
                    case 7:
                    case 8:
                        Console.WriteLine("Avaliação: B");
                        break;
                    case 9:
                        Console.WriteLine("Avaliação: A");
                        break;
                    case 10:
                        Console.WriteLine("Avaliação: A+");
                        break;
                    case 999:
                        condicao = false;
                        break;
                    default:
                        Console.WriteLine("Nota invalida!");
                        break;
                }
            }
        }
    }
}