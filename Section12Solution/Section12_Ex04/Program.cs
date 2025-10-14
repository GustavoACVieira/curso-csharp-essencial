using System.Threading.Tasks;

namespace Section12_Ex04 {
    internal class Program {
        static async Task Main(string[] args) {
            await ExecutaOperacaoAsync();
        }

        static async Task ExecutaOperacaoAsync() {
            var tempo = 5;
            var tokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

            Console.WriteLine("\nIniciando download....");
            Console.WriteLine("\nTempo para o cancelamento " + tempo + " segundos.....");

            try {
                using var httpClient = new HttpClient();
                var destino = @"C:\ws-c#\Section12Solution\Arquivos\arquivo.txt";
                var response = await httpClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt", HttpCompletionOption.ResponseHeadersRead, tokenSource.Token);
                
                var totalBytes = response.Content.Headers.ContentLength;
                var readBytes = 0L;

                await using var fileStream = new FileStream(destino, FileMode.Create, FileAccess.Write);

                await using var contentStream = await response.Content.ReadAsStreamAsync(tokenSource.Token);

                var buffer = new byte[81920];
                int bytesRead;

                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, tokenSource.Token)) > 0) {
                    await fileStream.WriteAsync(buffer, 0, bytesRead, tokenSource.Token);
                    readBytes += bytesRead;
                    Console.WriteLine($"Progresso: {readBytes}/{totalBytes}");
                }

            } catch (OperationCanceledException ex) {
                if (tokenSource.IsCancellationRequested) {
                    Console.WriteLine($"\nDownload cancelado pelo usuário: {ex.Message}");
                } else {
                    Console.WriteLine("\nO tempo limite para download foi atingido");
                }
            } catch (HttpRequestException ex) {
                Console.WriteLine($"\nOcorreu um erro de rede: {ex.Message}");
            } catch (Exception ex) {
                Console.WriteLine($"\nOcorreu um erro desconhecido: {ex.Message}");
            } finally {
                Console.WriteLine("Download concluído");
            }
        }
    }
}
