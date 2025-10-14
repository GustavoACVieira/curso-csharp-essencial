namespace Section10_Ex18 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoDestino = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\testando\dados.txt";
            string caminhoOrigem = @"C:\ws-c#\Section10Solution\ArquivosTXT\backup\dados.txt";

            File.Move(caminhoOrigem, caminhoDestino);
        }
    }
}
