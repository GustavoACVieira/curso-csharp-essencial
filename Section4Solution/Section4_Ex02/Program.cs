using System;

namespace Section4_Ex02 {
    internal class Program {
        public struct Cliente {
            public string? Nome { get; set; }
            public string? Email { get; set; }
            private int idade;
            public int Idade { 
                get { return idade; }
                set {
                    if (value < 18)
                        idade = 18;
                    else
                        idade = value;
                }
            }

            public Cliente(string? Nome, string? Email, int idade) {
                this.Nome = Nome;
                this.Email = Email;
                this.idade = idade;
            }

            public static void ExibirInfo(string? nome, string? email, int idade = 18) {
                Console.WriteLine($"Nome: {nome} - Email: {email} - Idade: {idade}");
            }
        }

        static void Main(string[] args) {
            Cliente cliente = new Cliente("Gustavo", "gustavo@gmail.com", 19);

            Cliente.ExibirInfo(cliente.Nome, cliente.Email, cliente.Idade);
            Cliente.ExibirInfo(cliente.Nome, cliente.Email);
        }
    }
}