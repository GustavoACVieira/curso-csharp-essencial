namespace Section6 {
    internal class Program {
        static void Main(string[] args) {
            Funcionario funci = new();
            funci.Nome = "José";
            funci.Email = "jose@email.com";
            funci.Empresa = "Google Inc.";
            funci.Salario = 9000;

            Console.WriteLine("Funcinario");
            Console.WriteLine(funci.Empresa);
            Console.WriteLine(funci.Salario);
            funci.Identificar();

            Aluno aluno = new Aluno();
            aluno.Nome = "João";
            aluno.Email = "joão@email.com";
            aluno.Curso = "Engenharia";
            aluno.Nota = 9;

            Console.WriteLine("\nAluno\n");
            Console.WriteLine(aluno.Curso);
            Console.WriteLine(aluno.Nota);
            aluno.Identificar();
        }
    }
}
