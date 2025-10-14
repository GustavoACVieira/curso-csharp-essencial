namespace Section10_Ex11 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Backup\poetaFernando.txt";
            string conteudo = "O poeta é um fingidor. " +
                              "\r\nFinge tão completamente " +
                              "\r\nQue chega a fingir que é dor " +
                              "\r\nA dor que deveras sente.";

            File.WriteAllText(caminho, conteudo);

            string conteudo2 = "\r\nDe Fernando, O Poeta";
            File.AppendAllText(caminho, conteudo2);

            using StreamReader sr = new StreamReader(caminho);
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
