using System;
using CarroEnum;

namespace Section4_Ex01 {
    internal class Carro {
        public string? Modelo;
        public string? Montadora;
        public string? Marca;
        private int ano;
        public int Ano {  
            get { return ano; } 
            set {
                if (value < 2000)
                    ano = 2000;
                else if (value > 2022)
                    ano = 2022;
                else
                    ano = value;
            } 
        }
        public int Potencia;
        public int Cor;
        public static double ValorIpva;

        public Carro() { }

        public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia, int cor) {
            this.Modelo = Modelo;
            this.Montadora = Montadora;
            this.Marca = Marca;
            this.Ano = Ano;
            this.Potencia = Potencia;
            Cor = cor;
        }

        static Carro() {
            ValorIpva = 4;
        }

        public Carro(string? modelo, string? montadora) {
            Modelo = modelo;
            Montadora = montadora;
        }

        public void acelerar(string? marca) {
            Console.WriteLine($"Acelerando o meu {marca}");
        }

        public double VelocidadeMaxima(int Potencia) {
            return Potencia * 1.75;
        }

        public int AumentarPotencia(int Potencia) {
            return Potencia += 3;
        }

        public int AumentarPotencia(ref int Potencia) {
            return Potencia += 5;
        }

        public int AumentarPotenciaVelocidade(int Potencia, out double velocidade) {
            Potencia += 7;
            velocidade = Potencia * 1.75;
            return Potencia;
        }

        public void ExibirInfo(string? Modelo, string? Montadora, string? Marca, int Potencia, int Ano = 2000) {
            Console.WriteLine($"Modelo: {Modelo} - Montadora: {Montadora} - Marca: {Marca} - Ano: {Ano} - Potência: {Potencia} - Cor: {(Cores)Cor}");
        }

        public void ExibirInfo() {
            Console.WriteLine($"Modelo: {Modelo} - Montadora: {Montadora} - Marca: {Marca} - Ano: {Ano} - Potência: {Potencia} - Cor: {(Cores)Cor}");
        }

        /*
        public static void ObterValorIPVA(double ipva) {
            ValorIpva = ipva;
        }*/
    }
}
