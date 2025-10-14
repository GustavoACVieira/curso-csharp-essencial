using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13_OperadoresDeProjecao {
    public class FontesDeDados {
        public static List<string> GetLivros() {
            return new List<string>
            {
                "O Senhor dos Anéis",
                "1984",
                "Dom Casmurro",
                "A Revolução dos Bichos",
                "O Hobbit"
            };
        }

        public static List<string> GetPlanetas() {
            return new List<string>
            {
                "Mercúrio", "Vênus", "Terra", "Marte",
                "Júpiter", "Saturno", "Urano", "Netuno"
            };
        }

        public static List<Funcionario> GetFuncionarios() {
            return new List<Funcionario>
            {
        new Funcionario("João", 35, 7500.00m),
        new Funcionario("Marina", 29, 5800.50m),
        new Funcionario("Carlos", 26, 6200.00m),
        new Funcionario("Patrícia", 31, 6900.75m),
        new Funcionario("André", 40, 9100.00m)
    };
        }

        public static List<Aluno> GetAlunos() {
            List<Aluno> alunos = new()
            {
                new Aluno("Ana", 20, 9, new List<string>{ "C#", "SQL" }),
                new Aluno("Bruno", 22, 7, new List<string>{ "Java", "HTML", "CSS" }),
                new Aluno("Carla", 19, 10, new List<string>{ "Python", "Machine Learning" }),
                new Aluno("Diego", 21, 8, new List<string>{ "JavaScript", "React", "Node.js" }),
                new Aluno("Fernanda", 23, 6, new List<string>{ "C#", "Angular" }),
                new Aluno("Gustavo", 20, 9, new List<string>{ "C#", "LINQ", "ASP.NET" })
            };
            return alunos;
        }

        public static List<int> GetNotas() {
            return new List<int> { 7, 9, 5, 10, 6, 8 };
        }

        public static List<string> GetCidades() {
            return new List<string>
            {
                "São Paulo", "Rio de Janeiro", "Curitiba", "Belo Horizonte", "Recife"
            };
        }

        public static List<string> GetFilmes() {
            return new List<string>
            {
                "Inception", "Interestelar", "Matrix", "O Poderoso Chefão", "Parasita"
            };
        }

        public static List<string> GetCursos() {
            return new List<string>
            {
                "C#", "Java", "Python", "JavaScript", "SQL"
            };
        }

        public static List<DateTime> GetDatasImportantes() {
            return new List<DateTime>
            {
                new DateTime(2024, 1, 1),
                new DateTime(2024, 12, 25),
                new DateTime(2025, 10, 8)
            };
        }

        public static List<decimal> GetPrecos() {
            return new List<decimal> { 19.99m, 49.90m, 12.50m, 99.00m, 5.75m };
        }
    }
}
