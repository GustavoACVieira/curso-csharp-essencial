namespace Section5_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            string[,] alunos = new string[2, 5];

            for (int i = 0; i < alunos.GetLength(0); i++) {
                for (int j = 0; j < alunos.GetLength(1); j++) {
                    Console.WriteLine($"Informe o aluno da posição [{i},{j}] : ");
                    alunos[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine("\nAlunos:");
            for (int i = 0; i < alunos.GetLength(0); i++) {
                for (int j = 0; j < alunos.GetLength(1); j++) {
                    Console.Write($"[{i},{j}] = {alunos[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
