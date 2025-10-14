namespace SectionRecap_Ex20 {
    internal class Program {
        delegate int Operacao (int n1, int n2);

        static void Main(string[] args) {
            Operacao op = Somar;
            Console.WriteLine("5 + 6 = " + op(5, 6));
            op = Multiplicar;
            Console.WriteLine("5 * 6 = " + op(5, 6));
            op = Subtrair;
            Console.WriteLine("5 - 6 = " + op(5, 6));
            op = Dividir;
            Console.WriteLine("36 / 6 = " + op(36, 6));
        }

        public static int Somar (int n1, int n2) {
            return n1 + n2;
        }
        public static int Multiplicar (int n1, int n2) {
            return n1 * n2;
        }
        public static int Subtrair (int n1, int n2) {
            return n1 - n2;
        }
        public static int Dividir (int n1, int n2) {
            return n1 / n2;
        }
    }
}
