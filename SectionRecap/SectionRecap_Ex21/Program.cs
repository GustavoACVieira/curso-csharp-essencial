namespace SectionRecap_Ex21 {
    internal class Program {
        delegate void Exibir(int n1, int n2);

        static void Main(string[] args) {
            Exibir ex = ExibirSoma;
            ex += ExibirProduto;
            ex(3, 4);
        }

        public static void ExibirSoma(int n1, int n2) {
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }

        public static void ExibirProduto(int n1, int n2) {
            Console.WriteLine($"{n1} + {n2}");
        }
    }
}
