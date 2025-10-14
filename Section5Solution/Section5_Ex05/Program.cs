namespace Section5_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o tamanho do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] valoresInteiros = new int[tamanho];
            for (int i = 0; i < tamanho; i++) {
                valoresInteiros[i] = i + 1;
            }

            string opcao;
            do {
                Console.WriteLine("Informe um número para ser procurado: ");
                int numeroEscolhido = int.Parse(Console.ReadLine());
                var numeroSearch = valoresInteiros.ToList().BinarySearch(numeroEscolhido);

                if (numeroSearch >= 0) 
                    Console.WriteLine($"O número existe e está na posição: {numeroSearch}");
                else
                    Console.WriteLine("Não existe este número no array");

                Console.WriteLine("Deseja continuar? S OR fim");
                opcao = Console.ReadLine();
            } while (opcao != "fim");
        }
    }
}
