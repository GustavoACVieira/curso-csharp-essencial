using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13_Ex01 {
    public class Aluno {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Nota { get; set; }
        public List<string> Cursos { get; set; }

        public Aluno(string nome, int idade, int nota, List<string> cursos) {
            Nome = nome;
            Idade = idade;
            Nota = nota;
            Cursos = cursos;
        }

        public override string ToString() {
            return $"{Nome} ({Idade} anos) - Nota: {Nota}";
        }
    }
}
