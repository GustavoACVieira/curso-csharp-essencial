using System;

namespace Section2_TiposDeDados6 {
    internal class Program {
        static void Main(string[] args) {
            Nullable<int> i = null;
            Nullable<double> d = null;
            Nullable<bool> b = null;

            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine(b);

            //Forma simplificada
            int? i2 = null;
            double? d2 = null;
            bool? b2 = null;

            Console.WriteLine(i2);
            Console.WriteLine(d2);
            Console.WriteLine(b2);

            //Atribuindo um Nullable type a um tipo valor
            int? a = null;
            int b3 = a ?? 0;
            Console.WriteLine(b3);

            int? x = 4;
            int? y = 3;
            int? z = x * y;

            Console.WriteLine(z);
            Console.WriteLine();

            //Func do nullable
            int? c = null;
            if (c.HasValue) {
                Console.WriteLine("c = " + c);
            } else {
                Console.WriteLine("c não possui valor");
            }
        }
    }
}