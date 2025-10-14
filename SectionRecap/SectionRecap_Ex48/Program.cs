namespace SectionRecap_Ex48 {
    internal class Program {
        static async Task Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\giga.txt";
            string caminhoCopia = @"C:\ws-c#\SectionRecap\Arquivos\jeffBezos.txt";

            string conteudo = await lendoConteudo(caminho);
            string palavras = await processarConteudo(conteudo);
            await escreverConteudo(caminhoCopia, palavras);
        }

        static async Task<string> lendoConteudo(string caminho) {
            return await File.ReadAllTextAsync(caminho);
        }

        static async Task<string> processarConteudo(string conteudo) {
            
            var palavras = conteudo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int totalPalavras = palavras.Length;

            return $"Total palavras: {totalPalavras}";
        }

        static async Task escreverConteudo(string caminhoCopia, string palavras) {
            await File.WriteAllTextAsync(caminhoCopia, palavras);
        }
    }
}
