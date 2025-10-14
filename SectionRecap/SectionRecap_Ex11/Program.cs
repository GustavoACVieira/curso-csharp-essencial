
namespace SectionRecap_Ex11 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\log.txt";
            DateTime data = DateTime.Now;
            string conteudo = "Data/Hora: " + data;

            File.WriteAllText(caminho, conteudo);
            Console.WriteLine(File.ReadAllText(caminho));
        }
    }
}
