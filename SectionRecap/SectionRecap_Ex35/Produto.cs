using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex35 {
    internal class Produto {
        private const int LIMITE_ESTOQUE = 5;
        public string? Nome { get; set; }
        public int Qtd { get; set; }
        
        public Produto(string? nome, int qtd) {
            Nome = nome;
            Qtd = qtd;
        }

        public void Vender(string nome, int qtd) {
            if ((Qtd - qtd) < LIMITE_ESTOQUE) {
                EventoEstoqueBaixo?.Invoke(this, new ProdutoEventArgs { Nome = nome, Qtd = (Qtd - qtd)});
            }
            Qtd -= qtd;
        }

        public event EventHandler<ProdutoEventArgs>? EventoEstoqueBaixo;
    }
}
