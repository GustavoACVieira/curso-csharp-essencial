using System;
using System.Globalization;

namespace Section2_TiposDeDados5 {
    internal class Program {
        static void Main(string[] args) {
            DateTime hoje = DateTime.Now;
            DateTime data = new DateTime(2022, 09, 04);
            DateTime data2 = new DateTime(2022, 09, 04, 11, 10, 20);

            Console.WriteLine(hoje);
            Console.WriteLine(data);
            Console.WriteLine(data2);
            Console.WriteLine();

            /* Operações com data e hora
            1- Extrair informações como dia, mês, hora, ano,ect:
            Year, Month, Day, Hour, Minute, Second, Millisecond

            2- Adicionar dias, horas, mês, anos, etc:
            AddDays, AddHours, AddMonths, AddYears

            3- Obter dia da semana e do ano
            DayOfWeek, DayOfYear

            4- Expressar data no formato longo e abreviado
            ToLongDateString, ToShortDateString

            5- Expressar hora no formato longo e abreviado
            ToLongHourString, ToShortHourString
            */

            Console.WriteLine("Hoje: " + hoje);

            //Extraindo info da data atual
            Console.WriteLine(hoje.Year);
            Console.WriteLine(hoje.Month);
            Console.WriteLine(hoje.Day);
            Console.WriteLine(hoje.Hour);
            Console.WriteLine(hoje.Minute);
            Console.WriteLine(hoje.Second);
            Console.WriteLine(hoje.Millisecond);
            Console.WriteLine();

            //Obtendo o dia da semana e ano
            Console.WriteLine(hoje.DayOfWeek);
            Console.WriteLine(hoje.DayOfYear);
            Console.WriteLine();

            //Data e tempo no formato longo e curto
            Console.WriteLine(hoje.ToLongDateString());
            Console.WriteLine(hoje.ToShortDateString());

            Console.WriteLine(hoje.ToLongTimeString());
            Console.WriteLine(hoje.ToShortTimeString());
            Console.WriteLine();

            //Adicionando valores
            Console.WriteLine(hoje.AddDays(30));
            Console.WriteLine(hoje.AddMonths(1));
            Console.WriteLine(hoje.AddHours(2));
            Console.WriteLine(hoje.AddYears(5));

            
            
        }
    }
}