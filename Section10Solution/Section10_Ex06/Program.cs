namespace Section10_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o caminho de uma pasta: ");
            string caminho = Console.ReadLine();

            string caminho2 = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Saida\relatorio.txt";

            DirectoryInfo dir = new DirectoryInfo(caminho);

            FileInfo[] arquivos = dir.GetFiles("*", SearchOption.AllDirectories);

            foreach (var arquivo in arquivos) {
                Console.WriteLine($"\n\nNome do Arquivo: {Path.GetFileName(arquivo.Name)} \nTamanho: {arquivo.Length} \nData de Modificação: {arquivo.LastWriteTime} \nCaminho Completo: {arquivo.FullName}");
                string relatorio = $"\nNome: {arquivo.Name}\nTamanho: {arquivo.Length} bytes\n" + $"Data de Modificação: {arquivo.LastWriteTime}\nCaminho: {arquivo.FullName}\n";
                File.AppendAllText(caminho2, relatorio);
            }
        }
    }
}
