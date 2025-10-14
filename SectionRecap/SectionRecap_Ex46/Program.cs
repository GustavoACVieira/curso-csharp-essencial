using System.Threading.Tasks;

namespace SectionRecap_Ex46 {
    internal class Program {
        static async Task Main(string[] args) {
            using CancellationTokenSource cts = new CancellationTokenSource();
            try {
                Task.Run(async () => {
                    
                    await Task.Delay(5000);
                    cts.Cancel();
                    Console.WriteLine("Cancelado!!");
                });
                await Task.Run(() => randomNumber(cts.Token));
            } catch (OperationCanceledException) {
                Console.WriteLine("Download cancelado!");
            }

        }

        static async Task<List<int>> randomNumber (CancellationToken token) {
            Random random = new Random();
            List<int> list = new();
            for (int i = 0; i < 10; i++) {
                token.ThrowIfCancellationRequested();
                list.Add(random.Next(1, 50));
                await imprime(list);
                await Task.Delay(1000);
            }
            return list;
        }

        static async Task imprime (List<int> list) {
            Console.WriteLine($"\nTamanho da lista atualmente: {list.Count()}");
        }
    }
}
