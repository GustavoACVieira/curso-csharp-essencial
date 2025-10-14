using System.Threading.Tasks;

namespace SectionRecap_Ex43 {
    internal class Program {
        static async Task Main(string[] args) {
            using CancellationTokenSource token = new();
            

            try {
                Task.Run(async () => {
                    await Task.Delay(3000);
                    token.Cancel();
                    Console.WriteLine("Cancelado!");
                });
                await Task.Run(() => BaixarArquivoAsync(token.Token));
            } catch (OperationCanceledException) {
                Console.WriteLine("Download cancelado!");
            }
        }

        static async Task BaixarArquivoAsync(CancellationToken token) {
            Console.WriteLine("Baixando...");
            for (int i = 0; i <= 100; i += 10) {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Progresso: {i}%");
                await Task.Delay(500);
            }
            Console.WriteLine("Download concluido!");
        }
    }
}
