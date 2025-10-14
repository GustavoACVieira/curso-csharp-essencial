using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13_Paginacao {
    public class Aluno {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }

        public static List<Aluno> GetAlunos() {
            List<Aluno> alunos = new List<Aluno>() {
                new Aluno { Id = 1, Nome = "Ana Souza", Curso = "Engenharia de Software" },
                new Aluno { Id = 2, Nome = "Bruno Lima", Curso = "Direito" },
                new Aluno { Id = 3, Nome = "Carla Nunes", Curso = "Administração" },
                new Aluno { Id = 4, Nome = "Diego Alves", Curso = "Ciência da Computação" },
                new Aluno { Id = 5, Nome = "Eduarda Martins", Curso = "Psicologia" },
                new Aluno { Id = 6, Nome = "Felipe Ribeiro", Curso = "Engenharia Civil" },
                new Aluno { Id = 7, Nome = "Gabriela Torres", Curso = "Medicina" },
                new Aluno { Id = 8, Nome = "Henrique Silva", Curso = "Sistemas de Informação" },
                new Aluno { Id = 9, Nome = "Isabela Castro", Curso = "Design Gráfico" },
                new Aluno { Id = 10, Nome = "João Pereira", Curso = "Arquitetura" },
                new Aluno { Id = 11, Nome = "Karla Mendes", Curso = "Engenharia Elétrica" },
                new Aluno { Id = 12, Nome = "Lucas Barbosa", Curso = "Educação Física" },
                new Aluno { Id = 13, Nome = "Mariana Rocha", Curso = "Enfermagem" },
                new Aluno { Id = 14, Nome = "Natália Gonçalves", Curso = "Publicidade e Propaganda" },
                new Aluno { Id = 15, Nome = "Otávio Fernandes", Curso = "Matemática" },
                new Aluno { Id = 16, Nome = "Patrícia Duarte", Curso = "Contabilidade" },
                new Aluno { Id = 17, Nome = "Rafael Costa", Curso = "Física" },
                new Aluno { Id = 18, Nome = "Sara Oliveira", Curso = "Biologia" },
                new Aluno { Id = 19, Nome = "Tiago Moreira", Curso = "Engenharia Mecânica" },
                new Aluno { Id = 20, Nome = "Vanessa Cardoso", Curso = "Ciências Econômicas" }
            };

            return alunos;
        }
    }
}
