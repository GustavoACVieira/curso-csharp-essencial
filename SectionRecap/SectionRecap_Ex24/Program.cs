namespace SectionRecap_Ex24 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\frase.txt";

            Console.WriteLine("Informe uma frase: ");
            string frase = Console.ReadLine();

            File.WriteAllText(caminho, frase);

            Console.WriteLine(File.ReadAllText(caminho));
        }
    }
}
