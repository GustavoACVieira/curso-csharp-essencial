namespace Section9_Ex10 {
    internal class Program {
        public delegate int OperacaoMatematica(int n1, int n2);

        static void Main(string[] args) {
            OperacaoMatematica op = Somar;
            int n1, n2;

            try {
                Console.WriteLine("Informe o primeiro número: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o segundo número: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("\nResultado da soma destes números: ");
                ExecutarOperacao(n1, n2, op);

                op = Multiplicar;
                Console.WriteLine("\nResultado da multiplicação destes números: ");
                ExecutarOperacao(n1, n2, op);

            } catch (FormatException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void ExecutarOperacao(int a, int b, OperacaoMatematica op) {
            if (op == Somar) 
                Console.WriteLine($" {a} + {b} = {op.Invoke(a, b)}");
            else
                Console.WriteLine($" {a} x {b} = {op.Invoke(a, b)}");

        }

        public static int Somar(int n1, int n2) {
            return n1 + n2;
        }

        public static int Multiplicar(int n1, int n2) {
            return n1 * n2;
        }
    }
}
