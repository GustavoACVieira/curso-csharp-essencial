using System.Collections;

namespace Section5_Ex07 {
    internal class Program {
        static void Main(string[] args) {
            ArrayList listaPessoa = new();

            for (int i = 0; i < 3; i++) {
                Console.WriteLine($"Informe o nome da pessoa {i + 1}: ");
                string nome = Console.ReadLine();
                Console.WriteLine($"Informe a idade da pessoa {i + 1}: ");
                int idade = int.Parse(Console.ReadLine());

                listaPessoa.Add(new Pessoa() { Nome = nome, Idade = idade });
            }
            Pessoa.Exibir(listaPessoa);

            Console.WriteLine();
            listaPessoa.Add(new Pessoa() { Nome = "Jaime", Idade = 20 });
            listaPessoa.Add(new Pessoa() { Nome = "Tânia", Idade = 18 });
            Pessoa.Exibir(listaPessoa);

            Console.WriteLine();
            listaPessoa.RemoveAt(listaPessoa.Count - 1);
            Pessoa.Exibir(listaPessoa);
        }
    }
}
