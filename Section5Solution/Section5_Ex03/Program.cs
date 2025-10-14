namespace Section5_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            List<Aluno> listaAlunos = FonteDeDados.GetAlunos();

            Console.WriteLine("Lista Original: ");
            Console.WriteLine("Relação Alunos:");
            Console.WriteLine("Nome |\t Nota");
            var average = FonteDeDados.ExibirListaAlunos(listaAlunos);
            Console.WriteLine($"\nMédia de Notas: {average / listaAlunos.Count:F2}");
            Console.WriteLine($"\nQuantidade de Alunos: {listaAlunos.Count}");

            listaAlunos.Add(new Aluno() { Nome = "Bia", Nota = 7.75});
            listaAlunos.Add(new Aluno() { Nome = "Mario", Nota = 8.95});
            Console.WriteLine("\nLista Após Ex02: ");
            Console.WriteLine("Relação Alunos:");
            Console.WriteLine("Nome |\t Nota");
            FonteDeDados.ExibirListaAlunos(listaAlunos);

            var remAluno = listaAlunos.FindIndex(x => x.Nome.Equals("Amanda"));
            Console.WriteLine($"\nLocalização da Amanda: {remAluno}");
            listaAlunos.RemoveAt(remAluno);
            Console.WriteLine("\nLista Após Ex03: ");
            Console.WriteLine("Relação Alunos:");
            Console.WriteLine("Nome |\t Nota");
            FonteDeDados.ExibirListaAlunos(listaAlunos);

            var listaOrdenada = listaAlunos.OrderBy(n => n.Nome).ToList();
            Console.WriteLine("\nLista Após Ex04: ");
            Console.WriteLine("Relação Alunos:");
            Console.WriteLine("Nome |\t Nota");
            FonteDeDados.ExibirListaAlunos(listaOrdenada);

            var alunoMaiorOito = listaAlunos.FindAll(x => x.Nota >= 8);
            Console.WriteLine("\nLista Após Ex05: ");
            Console.WriteLine("Relação Alunos:");
            Console.WriteLine("Nome |\t Nota");
            FonteDeDados.ExibirListaAlunos(alunoMaiorOito);
        }
    }
}
