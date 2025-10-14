namespace SectionRecap_Ex39 {
    internal class Program {
        static async Task Main(string[] args) {
            await Task.Run (() => ProcessarDadosAsync());
        }

        public static async Task ProcessarDadosAsync() {
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine($"Processando item {i}...");
                await Task.Delay(1000);
            }
            Console.WriteLine("Processos Concluídos!!");
        }
    }
}
