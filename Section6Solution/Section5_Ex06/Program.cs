namespace Section5_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            Pessoa[] pessoas = new Pessoa[3];

            for (int i = 0; i < pessoas.Length; i++) {
                Console.WriteLine($"Informe o nome da {i + 1} pessoa: ");
                pessoas[i] = new Pessoa(Console.ReadLine());
            }

            foreach (var item in pessoas) {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
