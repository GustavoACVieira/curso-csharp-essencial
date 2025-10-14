namespace Section9_Ex01 {
    internal class Program {
        public delegate int Operacao(int num1, int num2);

        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        static void Main(string[] args) {
            Operacao op1 = Somar;
            Console.WriteLine($"Soma: {op1.Invoke(3, 4)}");

            op1 = Multiplicar;
            Console.WriteLine($"Multiplicação: {op1.Invoke(3, 4)}");
            
        }
    }
}
