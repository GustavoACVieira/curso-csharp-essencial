using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex03 {
    internal class FonteDeDados {
        public static List<Aluno> GetAlunos() {
            List<Aluno> alunos = new() {
                new Aluno() { Nome = "Maria", Nota = 8.75},
                new Aluno() { Nome = "Manoel", Nota = 6.95},
                new Aluno() { Nome = "Amanda", Nota = 7.25},
                new Aluno() { Nome = "Carlos", Nota = 6.55 },
                new Aluno() { Nome = "Jaime", Nota = 8.5},
                new Aluno() { Nome = "Debora", Nota = 5.95},
                new Aluno() { Nome = "Alicia", Nota = 9.25},
                new Aluno() { Nome = "Sandra", Nota = 5.55},
                new Aluno() { Nome = "Marta", Nota = 7.85 },
                new Aluno() { Nome = "Sueli", Nota = 9.15 },
            };
            return alunos;
        }

        public static double ExibirListaAlunos(List<Aluno> al) {
            var somaNotas = 0.0;
            foreach (var item in al) {
                Console.WriteLine($"{item.Nome}\t{item.Nota}");
                somaNotas += item.Nota;
            }
            return somaNotas;
        }
    }
}
