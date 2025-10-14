using System.Linq;

namespace Section9_Ex09 {
    internal class Program {
        static void Main(string[] args) {
            string[] frutas = { "banana", "abacaxi", "uva", "laranja", "abacate", "Kiwi" };

            Console.WriteLine("\nStrings que contém 'a': ");
            var resultado = frutas.Where(x => x.Contains('a'));
            Exibir(resultado);

            Console.WriteLine("\nOrdenado de forma crescente: ");
            int[] numeros = { 5, 2, 8, 3, 1, 7, 4, 6 };
            var resultado2 = numeros.OrderBy(x => x);
            Exibir(resultado2);

            Console.WriteLine("\nAgrupando strings por tamanho");
            var resultado3 = frutas.GroupBy(x => x.Length);
            Exibir(resultado3);

            Console.WriteLine("\nObtendo primeiro par: ");
            var resultado4 = numeros.FirstOrDefault(x => x % 2 == 0);

            if (resultado4 != null) {
                Console.WriteLine("Primeiro número par: " + resultado4);
            }
        }

        private static void Exibir(IEnumerable<string> resultado) {
            foreach (var item in resultado) {
                Console.WriteLine(item);
            }
        }
        private static void Exibir(IOrderedEnumerable<int> resultado) {
            foreach (var item in resultado) {
                Console.WriteLine(item);
            }
        }

        private static void Exibir(IEnumerable<IGrouping<int, string>> resultado) {
            foreach (var group in resultado) {
                Console.WriteLine("\nPalavras com tamanho " + group.Key + ":");
                foreach (var palavra in group) {
                    Console.Write(" " + palavra + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
