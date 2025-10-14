using System;

namespace Section2_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            DateTime agora = DateTime.Now;

            Console.WriteLine("Ano: " + agora.Year);
            Console.WriteLine("Mês: " + agora.Month);
            Console.WriteLine("Dia: " + agora.Day);

            Console.WriteLine("Dia + 7: " + agora.AddDays(7));

            Console.WriteLine("Data formato curto: " + agora.ToShortDateString());
            Console.WriteLine("Data formato longo: " + agora.ToLongDateString());
        }
    }
}