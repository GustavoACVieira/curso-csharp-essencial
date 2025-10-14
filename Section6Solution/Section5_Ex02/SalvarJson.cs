using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex02 {
    internal class SalvarJson : ArquivoBase, ISalvar {
        public void Salvar() {
            Console.WriteLine("Salvando JSON");
        }

        public override void Nome() {
            Console.WriteLine("Definindo nome JSON");
        }
    }
}
