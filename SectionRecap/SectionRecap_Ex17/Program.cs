namespace SectionRecap_Ex17 {
    internal class Program {
        public static void Main(string[] args) {
            HashSet<string> nomes = new();

            nomes.Add("Gustavo");
            nomes.Add("Mario");
            nomes.Add("Gustavo");
            nomes.Add("Leo");
            nomes.Add("Mario");

            Console.WriteLine("Nomes: ");
            foreach (var nms in nomes) 
                Console.WriteLine(nms);

            Console.WriteLine($"Quantidade de nomes únicos no HashSet: {nomes.Count}");
        }
    }
}
