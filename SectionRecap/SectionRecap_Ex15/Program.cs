namespace SectionRecap_Ex15 {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<int, string> produtos = new();

            for (int i = 1; i <= 3; i++) {
                try {
                    Console.WriteLine("Informe o código do produto: ");
                    int cod = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o nome do produto: ");
                    string nome = Console.ReadLine();

                    produtos.Add(cod, nome);
                } catch (ArgumentNullException ex) {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }

            Console.WriteLine("\nInforme o código que deseja procurar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            if (produtos.ContainsKey(codigo)) {
                Console.WriteLine($"\nProduto encontrado:");
                Console.WriteLine($"Cod: {codigo} - Nome: {produtos[codigo]}");
            } else {
                Console.WriteLine("\nCódigo não encontrado!");
            }
        }
    }
}
