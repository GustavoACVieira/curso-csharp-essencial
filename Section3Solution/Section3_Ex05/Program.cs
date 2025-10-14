using System;

namespace Section3_Ex05 {
    internal class Program {
        static void Main(string[] args) {       
            while (true) {
                Console.WriteLine("\nQual a instrução para sair de um loop ?");
                Console.WriteLine("a.quit");
                Console.WriteLine("b.continue");
                Console.WriteLine("c.break");
                Console.WriteLine("d.exit");
                Console.WriteLine("\nQual opção correta? (Tecle x para sair)");
                var opcao = Console.ReadLine().ToLower();


                if (opcao == "x")
                    break;
                else if (opcao == "a")
                    Console.WriteLine("Resposta Errada");
                else if (opcao == "b")
                    Console.WriteLine("Resposta Errada");
                else if (opcao == "c")
                    Console.WriteLine("Resposta Certa");
                else if (opcao == "d")
                    Console.WriteLine("Resposta Errada");

            }
        }
    }
}