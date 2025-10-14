namespace Section10_Ex22 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoDir = @"C:\ws-c#\Section10Solution\ArquivosTXT";
            long tamanhoTotal = GetDirectorySize(caminhoDir);

            Console.WriteLine($"Tamanho total: {tamanhoTotal} b");
        }
        public static long GetDirectorySize(string diretorio) {
            long tamanhoTotal = 0;
            foreach (string arquivo in Directory.GetFiles(diretorio, "*",
                 SearchOption.AllDirectories)) {
                FileInfo info = new FileInfo(arquivo);
                tamanhoTotal += info.Length;
            }
            return tamanhoTotal;
        }
    }
}
