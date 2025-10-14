namespace Section10_Ex14 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Entrada";
            string[] arquivos = Directory.GetFiles(caminho);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(Path.GetFileName(arquivo));
            }
        }
    }
}
