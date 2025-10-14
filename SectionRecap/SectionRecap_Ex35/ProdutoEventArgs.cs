using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex35 {
    internal class ProdutoEventArgs : EventArgs {
        public string? Nome { get; set; }
        public int Qtd { get; set; }
    }
}
