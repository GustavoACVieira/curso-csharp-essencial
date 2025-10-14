using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex33 {
    internal class PedidoEventArgs : EventArgs {
        public string? Produto { get; set; }
        public double Valor { get; set; }

        public PedidoEventArgs(string produto, double valor) {
            Produto = produto;
            Valor = valor;
        }
    }
}
