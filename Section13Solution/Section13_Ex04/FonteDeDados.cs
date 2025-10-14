

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section13_Ex01 {
    public class FonteDeDados {
        public static List<Aluno> GetAlunos() {
            return new List<Aluno>
            {
                new Aluno("Ana", 20, 9, new List<string>{ "C#", "SQL" }),
                new Aluno("Bruno", 22, 7, new List<string>{ "Java", "HTML", "CSS" }),
                new Aluno("Carla", 19, 10, new List<string>{ "Python", "Machine Learning" }),
                new Aluno("Diego", 21, 8, new List<string>{ "JavaScript", "React", "Node.js" }),
                new Aluno("Fernanda", 23, 6, new List<string>{ "C#", "Angular" }),
                new Aluno("Gustavo", 20, 9, new List<string>{ "C#", "LINQ", "ASP.NET" }),
                new Aluno("Ana", 20, 9, new List<string>{ "C#", "SQL" }) // repetida para testar Distinct
            };
        }

        public static List<Funcionario> GetFuncionarios() {
            return new List<Funcionario>
            {
                new Funcionario("João", 35, 7500.00m),
                new Funcionario("Marina", 29, 5800.50m),
                new Funcionario("Carlos", 26, 6200.00m),
                new Funcionario("Patrícia", 31, 6900.75m),
                new Funcionario("André", 40, 9100.00m),
                new Funcionario("Carla", 25, 4500.00m),
            };
        }

        public static List<string> GetCursos() {
            return new List<string>
            {
                "C#", "Java", "Python", "SQL", "JavaScript", "C#", "HTML", "CSS"
            };
        }

        public static List<string> GetCidades() {
            return new List<string>
            {
                "São Paulo", "Rio de Janeiro", "Curitiba", "Belo Horizonte", "Recife",
                "Fortaleza", "Salvador", "Porto Alegre", "Curitiba"
            };
        }

        public static List<int> GetNumeros() {
            return new List<int> { 5, 10, 15, 20, 25, 30, 10, 5 };
        }

        public static List<decimal> GetPrecos() {
            return new List<decimal> { 19.99m, 49.90m, 12.50m, 99.00m, 5.75m, 19.99m };
        }

        public static List<string> GetProdutos() {
            return new List<string>
            {
                "Notebook", "Mouse", "Teclado", "Monitor", "Cadeira Gamer", "Mouse", "Fone"
            };
        }

        public static List<int> GetNumerosPares() {
            return new List<int> { 2, 4, 6, 8, 10, 12, 14 };
        }

        public static List<int> GetNumerosImpares() {
            return new List<int> { 1, 3, 5, 7, 9, 11, 13 };
        }

        public static List<string> GetFrutas() {
            return new List<string>
            {
                "Maçã", "Banana", "Uva", "Abacaxi", "Laranja", "Banana", "Manga"
            };
        }
    }
}
