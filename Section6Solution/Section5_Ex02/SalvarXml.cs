using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex02 {
    internal class SalvarXml : ArquivoBase, ISalvar {
        public void Salvar() {
            Console.WriteLine("Salvando xml"); ;
        }

        public override void Nome() {
            Console.WriteLine("Definir nome xml");
        }
    }
}
