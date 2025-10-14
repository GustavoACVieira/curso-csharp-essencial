namespace SectionRecap_Ex14 {
    internal class Program {
        static void Main(string[] args) {
            List<string> listaNomes = new();
            string? nomes;

            do { 
                Console.WriteLine("Informe nomes (Digite 'sair' para sair):");
                nomes = Console.ReadLine();
                listaNomes.Add(nomes);
            } while (!nomes.Equals("sair"));

            listaNomes.Remove(listaNomes.Last());
            listaNomes.Sort();


            Console.WriteLine("\nLista: ");
            foreach (var ltNomes in listaNomes)
                Console.WriteLine(ltNomes);
        }
    }
}
