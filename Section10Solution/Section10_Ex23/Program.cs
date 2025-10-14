using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Section10_Ex23 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\Section10Solution\ArquivosTXT";
            DirectoryInfo dirInfo = new DirectoryInfo(caminho);
            FileInfo[] arquivos = dirInfo.GetFiles();
            DateTime ultimaModificacao = DateTime.MinValue;
            string nomeArquivoMaisRecente = string.Empty;

            foreach (FileInfo arquivo in arquivos) {
                if (arquivo.LastWriteTime > ultimaModificacao) {
                    ultimaModificacao = arquivo.LastWriteTime;
                    nomeArquivoMaisRecente = arquivo.Name;
                }
            }

            if (!string.IsNullOrEmpty(nomeArquivoMaisRecente)) {
                Console.WriteLine($"O arquivo mais recente em {caminho} é: {Path.Combine(caminho, nomeArquivoMaisRecente)}");
            } else {
                Console.WriteLine($"Não foi encontrado nenhum arquivo em {caminho}");
            }
        }
    }
}
