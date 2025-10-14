namespace Section10_Ex13 {
    internal class Program {
        static void Main(string[] args) {
            try {
                string caminhoOrigem = @"C:\ws-c#\Section10Solution\ArquivosTXT\Cruzeiro.png";
                string caminhoDestino = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Entrada\CruzeiroImagem.txt";

                byte[] imagemLidaBt = File.ReadAllBytes(caminhoOrigem);
                string imagemLidaStr = Convert.ToBase64String(imagemLidaBt);

                File.WriteAllText(caminhoDestino, imagemLidaStr);
                Console.WriteLine("Arquivo convertido e salvo com sucesso!");
            } catch (IOException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
