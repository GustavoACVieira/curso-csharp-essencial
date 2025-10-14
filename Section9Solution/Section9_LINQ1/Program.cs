using System.Linq;

namespace Section9_LINQ1 {
    internal class Program {
        static void Main(string[] args) {
            List<string> nomes = new List<string>() {
                "Ana", "Maria", "Pedro", "Lair", "Hugo"
            };

            //Query Syntax
            var resultado = from m in nomes
                            where m.Contains('o')
                            select m;
            ExibirResultado(resultado);

            Console.WriteLine();

            //Method Syntax
            var resultado2 = nomes.Where(n => n.Contains('a'));
            ExibirResultado(resultado2);
        }

        private static void ExibirResultado(IEnumerable<string> resultado) {
            foreach (var item in resultado)
                Console.WriteLine(item);
        }
    }
}
