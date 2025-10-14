using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex02 {
    internal interface ISalvar {
        void Salvar();
        public void Compactar() {
            Console.WriteLine("Compactando...");
        }
    }
}
