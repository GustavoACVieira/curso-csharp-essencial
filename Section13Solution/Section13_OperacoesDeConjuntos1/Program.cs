using Section13_OperadoresDeProjecao;

namespace Section13_OperacoesDeConjuntos1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("idades -> 30, 33, 35, 36, 40, 30, 33, 36, 30, 40");

            var idadeDistintas = FontesDeDados.GetIdades().Distinct().ToList();

            Console.Write("idades distintas -> ");
            foreach (var idadeD in idadeDistintas)
                Console.Write($"{idadeD}, ");
            
            Console.WriteLine();
        }
    }
}
