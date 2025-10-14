namespace Section7_Ex07 {
    internal class Program {
        static void Main(string[] args) {
            int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            string[] arrayString = { "Maria", "Carlos", "Marcos", "Daniel", "Wesley" };
            double[] arrayDouble = { 1.5, 2.5, 3.5, 4.5, 5.5, 6.5, 7.5 };

            Console.WriteLine("\nArray INT invertido - INFERIDO");
            Exemplo.ReverterEImprimir(arrayInt);
            Console.WriteLine("\nArray STRING invertido - INFERIDO");
            Exemplo.ReverterEImprimir(arrayString);
            Console.WriteLine("\nArray DOUBLE invertido - INFERIDO");
            Exemplo.ReverterEImprimir(arrayDouble);

            Console.WriteLine("\nArray INT invertido - EXPLÍCITO");
            Exemplo.ReverterEImprimir<int>(arrayInt);
            Console.WriteLine("\nArray STRING invertido - EXPLÍCITO");
            Exemplo.ReverterEImprimir<string>(arrayString);
            Console.WriteLine("\nArray DOUBLE invertido - EXPLÍCITO");
            Exemplo.ReverterEImprimir<double>(arrayDouble);
        }
    }
}
