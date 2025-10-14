namespace Section13_Paginacao {
    internal class Program {
        static void Main(string[] args) {
            int RegistrosPorPagina = 5;
            int NumeroPagina;

            do {
                Console.WriteLine("\nQual página o usuário irá exibir entre 1 e 4: ");
                if (int.TryParse(Console.ReadLine(), out NumeroPagina)) {
                    if (NumeroPagina > 0 && NumeroPagina < 5) {
                        var alunos = Aluno.GetAlunos().Skip((NumeroPagina -1) * RegistrosPorPagina).Take(RegistrosPorPagina).ToList();

                        Console.WriteLine("\nPag. : " + NumeroPagina);

                        foreach (var aluno in alunos) {
                            Console.WriteLine($"Id: {aluno.Id} - Nome: {aluno.Nome} - Curso: {aluno.Curso}");
                        }

                    } else
                        Console.WriteLine("\nInforme uma página válida!");
                } else
                    Console.WriteLine("\nInforme uma página válida!");
            } while (true);
        }
    }
}
