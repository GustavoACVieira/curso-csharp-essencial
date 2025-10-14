namespace Section5_Random1 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();

            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(20));
            Console.WriteLine(random.Next(10,20));
            Console.WriteLine(random.NextDouble());

            Console.WriteLine();

            Random random2 = new Random(2023);

            Console.WriteLine(random2.Next());
            Console.WriteLine(random2.Next(20));
            Console.WriteLine(random2.Next(10, 20));
            Console.WriteLine(random2.NextDouble());

            Console.WriteLine();
            Console.WriteLine("Sorteio da MegaSena");

            Random random3 = new Random();

            int[]  numerosSorteados = new int[6];

            for (int i = 0; i < 6; i++) {
                int numeroAleatorio;
                do {
                    numeroAleatorio = random.Next(1, 61);
                } while (numerosSorteados.Contains(numeroAleatorio));

                numerosSorteados[i] = numeroAleatorio;
            }
            
            Array.Sort(numerosSorteados);

            Console.WriteLine("Números Sorteados: ");
            Console.WriteLine(string.Join(" ", numerosSorteados));
        }
    }
}
