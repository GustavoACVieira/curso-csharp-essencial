using System;

namespace Section2_ConversaoDeTipos1 {
    internal class Program {
        static void Main(string[] args) {
            int varInt = 100;
            double varDouble = varInt;

            Console.WriteLine(varDouble);

            int valorInt = 123;
            double valorDouble = 12.45;
            decimal valorDecimal = 12.45678m;

            string s1 = valorInt.ToString();
            string s2 = valorDouble.ToString();
            string s3 = valorDecimal.ToString();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine();

            int valorInt2 = 10;
            double valorDouble2 = 5.35;
            bool valorBool = true;

            Console.WriteLine(Convert.ToString(valorInt2));
            Console.WriteLine(Convert.ToDouble(valorInt2));
            Console.WriteLine(Convert.ToString(valorBool));
            Console.WriteLine(Convert.ToInt32(valorDouble2));
        }
    }
}