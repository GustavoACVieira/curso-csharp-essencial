namespace Section10_Ex20 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoDeleteDir = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\testando";
            string caminhoDeleteArq = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\testando\dados.txt";

            File.Delete(caminhoDeleteArq);
            Directory.Delete(caminhoDeleteDir, true);
        }
    }
}
