namespace Section9_ConsultasLINQ3 {
    internal class Program {
        static void Main(string[] args) {
            var listaProduto = Produto.GetProdutos();

            var produtoPorCategoria = listaProduto
                .GroupBy(x => x.Categoria)
                .OrderBy(x => x.Key)
                .Select(x => new {
                    Categoria = x.Key,
                    Produtos = x.OrderBy(x => x.Nome)
                    .Select(x => new {
                        Nome = x.Nome,
                        Preco = x.Preco,
                        Estoque = x.Estoque,
                    })
                });

            foreach (var grupo in produtoPorCategoria) {
                Console.WriteLine(grupo.Categoria);

                foreach (var produto in grupo.Produtos) {
                    Console.WriteLine($"  {produto.Nome} \t{produto.Preco:C2} \t{produto.Estoque}");
                }
            }
        }
    }
}
