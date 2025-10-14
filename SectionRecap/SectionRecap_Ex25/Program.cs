namespace SectionRecap_Ex25 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe o caminho do diretório: ");
            string caminho = Console.ReadLine();

            DirectoryInfo dirInfo = new DirectoryInfo(caminho);

            foreach (var dir in dirInfo.GetFiles("*", SearchOption.AllDirectories)) {
                Console.WriteLine(dir);
            }
        }
    }
}
