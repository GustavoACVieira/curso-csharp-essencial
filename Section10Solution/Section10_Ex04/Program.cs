namespace Section10_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoPasta = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\";

            Directory.CreateDirectory(caminhoPasta);

            DirectoryInfo subdir = new DirectoryInfo(caminhoPasta);
            subdir.CreateSubdirectory("Entrada");
            subdir.CreateSubdirectory("Saida");
            subdir.CreateSubdirectory("Backup");

            string[] dir = Directory.GetDirectories(caminhoPasta);

            foreach (var diretorios in dir) {
                DirectoryInfo info = new DirectoryInfo(diretorios);
                Console.WriteLine($"Nome: {info.Name} - Caminho completo: {info.FullName}");
            }
        }
    }
}
