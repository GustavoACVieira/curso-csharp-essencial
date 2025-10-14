using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex13 {
    internal class ContaBancaria {
        private double saldo;

        public double _Saldo { get; set; }
        public string Nome { get; set; }

        public ContaBancaria(double saldo, string nome) {
            _Saldo = saldo;
            Nome = nome;
        }

        public void Depositar(double saldo) {
            _Saldo += saldo;
        }

        public void Sacar(double saldo) {
            if ((_Saldo - saldo) > 0)
                _Saldo -= saldo;
            else
                Console.WriteLine("Saque inválido! Saldo insuficiente!");
        }
    }
}
