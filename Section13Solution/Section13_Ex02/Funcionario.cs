using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13_Ex01 {
    public class Funcionario {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, int idade, decimal salario) {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public override string ToString() {
            return $"{Nome} ({Idade} anos) - Salário: R${Salario:F2}";
        }
    }

}
