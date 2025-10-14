using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex33 {
    internal class Pedido {
        public event EventHandler<PedidoEventArgs>? PedidoConcluido;

        public void Concluir(string produto, double valor) {
            Console.WriteLine("Concluindo pedido...");
            PedidoConcluido?.Invoke(this, new PedidoEventArgs(produto, valor));
        }
    }
}
