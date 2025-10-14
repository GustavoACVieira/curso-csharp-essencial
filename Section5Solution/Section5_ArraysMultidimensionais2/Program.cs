namespace Section5_ArraysMultidimensionais2 {
    internal class Program {
        static void Main(string[] args) {
            int[,] n = { { 1, 4, 2 }, { 3, 6, 8 } };

            Console.WriteLine("Usando FOR");
            for (int i = 0; i < n.GetLength(0); i++) {
                for (int j = 0; j < n.GetLength(1); j++) {
                    Console.Write($"{n[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nUsando FOREACH");
            foreach (var x in n) {
                Console.Write($"{x} ");
            }
        }
    }
}
