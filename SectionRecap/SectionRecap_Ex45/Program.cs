namespace SectionRecap_Ex45 {
    internal class Program {
        static async Task Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\giga.txt";
            string conteudo = "Tião Carreiro e Pardin, Xuxa, Calipso, Bitelo";

            await EscreverArquivoAsync(caminho, conteudo);
            string result = await LerArquivoAsync(caminho);
            Console.WriteLine(result);
        }

        static async Task EscreverArquivoAsync(string caminho, string conteudo) {
            using (StreamWriter sw = new StreamWriter(caminho))
                await sw.WriteLineAsync(conteudo);
        }

        static async Task<string> LerArquivoAsync(string caminhho) {
            using (StreamReader sr = new StreamReader(caminhho))
                return await sr.ReadToEndAsync();
        }
    }
}
