using Section13_Ex01;

namespace Section13_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            var funca = FonteDeDados.GetFuncionarios();

            var resultOrdemSal = funca.OrderBy(x => x.Salario);
            Console.WriteLine("\nOrdenado em Ordem de Salário: ");
            foreach (var rOS in resultOrdemSal)
                Console.WriteLine($"{rOS.Nome} : {rOS.Salario}");

            var resultOrdemMesmoSal = funca.OrderByDescending(x => x.Salario);
            Console.WriteLine("\nOrdenado em Ordem, mesmo salario: ");
            foreach (var rOMS in resultOrdemMesmoSal)
                Console.WriteLine($"{rOMS.Nome} : {rOMS.Salario}");

            Console.WriteLine("\nReverse");
            var resultReverse = funca;
            resultReverse.Reverse();
            foreach (var rR in resultReverse)
                Console.WriteLine($"{rR.Nome} : {rR.Salario}");

            var menorSal = funca.Min(x => x.Salario);
            var maiorSal = funca.Max(x => x.Salario);
            var funcaMaiorSal = funca.MaxBy(x => x.Salario);
            var funcaMenorSal = funca.MinBy(x => x.Salario);

            Console.WriteLine($"\nMaior salário: {maiorSal}\nMenor salário: {menorSal}");
            Console.WriteLine($"Funcionário com maior salário:\nNome: {funcaMaiorSal.Nome} - Salário: {funcaMaiorSal.Salario} - Idade: {funcaMaiorSal.Idade}");
            Console.WriteLine($"Funcionário com menor salário:\nNome: {funcaMenorSal.Nome} - Salário: {funcaMenorSal.Salario} - Idade: {funcaMenorSal.Idade}");
        }
    }
}
