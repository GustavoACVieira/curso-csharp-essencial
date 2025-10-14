using System;

namespace Section2_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            var nome = "Paulo";
            var idade = 17;
            var nota = 7.5f;

            Console.WriteLine("O aluno " + nome + " tem " + idade + " anos e nota " + nota);
            Console.WriteLine();
            Console.WriteLine($"O aluno {nome} tem {idade} anos e nota {nota}");
            Console.WriteLine();
            Console.WriteLine($"O aluno \n{nome} \ntem \n{idade} \nanos e nota \n{nota}");
        }
    }
}