namespace SectionRecap_Ex40 {
    internal class Program {
        static async Task Main(string[] args) {
            await Task.WhenAll(DownloadArquivo1(), DownloadArquivo2(), DownloadArquivo3());
            Console.WriteLine("Arquivos baixados!");
        }

        public static async Task DownloadArquivo1 () {
            Console.WriteLine("Baixando Arquivo1...");
            await Task.Delay(3500);
        }

        public static async Task DownloadArquivo2 () {
            Console.WriteLine("Baixando Arquivo2...");
            await Task.Delay(1500);
        }

        public static async Task DownloadArquivo3 () {
            Console.WriteLine("Baixando Arquivo3...");
            await Task.Delay(5000);
        }
    }
}
