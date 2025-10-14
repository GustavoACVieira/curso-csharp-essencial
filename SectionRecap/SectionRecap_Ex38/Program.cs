namespace SectionRecap_Ex38 {
    internal class Program {
        static async Task Main(string[] args) {
            await LerArquivoAsync(@"C:\caminho legal");
        }

        public static async Task LerArquivoAsync(string caminho) {
            Console.WriteLine("Iniciando leitura no caminho: " + caminho);
            await Task.Delay(2565);
            Console.WriteLine("Leitura finalizada!");
        }
    }
}
