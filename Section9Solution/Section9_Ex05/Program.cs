namespace Section9_Ex05 {
    internal class Program {
        public delegate void MensagemBoasVindas(string nome);

        public static void BoasVindasPT (string nome) {
            Console.WriteLine("Bem Vindo! " + nome);
        }

        public static void BoasVindasEN (string nome) {
            Console.WriteLine("Welcome! " + nome);
        }

        static void Main(string[] args) {
            MensagemBoasVindas msgBV = BoasVindasPT;
            msgBV += BoasVindasEN;

            msgBV.Invoke("Gustavo");
        }
    }
}
