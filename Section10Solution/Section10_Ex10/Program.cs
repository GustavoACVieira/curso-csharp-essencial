namespace Section10_Ex10 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o caminho de origem do arquivo que deseja copiar: ");
            string caminhoOrigem = Console.ReadLine();
            Console.WriteLine("Informe o caminho de destino do arquivo que deseja copiar(informe junto ao caminho o nome do arquivo que deseja copiar): ");
            string caminhoDestino = Console.ReadLine();
            Console.WriteLine("Informe o nome do arquivo que deseja copiar: ");
            string nome = Console.ReadLine();

            try {
                if (File.Exists(caminhoOrigem + @"\" + nome)) {
                    FileInfo fInfo = new FileInfo(caminhoOrigem + @"\" + nome);
                    fInfo.CopyTo(caminhoDestino);
                    Console.WriteLine("Arquivo copiado!");
                } else {
                    Console.WriteLine("Arquivo não encontrado! ");
                }
            } catch (IOException ex) {
                Console.WriteLine(ex.Message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
