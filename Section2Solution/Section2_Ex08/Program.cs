using System;

namespace Section2_Ex08 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe sua senha: ");
            string senha = Console.ReadLine();

            var resultado = (nome == "admin" || nome == "maria") && senha == "123" ? "Login feito com sucesso" : "Login inválido";

            Console.WriteLine(resultado);
        }
    }
}