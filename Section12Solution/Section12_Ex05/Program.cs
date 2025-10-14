namespace Section12_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\Section12Solution\Arquivos\teste.txt";

            using (var sw = new StreamWriter(caminho).WriteLineAsync()) {
                for (int i = 1; i <= 100; i++) {
                    caminho = $"\r\n{i}";
                }
            }
        }

    }
}
