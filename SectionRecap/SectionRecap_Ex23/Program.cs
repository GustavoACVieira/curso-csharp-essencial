namespace SectionRecap_Ex23 {
    internal class Program {
        static void Main(string[] args) {
            Func<int, int, int> opSoma = (a, b) => a + b;
            Func<int, int, int> opSubtrair = (a, b) => a - b;
            Func<int, int, int> opMultiplicacao = (a, b) => a * b;
            Func<int, int, int> opDivisao = (a, b) => a / b;

            int n1 = 36;
            int n2 = 6;

            Console.WriteLine(ExecutarOperacao(n1, n2, opSoma));
            Console.WriteLine(ExecutarOperacao(n1, n2, opSubtrair));
            Console.WriteLine(ExecutarOperacao(n1, n2, opMultiplicacao));
            Console.WriteLine(ExecutarOperacao(n1, n2, opDivisao));
        }

        public static int ExecutarOperacao(int n1, int n2, Func<int, int, int> operacao) {
            return operacao(n1, n2);
        }
    }
}
