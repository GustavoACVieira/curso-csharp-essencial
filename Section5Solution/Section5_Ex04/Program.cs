namespace Section5_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            string[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

            Console.WriteLine($"Quantidade de frutas: {frutas.Count()}");

            //FOR
            Console.WriteLine("\nUsando For: ");
            for (int i = 0; i < frutas.Length; i++) {
                Console.WriteLine($"Fruta número {i + 1}: {frutas[i]}");
            }

            //FOREACH
            Console.WriteLine("\nUsando Foreach: ");
            foreach (var f in frutas) {
                Console.WriteLine($"Fruta: {f}");
            }

            Console.WriteLine();
            Console.WriteLine($"Segunda fruta: {frutas[1]}");
            Console.WriteLine($"Penúltima fruta: {frutas[8]}");

            frutas[2] = "Kiwi";
            frutas[9] = "Caqui";
            Console.WriteLine("\nUsando For: ");
            for (int i = 0; i < frutas.Length; i++) {
                Console.WriteLine($"Fruta número {i + 1}: {frutas[i]}");
            }

            var frutasOrdenado = frutas.Order();
            Console.WriteLine("\nOrdenado: ");
            foreach (var f in frutasOrdenado) {
                Console.WriteLine($"Fruta: {f}");
            }

            var frutasInverso = frutas.Reverse();
            Console.WriteLine("\nInverso: ");
            foreach (var f in frutasInverso) {
                Console.WriteLine($"Fruta: {f}");
            }
        }
    }
}
