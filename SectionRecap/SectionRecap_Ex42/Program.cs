using System.Threading.Tasks;

namespace SectionRecap_Ex42 {
    internal class Program {
        static async Task Main(string[] args) {
            var result1 = await SomarRapidoAsync(3, 6);
            Console.WriteLine($"Resultado da primeira soma: {result1}");

            var result2 = await SomarRapidoAsync(15, 3);
            Console.WriteLine($"Resultado da segunda soma: {result2}");

        }

        static async ValueTask<int> SomarRapidoAsync(int a, int b) {
            if ((a + b) < 10)
                return a + b;
            await Task.Delay(2500);
            return await Task.Run(() => a + b);
        }
    }
}
