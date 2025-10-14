namespace SectionRecap_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            List<Produto> produtos = new List<Produto>() {
                new Produto(101, "Cadeira", 599.90),
                new Produto(102, "Mesa", 1321.45),
                new Produto(103, "Abajur", 59.90),
            };

            foreach (var produto in produtos) {
                produto.ExibirInfo();
            }
        }
    }
}
