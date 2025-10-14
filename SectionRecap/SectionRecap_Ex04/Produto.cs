using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex04 {
    internal class Produto {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }

        public Produto(int id, string nome, double preco) {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public void ExibirInfo() {
            Console.WriteLine($"\nId: {Id} - Nome: {Nome} - Preço: {Preco:F2}");
        }
    }
}
