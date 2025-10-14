using System.Threading.Tasks;

namespace SectionRecap_Ex44 {
    internal class Program {
        static async Task Main(string[] args) {
            int result = 0;

            try {
                result = await DividirAsync(8, 2);
                Console.WriteLine($"Resultado: {result}");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        static async Task<int> DividirAsync(int a, int b) {
            if (b == 0) throw new DivideByZeroException("Impossível dividir por zero!");
            return a / b;
        }
    }
}
