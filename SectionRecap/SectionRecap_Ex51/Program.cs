namespace SectionRecap_Ex51 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\nomes.txt";
            List<string> nomes = new List<string>();

            for (int i = 1; i <= 3; i++) {
                Console.WriteLine($"Informe o {i} nome: ");
                nomes.Add(Console.ReadLine());
            }

            foreach (string nome in nomes)
                File.AppendAllText(caminho, "\r\n" + nome);

            foreach (var nome in File.ReadAllLines(caminho))
                Console.WriteLine(nome);
        }
    }
}
