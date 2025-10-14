using System;

namespace Section4 {
    internal class Program {
        static void Main(string[] args) {
            /*Tipos de instancia:
            Pessoa p1 = new();
            var p1 = new Pessoa();  
            Pessoa p1 = new Pessoa();

            p1.Nome = "Maria";
            p1.Idade = 25;
            p1.Sexo = "Feminino";
            Console.WriteLine($"Nome: {p1.Nome} - Idade: {p1.Idade} - Sexo: {p1.Sexo}");

            Pessoa p2 = p1;

            Console.WriteLine($"Nome: {p2.Nome} - Idade: {p2.Idade} - Sexo: {p2.Sexo}");*/

            Pessoa p1 = new Pessoa("Maria", 19);

            Console.WriteLine(p1.Nome + " - " + p1.Idade);
            Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

            Pessoa p2 = new Pessoa("Manoel", 20);
            Console.WriteLine(p2.Nome + " - " + p2.Idade);
            Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);
        }
    }
}