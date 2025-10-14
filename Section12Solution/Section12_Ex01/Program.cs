using System.Threading.Tasks;

namespace Section12_Ex01 {
    internal class Program {
        static async Task Main(string[] args) {
            await ProcessarArquivoAsync();
        }

        static async Task ProcessarArquivoAsync() {
            Console.WriteLine("Executando o processo......");
            await Task.Delay(3000);
            Console.WriteLine("Fim do Processo!");
        }
    }
}
