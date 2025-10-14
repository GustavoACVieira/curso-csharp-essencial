namespace Section7_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>();

            alunos.Add(1, new Aluno("Maria", 7));
            alunos.Add(5, new Aluno("Eric", 8));
            alunos.Add(3, new Aluno("Ana", 9));
            alunos.Add(4, new Aluno("Alex", 6));
            alunos.Add(2, new Aluno("Diná", 5));

            Console.WriteLine("\nLista de Alunos e suas notas: ");
            Console.WriteLine("Relação:\nID\tNome\tNota");
            ExibirColecao(alunos);

            Console.WriteLine("Informe o ID do aluno que deseja localizar: ");
            int codigo = int.Parse(Console.ReadLine());

            var resultado = alunos.ContainsKey(codigo);

            if (resultado) {
                Console.WriteLine("Informe a nota: ");
                int nota = int.Parse(Console.ReadLine());
                alunos[codigo].Nota = nota;
            }
            Console.WriteLine("Aluno localizado");
            ExibirColecao(alunos);

            alunos.Remove(2);
            Console.WriteLine("\nRemovendo...");
            Console.WriteLine("\nLista de Alunos e suas notas após remover 1 aluno: ");
            Console.WriteLine("Relação:\nID\tNome\tNota");
            ExibirColecao(alunos);

            alunos.Add(8, new Aluno("Vilma", 7));

            //SortedDictionary<int, Aluno> alunosOrdenado = new SortedDictionary<int, Aluno>(alunos);
            Dictionary<int, Aluno> alunosOrdenados = new Dictionary<int, Aluno>(alunos.OrderBy(x => x.Key));
            Console.WriteLine("\nLista de Alunos e suas notas ordenados: ");
            Console.WriteLine("Relação:\nID\tNome\tNota");
            ExibirColecao(alunosOrdenados);

            alunos.Clear();
            Console.WriteLine("\nLista de Alunos vazia: ");
            Console.WriteLine("Relação:\nID\tNome\tNota");
            ExibirColecao(alunos);
        }

        private static void ExibirColecao(Dictionary<int, Aluno> alunos) {
            foreach (var item in alunos) {
                Console.WriteLine($"{item.Key}\t{item.Value.Nome}\t{item.Value.Nota}");
            }
        }
    }
}
