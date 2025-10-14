
namespace Section10_Ex21 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Entrada\Minas.txt";
            string novoNome = "Mineirão.txt";
            string caminhoCompleto = Path.Combine(Path.GetDirectoryName(caminho), novoNome);
            File.Move(caminho, caminhoCompleto);
        }
    }
}
