namespace SectionRecap_Ex36 {
    internal class Program {
        static void Main(string[] args) {
            Downloader downloader = new Downloader();

            downloader.ProgressoAlterado += (sender, progresso) => {
                Console.WriteLine($"Progresso: {progresso}%");
            };

            downloader.Baixar();
        }
    }
}
