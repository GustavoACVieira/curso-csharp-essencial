namespace Section9_Ex07 {
    internal class Program {
        public static int Operar(int num1, int num2, Func<int, int, int> operacao) {
            return operacao(num1, num2);
        }

        static void Main(string[] args) {
            Func<int, int, int> funcOper = (a, b) => a + b;
            Console.WriteLine($"Resultado da operação é: {Operar(3, 6, funcOper)}");

            Console.WriteLine();

            funcOper = (a, b) => a - b;
            Console.WriteLine($"Resultado da operação é: {Operar(8, 4, funcOper)}");
        }
    }
}
