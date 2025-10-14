using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex03 {
    internal interface IVeiculo {
        void Dirigir();
        bool Abastecer(int qtdGas);
    }
}
