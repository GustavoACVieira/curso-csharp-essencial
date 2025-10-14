namespace SectionRecap_Ex47 {
    internal class Program {
        private static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(2, 2);

        static async Task Main(string[] args) {
             await ExecutandoTarefas();
        }

        static async Task ExecutandoTarefas() {
            Console.WriteLine("Iniciando execução...\n");

            var tarefas = new List<Task>();

            for (int i = 1; i <= 5; i++) {
                string nome = $"Tarefa {i}";
                tarefas.Add(Task.Run(() => AcessandoTarefas(nome)));
            }

            await Task.WhenAll(tarefas);

            Console.WriteLine("\nTodas as tarefas concluídas!");
        }

        static async Task AcessandoTarefas(string nome) {
            Console.WriteLine($"{nome} aguardando permissão...");

            await semaphoreSlim.WaitAsync();

            try {
                Console.WriteLine($"{nome} entrou!");
                await Task.Delay(2000);
                Console.WriteLine($"{nome} terminou!");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                semaphoreSlim.Release();
            }
        }
    }
}
