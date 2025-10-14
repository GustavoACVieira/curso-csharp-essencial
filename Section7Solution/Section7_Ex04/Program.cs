namespace Section7_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            List<Aluno> listaAlunos = new List<Aluno>();

            listaAlunos.Add(new Aluno("Gustavo", 19, "Masculino"));
            listaAlunos.Add(new Aluno("Kaio", Sexo: "Masculino", Idade: 25));
            listaAlunos.Add(new Aluno(Sexo: "Feminino", Idade: 21, Nome: "Maria"));
            listaAlunos.Add(new Aluno("Carlos", 33, "Masculino"));
            listaAlunos.Add(new Aluno("Antonieta", 19, "Feminino"));

            Console.WriteLine("Lista de alunos: ");
            Console.WriteLine("Relação: ");
            Console.WriteLine("\nNome\tIdade\tSexo");
            foreach (var item in listaAlunos) {
                Console.WriteLine($"{item.Nome}\t{item.Idade}\t{item.Sexo}");
            }
        }
    }
}
