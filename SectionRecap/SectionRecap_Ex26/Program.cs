namespace SectionRecap_Ex26 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\pessoa.txt";

            //using StreamWriter writer = new StreamWriter(caminho);
            //writer.WriteLine("Gustavo;19");
            //writer.WriteLine("Leo;36");
            //writer.WriteLine("Rodrigo;46");

            using StreamReader reader = new StreamReader(caminho);
            string conteudo = reader.ReadToEnd();

            Console.WriteLine(conteudo);

        }
    }
}
