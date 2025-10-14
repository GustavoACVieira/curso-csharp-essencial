namespace Section9_ConsultasLINQ1 {
    internal class Program {
        static void Main(string[] args) {
            //Fonte de Dados
            var listaProdutos = Produto.GetProdutos();

            Console.WriteLine("Produtos eletrônicos: ");
            var produtoEletro = listaProdutos.Where(x => x.Categoria == "Eletrônicos");

            foreach (var item in produtoEletro) {
                Console.WriteLine($"{item.Nome} \t{item.Preco:C2}");
            }

            //Filtrando com mais de uma condição
            Console.WriteLine("\nProdutos mais caros em estoque superior a 5: ");
            var produtoCarosComEstoque = listaProdutos.Where(x => x.Preco >= 2000 && x.Estoque > 5);

            foreach (var item in produtoCarosComEstoque) {
                Console.WriteLine($"{item.Nome} \t{item.Preco:C2} \tEstoque: {item.Estoque}");
            }

            //Filtrando com ordenação
            Console.WriteLine("\nProdutos com estoque mínimo de 10 ordenados por nome: ");
            int minimo = 10;
            var produtoEstoqueMini = listaProdutos
                .Where(x => x.Estoque < minimo)
                .OrderBy(x => x.Nome);

            foreach (var item in produtoEstoqueMini) {
                Console.WriteLine($"{item.Nome} \tEstoque: {item.Estoque}");
            }

            //Ordenando por mais de um critério
            Console.WriteLine("\nProdutos ordenados por categoria e nome:");
            var produtosOrdenadosPorCategoriaENome = listaProdutos
                                                     .OrderBy(p => p.Categoria)
                                                     .ThenBy(p => p.Nome);
            string? categoriaAnterior = "";
            foreach (var produto in produtosOrdenadosPorCategoriaENome) {
                if (produto.Categoria != categoriaAnterior) {
                    Console.WriteLine($"    {produto.Categoria}:");
                    categoriaAnterior = produto.Categoria;
                }
                Console.WriteLine($"        {produto.Nome}");
            }

            //Cria uma lista de strings com nomes dos produtos
            Console.WriteLine("\nLista dos nomes dos produtos ordenados");

            var nomesDosProdutos = listaProdutos.Select(p => p.Nome).OrderBy(nome => nome);
            foreach (var produto in nomesDosProdutos) {
                Console.WriteLine(produto);
            }

            // Filtrando por preço, ordenando por nome e criando um tipo anônimo
            Console.WriteLine("\nProdutos com valor menor que R$ 500 com aumento de 10% ordenados por nome:");
            var resultado = listaProdutos.Where(p => p.Preco < 500)
                                         .OrderBy(p => p.Nome)
                                         .Select(p => new {
                                             NomeProduto = p.Nome.ToUpper(),
                                             PrecoComAumento = p.Preco * 1.1
                                         });

            foreach (var produto in resultado) {
                Console.WriteLine($"{produto.NomeProduto}, \tPreço com aumento: {produto.PrecoComAumento:C}");
            }

            //outro exemplo
            Console.WriteLine("\nProdutos com valor maior que R$ 2000 com desconto de 20% ordenados por preço: ");
            var resultado1 = listaProdutos.Where(p => p.Preco > 2000)
                                    .OrderBy(p => p.Preco)
                                    .Select(p => new {
                                        NomeDoProduto = p.Nome.ToUpper(),
                                        PrecoComDesconto = p.Preco * 0.8
                                    });

            foreach (var p in resultado1) {
                Console.WriteLine($"{p.NomeDoProduto}, \tPreço com Desconto: {p.PrecoComDesconto:C}");
            }

            //Realizando cálculos de somatória, média e contagem
            Console.WriteLine("\nValor médio dos produtos eletrônicos");
            string categoria = "Eletrônicos";
            double mediaPrecoEletronicos = listaProdutos.Where(p => p.Categoria == categoria)
                                           .Average(p => p.Preco);

            Console.WriteLine($"{mediaPrecoEletronicos:C}");


            Console.WriteLine("\nValor total dos produtos em estoque");
            double valorTotalEstoque = listaProdutos
                                       .Where(p => p.Estoque > 0)
                                       .Sum(p => p.Preco * p.Estoque);
            Console.WriteLine($"{valorTotalEstoque:C}");

            Console.WriteLine("\nQuantidade de produtos com estoque minimo (< 10)");
            int estoqueMinimo = 10;
            int produtosEstoqueBaixo = listaProdutos.Where(p => p.Estoque < estoqueMinimo).Count();
            Console.WriteLine(produtosEstoqueBaixo);
        }
    }
}
