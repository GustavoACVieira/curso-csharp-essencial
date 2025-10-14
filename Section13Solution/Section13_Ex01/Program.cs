using System.Linq;

namespace Section13_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            var alunos = FonteDeDados.GetAlunos();
            var alunosNotaMaiorOito = alunos.Where(n => n.Nota > 8);

            Console.WriteLine("Alunos com nota maior que 8:");
            foreach (var al in alunosNotaMaiorOito) 
                Console.WriteLine($"{al.Nome} - {al.Nota}");

            var cursos = alunos.SelectMany(c => c.Cursos);
            Console.WriteLine("\nCursos: ");
            foreach (var cur in cursos)
                Console.WriteLine(cur);

            var nomesDistintos = alunos.DistinctBy(x => x.Nome);
            Console.WriteLine("\nAlunos nomes distintos: ");
            foreach (var nd in nomesDistintos)
                Console.WriteLine($"{nd.Nome}");

            Console.WriteLine("\nCursos sem alunos: ");
            var cursosListas = FonteDeDados.GetCursos();
            var cursosSemAlunos = cursosListas.Except(alunos.SelectMany(a => a.Cursos).Distinct());
            foreach (var cSA in cursosSemAlunos)
                Console.WriteLine($"{cSA}");

            Console.WriteLine("\nCursos em Comum: ");
            var cursosListas2 = FonteDeDados.GetCursos();
            var cursosComum = cursosListas.Intersect(alunos.SelectMany(a => a.Cursos)).ToList();
            foreach (var cC in cursosComum)
                Console.WriteLine($"{cC}");

            Console.WriteLine("\nFrutas:");
            var frutas = FonteDeDados.GetFrutas();
            var produtos = FonteDeDados.GetProdutos();

            var frutasProdutos = frutas.Union(produtos).ToList();
            foreach (var fP in frutasProdutos)
                Console.WriteLine(fP.ToString());

            Console.WriteLine("\nAlunos e Cursos:");
            var al1 = FonteDeDados.GetAlunos();
            var cr1 = FonteDeDados.GetCursos();

            var alMaiorSete = al1.Where(al => al.Nota > 7).Count();
            bool alPassaram = al1.All(al => al.Nota >= 6);
            bool alTirouMax = al1.Any(al => al.Nota == 10);
            bool crPython = cr1.Contains("Python");

            Console.WriteLine("Alunos que tiraram mais que 7: " + alMaiorSete);
            Console.WriteLine($"{(alPassaram ? "Todos passaram" : "Nem todos passaram")}");
            Console.WriteLine($"{(alTirouMax ? "Ao menos 1 tirou nota máxima" : "Ninguém tirou nota máxima")}");
            Console.WriteLine($"{(crPython ? "Existe um curso de Python" : "Não existe um curso de Python")}");
        }
    }
}
