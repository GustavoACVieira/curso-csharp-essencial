using Section13_Ex01;

namespace Section13_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            var alunos = FonteDeDados.GetAlunos();
            var somaNotas = alunos.Sum(x => x.Nota);
            var mediaNotas = alunos.Average(x => x.Nota);
            string agregadoDeNotas = alunos.Aggregate<Aluno, string, string>("Nomes: ", (semente, aluno) => semente += aluno.Nota + ", ",
                                                                                         resultado=> resultado.Substring(0, resultado.Length-2));

            Console.WriteLine($"Soma das notas: {somaNotas}\nMédia das Notas: {mediaNotas:F0}\n");
            foreach (var item in agregadoDeNotas) {
                Console.Write(item);
            }
        }
    }
}
