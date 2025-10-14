namespace Section10_Ex15 {
    internal class Program {
        static void Main(string[] args) {
			try {
                string caminho = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos";
                DirectoryInfo df = new DirectoryInfo(caminho);
                foreach (var arquivo in df.GetDirectories()) {
                    Console.WriteLine($"Nome: {arquivo.Name} | CAminho completo: {arquivo.FullName}");
                }
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
