namespace SectionRecap_Ex12 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos";

            DirectoryInfo dirInfo = new DirectoryInfo(caminho);

            FileInfo[] files = dirInfo.GetFiles("*", SearchOption.AllDirectories);

            string caminhoDestino = @"C:\ws-c#\SectionRecap\Backup_10-10-2025";

            foreach (var file in files)
                file.CopyTo(Path.Combine(caminhoDestino, file.Name), true);
        }
    }
}
