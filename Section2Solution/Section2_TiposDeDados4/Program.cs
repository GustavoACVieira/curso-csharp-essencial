using System;

namespace Section2_TiposDeDados3 {
    internal class Program {
        static void Main(string[] args) {
            string nome = "Curso C#";
            String titulo = "Curso C# Essencial";

            Console.WriteLine(nome);
            Console.WriteLine(titulo);
            Console.WriteLine();

            string valor = "Isto é uma string";
            valor = "Isto é uma string alterada";

            valor = "teste";

            //StringBuilder

            object nota = 10;
            object valor2 = 8.55m;
            object nome2 = "Maria";
            object ativa = true;
            object letra = 'A';

            /*dynamic:  Mesma coisa só que pode usar reflection e linguagens dinâmicas
            dynamic nota = 10;
            dynamic valor2 = 8.55m;
            dynamic nome2 = "Maria";
            dynamic ativa = true;
            dynamic letra = 'A'; */

            Console.WriteLine(nota);
            Console.WriteLine(valor2);
            Console.WriteLine(nome2);
            Console.WriteLine(ativa);
            Console.WriteLine(letra);
        }
    }
}