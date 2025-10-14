namespace Section10_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            string pastaEntrada = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Entrada";
            string pastaSaida = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Saida";
            string pastaBackup = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Backup";

            File.WriteAllText(pastaEntrada + @"\Cruzeiro.txt", "Cruzeiro Maior de minas");
            File.WriteAllText(pastaEntrada + @"\Minas.txt", "Maior de minas");
            File.WriteAllText(pastaEntrada + @"\Apelido.txt", "La Bestia Negra");

            string[] arquivos = Directory.GetFiles(pastaEntrada);

            foreach (var arquivo in arquivos) {
                FileInfo fInfo = new FileInfo(arquivo);
                Console.WriteLine($"\n\nNome do Arquivo: {Path.GetFileName(arquivo)} \nExtensão: {Path.GetExtension(arquivo)} \nDiretório Pai: {Path.GetDirectoryName(arquivo)}");
                string nome = Path.GetFileName(arquivo);
                fInfo.CopyTo(Path.Combine(pastaSaida, nome));
                fInfo.MoveTo(Path.Combine(pastaBackup, nome));
            }
        }
    }
}
