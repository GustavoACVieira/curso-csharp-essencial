namespace Section10_Ex09 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o caminho: ");
            string caminho = Console.ReadLine();

            if (File.Exists(caminho)) {
                Console.WriteLine($"Data de criação do arquivo: {File.GetCreationTime(caminho)}");
            } else {
                Console.WriteLine("Arquivo não encontrado!");
            }
        }
    }
}
