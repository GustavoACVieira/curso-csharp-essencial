namespace Section10_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoOrigem = @"C:\ws-c#\Section10Solution\ArquivosTXT";

            string[] arquivos = Directory.GetFiles(caminhoOrigem, "*.txt");

            foreach (string arquivo in arquivos) {
                FileInfo file = new FileInfo(arquivo);
                Console.WriteLine($"Nome: {file.Name} - Tamanho: {file.Length} - Data de Criação: {file.CreationTime} - Última modificação: {file.LastWriteTime}");
            }
        }
    }
}
