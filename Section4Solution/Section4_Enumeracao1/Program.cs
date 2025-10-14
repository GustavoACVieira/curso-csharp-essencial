using System;
using Enumeracoes;

namespace Section4_Enumeracao1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(DiasDaSemana.DOMINGO);
            Console.WriteLine(DiasDaSemana.TERÇA);

            int dia1 = (int)DiasDaSemana.DOMINGO;
            int dia2 = (int)DiasDaSemana.TERÇA;

            Console.WriteLine($"\n{DiasDaSemana.DOMINGO} vale : {dia1}");
            Console.WriteLine($"\n{DiasDaSemana.TERÇA} vale : {dia2}");

            Console.WriteLine("----------");

            Console.WriteLine($"{Categorias.MODA} - {(int)Categorias.MODA}");
            Console.WriteLine($"{Categorias.AUTOMOTIVO} - {(int)Categorias.AUTOMOTIVO}");
            Console.WriteLine($"{Categorias.ARTES} - {(int)Categorias.ARTES}");
            Console.WriteLine($"{Categorias.BEBIDAS} - {(int)Categorias.BEBIDAS}");
            Console.WriteLine($"{Categorias.LIVROS} - {(int)Categorias.LIVROS}");
            Console.WriteLine($"{Categorias.BRINQUEDOS} - {(int)Categorias.BRINQUEDOS}");

            Console.WriteLine("----------");

            Console.WriteLine("Informe a categoria que deseja: ");
            int valor = int.Parse( Console.ReadLine() );

            var nomeMembroEnum = (Categorias)valor;
            Console.WriteLine($"\nVocê selecionou a categoria: {nomeMembroEnum}");
        }
    }
}