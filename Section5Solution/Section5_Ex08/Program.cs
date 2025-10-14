namespace Section5_Ex08 {
    internal class Program {
        static void Main(string[] args) {
            List<Produto> produtos = new() {
                new Produto() {Nome = "Clips", Preco = 3.95M},
                new Produto() {Nome = "Caneta", Preco = 5.99M},
                new Produto() {Nome = "Lápis", Preco = 4.15M},
                new Produto() {Nome = "Estojo", Preco = 6.99M},
                new Produto() {Nome = "Caderno", Preco = 7.55M},
            };

            Console.WriteLine("\nRelação de Produtos: ");
            var sumTotal = Produto.ExibirRelacaoProd(produtos);
            Console.WriteLine($"\nSoma total dos preços: {sumTotal}");
            Console.WriteLine($"\nMédia dos preços: {sumTotal / produtos.Count():F2}");
            Console.WriteLine($"\nQuantidade de produtos: {produtos.Count()}");

            produtos.Add(new Produto() { Nome = "Mochila", Preco = 22.44M });
            Console.WriteLine("\nEx02: ");
            Produto.ExibirRelacaoProd(produtos);

            var produtosOrdernados = produtos.ToArray().OrderBy(x => x.Nome);
            Console.WriteLine("\nEx03");
            Produto.ExibirRelacaoProd(produtosOrdernados.ToList());

            var produtosMenosCinco = produtos.FindAll(x => x.Preco < 5);
            Console.WriteLine("\nEx04");
            Produto.ExibirRelacaoProd(produtosMenosCinco);

            Console.WriteLine("\nEx05");
            Console.WriteLine($"Estojo está na posição {produtos.FindIndex(x => x.Nome == "Estojo")}");
        }
    }
}
