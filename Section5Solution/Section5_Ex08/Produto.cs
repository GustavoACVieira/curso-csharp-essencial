using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex08 {
    internal class Produto {
        public string? Nome;
        public decimal Preco;

        public Produto() {
        }

        public Produto (string? Nome, decimal Preco) {
            this.Nome = Nome;
            this.Preco = Preco;
        }

        public static decimal ExibirRelacaoProd(List<Produto> lista) {
            var sumTotal = 0.0M;
            foreach (Produto produto in lista) {
                Console.WriteLine($"Nome: {produto.Nome} - Preço: {produto.Preco}");
                sumTotal += produto.Preco;
            }
            return sumTotal;
        }
    }
}
