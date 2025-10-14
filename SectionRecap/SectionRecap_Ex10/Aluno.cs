using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex10 {
    internal class Aluno {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }

        public Aluno(string? nome, int idade, double nota) {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }

        public static List<Aluno> GetAlunos() {
            return new List<Aluno> {
            new Aluno("Maria", 18, 9.2),
            new Aluno("Gustavo", 25, 8.7),
            new Aluno("João", 20, 5.5),
            new Aluno("Ana", 22, 7.3),
            new Aluno("Paulo", 24, 6.8),
            new Aluno("Clara", 19, 9.0)
            };
        }
    }
}
