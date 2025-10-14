namespace SectionRecap_Ex35 {
    internal class Program {
        static void Main(string[] args) {
            Produto produto = new Produto("Caderno", 38);

            produto.EventoEstoqueBaixo += EstoqueBaixo;

            produto.Vender("Caderno", 35);
        }

        static void EstoqueBaixo(object? sender,  ProdutoEventArgs e) {
            Console.WriteLine($"Estoque baixo: {e.Nome}, quantidade: {e.Qtd} ");
        }
    }
}
