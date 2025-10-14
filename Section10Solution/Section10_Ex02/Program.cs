namespace Section10_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoOrigem = @"C:\ws-c#\Section10Solution\ArquivosTXT\dados.txt";
            string caminhoCopia = @"C:\ws-c#\Section10Solution\ArquivosTXT\dados_copia.txt";
            string caminhoBackup = @"C:\ws-c#\Section10Solution\ArquivosTXT\backup\dados.txt";

            if (!File.Exists(caminhoOrigem))
                File.WriteAllText(caminhoOrigem, "Arquivo de Teste");
            else
                Console.WriteLine("O arquivo existe!");

            FileInfo file = new FileInfo(caminhoOrigem);
            file.CopyTo(caminhoCopia, true);

            file.MoveTo(caminhoBackup);
        }
    }
}
