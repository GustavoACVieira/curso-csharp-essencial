namespace Section10_Ex17 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoOrigem = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\testando\TheLost.txt";
            string caminhoDestino = @"C:\ws-c#\Section10Solution\ArquivosTXT\backup\TheLost.txt";

            File.Copy(caminhoOrigem, caminhoDestino);
        }
    }
}
