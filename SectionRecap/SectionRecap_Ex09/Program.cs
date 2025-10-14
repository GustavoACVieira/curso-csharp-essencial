namespace SectionRecap_Ex09 {
    internal class Program {
        static void Main(string[] args) {
            var produto = new Estoque("Monitor", 10);

            produto.EstoqueBaixo += Produto_EstoqueBaixo;

            produto.AdicionarEstoque(13);
            produto.SubtrairEstoque(20);
        }

        static void Produto_EstoqueBaixo(object? sender, EventArgs e) {
            var p = (Estoque)sender!;
            Console.WriteLine("Alerta!!!");
            Console.WriteLine($"Estoque baixo do produto: {p.Nome}! Quantidade atual: {p.QtdEstoque}");
        }
    }
}
