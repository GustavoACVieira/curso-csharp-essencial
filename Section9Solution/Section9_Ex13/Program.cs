namespace Section9_Ex13 {
    internal class Program {
        public delegate void Logger(string txt);
        static void Main(string[] args) {
            Console.WriteLine("Informe o conteudo do seu texto: ");
            string? texto = Console.ReadLine();

            Logger lg = RegistrarConsole;
            lg += RegistrarArquivo;

            lg -= RegistrarArquivo;
            lg(texto);

        }

        public static void RegistrarConsole(string txt) {
            Console.WriteLine(txt);
        }

        public static void RegistrarArquivo(string txt) {
            File.WriteAllText(@"C:\ws-c#\Section9Solution\Arquivos\log.txt", txt);
        }
    }
}
