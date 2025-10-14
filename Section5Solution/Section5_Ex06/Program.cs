namespace Section5_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            float[,] notasAlunos = new float[2,5];
            float grupo1 = 0.0f;
            float grupo2 = 0.0f;

            for (int i = 0; i < notasAlunos.GetLength(0); i++) {
                Console.WriteLine($"Informe as notas do Grupo{i + 1}: ");
                for (int j = 0; j <  notasAlunos.GetLength(1); j++) {
                    Console.WriteLine($"Aluno {j + 1}: ");
                    notasAlunos[i, j] = float.Parse(Console.ReadLine());
                    if (i == 0) 
                        grupo1 += notasAlunos[i, j];
                    else
                        grupo2 += notasAlunos[i, j];
                }
            }

            Console.WriteLine($"Média grupo1: {grupo1 / 5}");
            Console.WriteLine($"Média grupo1: {grupo2 / 5}");
        }
    }
}
