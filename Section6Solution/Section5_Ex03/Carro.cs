using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex03 {
    internal class Carro : IVeiculo {
        private int _combustivel = 0;
        public int Combustivel {
            get { return _combustivel; }
            set { _combustivel = value; } 
        }

        public Carro(int qtdGasInit) {
            Combustivel = qtdGasInit;
        }

        public Carro() {
        }

        public bool Abastecer(int qtdGas) {
            Combustivel += qtdGas;
            return true;
        }

        public void Dirigir() {
            if (Combustivel > 0)
                Console.WriteLine("Dirigindo o carro...");
            else
                Console.WriteLine("Sem gasolina...");
        }
    }
}
