namespace SectionRecap_Ex08 {
    internal class Program {
        static void Main(string[] args) {
            List<int> numRandom = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++ ) {
                numRandom.Add(random.Next(20));
            }

            Console.WriteLine("\nLista sem filtros: ");
            foreach (int num in numRandom)
                Console.Write(num + " ");

            var listMaior = numRandom.Where(x => x > 10).ToList();
            Console.WriteLine("\nLista com filtros: ");
            foreach (var lisMaior in listMaior)
                Console.Write(lisMaior + " ");
            Console.WriteLine();
        }
    }
}
