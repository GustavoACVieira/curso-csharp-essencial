namespace Section13_OperadoresDeProjecao {
    internal class Program {
        static void Main(string[] args) {
            IEnumerable<Aluno> alunos = FontesDeDados.GetAlunos().ToList();

            foreach (var aluno in alunos)
                Console.WriteLine($"{aluno.Nome} : {aluno.Nota}");

            Console.WriteLine();

            IEnumerable<string> nomesAlunos = FontesDeDados.GetAlunos().Select(x => x.Nome);

            foreach (var nome in nomesAlunos)
                Console.WriteLine(nome);

            Console.WriteLine();

            List<Aluno> lista = FontesDeDados.GetAlunos().Select( x => new Aluno() {
                                                                Nome = x.Nome,
                                                                Idade = x.Idade
                                                            }).ToList();

            foreach (var aluno in lista)
                Console.WriteLine($"{aluno.Nome} : {aluno.Idade}");

            Console.WriteLine();

            var alunosTipoAnonimo = FontesDeDados.GetAlunos().Select( x => new {
                                                                NomeAluno = x.Nome,
                                                                IdadeAluno = x.Idade,
                                                                NotaAluno = x.Nota
                                                            }).ToList();

            foreach (var aluno in alunosTipoAnonimo)
                Console.WriteLine($"{aluno.NomeAluno} : {aluno.IdadeAluno} : {aluno.NotaAluno}");

            Console.WriteLine();

            var funcionarios = FontesDeDados.GetFuncionarios().Select(x => new {
                NomeFunc = x.Nome,
                IdadeFunc = x.Idade,
                SalarioFunc = x.Salario
            }).ToList();

            foreach(var funcionario in funcionarios)
                Console.WriteLine($"{funcionario.NomeFunc} : {funcionario.IdadeFunc} : {funcionario.SalarioFunc.ToString("C")}");

            Console.WriteLine();

            IEnumerable<string> cursosMany = FontesDeDados.GetAlunos().SelectMany(x => x.Cursos);

            foreach (var cursos in cursosMany)
                Console.Write($"{cursos} - ");

            Console.WriteLine();
        }
    }
}
