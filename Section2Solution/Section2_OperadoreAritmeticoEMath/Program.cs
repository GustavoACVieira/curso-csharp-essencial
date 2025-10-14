using System;


namespace Section2_OperadoreAritmeticoEMath1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o valor de x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma de x + y: " + (x +y));
            Console.WriteLine("Subtração de x - y: " + (x - y));
            Console.WriteLine("Mulltiplicação de x * y: " + (x * y));
            Console.WriteLine("Divisão de x / y: " + ((double)x / y) );
            Console.WriteLine("Módulo de x % y: " + (x % y));
            Console.WriteLine();

            Console.WriteLine("Raiz quadrada de x: " + Math.Sqrt(x));
            Console.WriteLine("Potência de x elevado a y: " + Math.Pow(x, y));
            Console.WriteLine("Valor mínimo entre x e y: " + Math.Min(x, y));
            Console.WriteLine("Valor máximo entre x e y: " + Math.Max(x, y));
            Console.WriteLine("Coseno de x: " + Math.Cos(x));
            Console.WriteLine("Seno de x: " + Math.Sin(x));
            Console.WriteLine("Exponencial de x: " + Math.Exp(x));

            const int MESES_ANO = 12;
            const int DIAS_ANO = 365;

            const float DIAS_POR_MES = (float) DIAS_ANO / MESES_ANO;
            Console.WriteLine(DIAS_POR_MES);

            int T = 0;
            int resultado = T++ + 10;
            Console.WriteLine(resultado);

        }
    }
}