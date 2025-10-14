using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex06 {
    internal class Pessoa {
        private string? _nome;
        public string? Nome { get { return _nome; } set { _nome = value; } }

        public Pessoa(string? Nome) {
            this.Nome = Nome;
        }

        public override string ToString() {
            return $"Olá {this.Nome}";
        }
    }
}
