namespace Section10_Ex16 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos";

            try {
                Console.WriteLine("Informe o nome do diretorio que deseja criar: ");
                string nomeDiretorio = Console.ReadLine();
                string caminhoNovoDiretorio = Path.Combine(caminho, nomeDiretorio);//caminho + @"\" + nomeDiretorio;

                Directory.CreateDirectory(caminhoNovoDiretorio);

                string conteudo = "Teste Arquivo NOVO!!!!";
                Console.WriteLine("Qual o nome do arquivo que você deseja criar?");
                string nomeArquivo = Console.ReadLine();
                string caminhoArquivoNovo = Path.Combine(caminhoNovoDiretorio, nomeArquivo);//caminhoNovoDiretorio + @"\" + nomeArquivo;

                File.WriteAllText(caminhoArquivoNovo, conteudo);
                if (Directory.Exists(caminhoNovoDiretorio)) {
                    if (File.Exists(caminhoArquivoNovo)) {
                        Console.WriteLine("Arquivo e diretorio criados com sucesso!");
                    }
                }
			} catch (IOException ex) {
                Console.WriteLine(ex.Message);
			} catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
