using System.Threading.Tasks;

namespace Section12_Ex03 {
    internal class Program {
        static async Task Main(string[] args) {
            var cache = new CacheClima();

            Console.WriteLine("Primeira busca (vai demorar)...");
            double t1 = await cache.ObterTemperaturaAsync("São Paulo");
            Console.WriteLine($"Terminou busca 1! Temperatura em São Paulo: {t1}");

            Console.WriteLine("\nSegunda busca (deve ser instantânea)...");
            double t2 = await cache.ObterTemperaturaAsync("São Paulo");
            Console.WriteLine($"Terminou busca 2! Temperatura em São Paulo: {t2}");
        }
    }
}
