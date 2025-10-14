namespace SectionRecap_Ex19 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(Compare(10, 20)); 
            Console.WriteLine(Compare(30, 15)); 
            Console.WriteLine(Compare(5, 5));

            Console.WriteLine(Compare("Ana", "Bruno"));
            Console.WriteLine(Compare("Gustavo", "Gustavo"));
        }

        public static int Compare<T>(T a, T b) where T : IComparable {
            int resultado = a.CompareTo(b);

            if (resultado == 0)
                return 0;
            else if (resultado > 0)
                return 1;
            else
                return -1;
        }
    }
}
