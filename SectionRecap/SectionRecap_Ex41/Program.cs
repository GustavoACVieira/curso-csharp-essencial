namespace SectionRecap_Ex41 {
    internal class Program {
        static async Task Main(string[] args) {
            var result = await SomarAsync(3, 9);
            Console.WriteLine("Resultado: " + result);
        }

        static async Task<int> SomarAsync(int a, int b) {
            await Task.Delay(2000);
            return a + b;
        }
    }
}
