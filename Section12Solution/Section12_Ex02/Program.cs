using System.Threading.Tasks;

namespace Section12_Ex02 {
    internal class Program {
        static async Task Main(string[] args) {
            Console.WriteLine("Informe a cidade que deseja buscar a temperatura: ");
            string cidade = Console.ReadLine();

            double temperatura = await BuscarTemperaturaAsync(cidade);
            Console.WriteLine($"A temperatura em {cidade} é de {temperatura}°C");
        }

        static async Task<double> BuscarTemperaturaAsync(string cidade) {
            Console.WriteLine("Buscando dados na API......");
            await Task.Delay(3456);
            return new Random().Next(15, 35);
        }
    }
}
