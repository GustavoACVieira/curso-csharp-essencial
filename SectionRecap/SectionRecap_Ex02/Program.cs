using System.Collections;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace SectionRecap_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa que use um ArrayList para armazenar nomes digitados pelo usuário até que ele digite “sair”.
            //Depois, exiba os nomes em ordem alfabética.
            ArrayList nomes = new ArrayList();

            while (true) {
                Console.WriteLine("\nInforme um nome: ");
                string nome = Console.ReadLine();
                if (nome.Equals("sair"))
                    break;
                nomes.Add(nome);
                
            }

            nomes.Sort();

            foreach (var nms in nomes) {
                Console.WriteLine(nms);
            }
        }
    }
}
