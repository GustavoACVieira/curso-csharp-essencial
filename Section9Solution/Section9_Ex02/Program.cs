namespace Section9_Ex02 {
    internal class Program {
        public delegate void Operacao(string msg);

        public static void Mensagem1 (string msg) {
            Console.WriteLine ($"Mensagem 1: {msg}");
        }
        public static void Mensagem2 (string msg) {
            Console.WriteLine ($"Mensagem 2: {msg}");
        }
        public static void Mensagem3 (string msg) {
            Console.WriteLine ($"Mensagem 3: {msg}");
        }

        static void Main(string[] args) {
            Operacao op1 = Mensagem1;
            op1 += Mensagem2;
            op1 += Mensagem3;

            op1("Teste mensagem");

            op1 -= Mensagem2;

            op1("Removendo Mensagem 2");
        }
    }
}
