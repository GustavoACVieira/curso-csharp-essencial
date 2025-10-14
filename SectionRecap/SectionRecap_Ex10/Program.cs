namespace SectionRecap_Ex10 {
    internal class Program {
        static void Main(string[] args) {
            var alunos = Aluno.GetAlunos();

            var alunosMaiorSete = alunos.Select(x => x).Where(x => x.Nota > 7);
            var alunosMaiorSeteOrdenado = alunosMaiorSete.OrderByDescending(x => x.Nota);
            Console.WriteLine("\nAlunos com nota maior que 7: ");
            foreach (var alMaior in alunosMaiorSeteOrdenado) {
                Console.WriteLine($"Nome: {alMaior.Nome} - Idade: {alMaior.Idade} - Nota: {alMaior.Nota:F1}");
            }
        }
    }
}
