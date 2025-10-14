using System;
using CarroEnum;

namespace Section4_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110, 4);
            Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120, 2);

            /*Ex01
            Console.WriteLine("Infos do carro:");
            Console.WriteLine($"Modelo: {chevrolet.Modelo} - Montadora: {chevrolet.Montadora} - Marca: {chevrolet.Marca} - Ano: {chevrolet.Ano} - Potência: {chevrolet.Potencia}");
            chevrolet.acelerar(chevrolet.Marca);
            Console.WriteLine($"Modelo: {ford.Modelo} - Montadora: {ford.Montadora} - Marca: {ford.Marca} - Ano: {ford.Ano} - Potência: {ford.Potencia}");
            ford.acelerar(ford.Marca); */

            //Ex02
            //Console.WriteLine($"Velocidade máxima do {ford.Marca} : {ford.VelocidadeMaxima(ford.Potencia)}");

            /*Ex 03
            Console.WriteLine("Aumentando potência....");
            Console.WriteLine("Potência máxima dps do aumento: " + ford.AumentarPotencia(ford.Potencia));
            Console.WriteLine("Após o aumento: " + ford.Potencia);

            Console.WriteLine("Aumentando potência....");
            Console.WriteLine("Potência máxima dps do aumento: " + ford.AumentarPotencia(ref ford.Potencia));
            Console.WriteLine("Após o aumento: " + ford.Potencia); */

            /*Ex04
            double potencia = ford.AumentarPotenciaVelocidade(ford.Potencia, out double velocidade);
            Console.WriteLine($"Nova potência: {potencia}");
            Console.WriteLine($"Nova velocidade: {velocidade}"); */

            /*Ex05
            ford.ExibirInfo(ford.Modelo,Marca: ford.Marca, Montadora: ford.Montadora, Potencia: ford.Potencia);
            Console.WriteLine();
            ford.ExibirInfo(ford.Modelo,Marca: ford.Marca, Montadora: ford.Montadora, Ano: ford.Ano, Potencia: ford.Potencia);*/

            /*Ex06
            Carro.ObterValorIPVA(4.0);
            Console.WriteLine($"Valor do IPVA: {Carro.ValorIpva}%");*/

            /*Ex07
            Carro ford2 = new Carro("Sedan", "Ford", "Monza", 2024, 220);
            ford2.ExibirInfo();*/

            /*Ex09
            Console.WriteLine("Cores disponíveis e suas numerações: ");
            Console.WriteLine($"{Cores.BRANCO} : {(int)Cores.BRANCO}");
            Console.WriteLine($"{Cores.VERMELHO} : {(int)Cores.VERMELHO}");
            Console.WriteLine($"{Cores.PRETO} : {(int)Cores.PRETO}");
            Console.WriteLine($"{Cores.CINZA} : {(int)Cores.CINZA}");
            Console.WriteLine($"{Cores.PRATA} : {(int)Cores.PRATA}");
            Console.WriteLine($"{Cores.AZUL} : {(int)Cores.AZUL}");

            Console.WriteLine("\nEscolha a cor(informe o codigo da cor) :");
            int cor = int.Parse(Console.ReadLine());

            Carro chevrolet2 = new Carro("Sedan", "Chevrolet", "Monza", 1999, 220, cor);

            chevrolet2.ExibirInfo();*/


        }
    }
}