using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex09 {
    public class Estoque {
        public event EventHandler? EstoqueBaixo;

        public string? Nome { get; set; }
        public int QtdEstoque {  get; set; }

        public Estoque(string nome, int qtdEstoque) {
            Nome = nome;
            QtdEstoque = qtdEstoque;
        }

        public void AdicionarEstoque(int qtd) {
            QtdEstoque += qtd;

            if (QtdEstoque < 5) {
                EstoqueBaixo?.Invoke(this, EventArgs.Empty);
            }
        }

        public void SubtrairEstoque(int qtd) {
            QtdEstoque -= qtd;

            if (QtdEstoque < 5) {
                EstoqueBaixo?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
