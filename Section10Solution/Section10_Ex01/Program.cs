namespace Section10_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoOrigem = @"C:\ws-c#\Section10Solution\ArquivosTXT\arquivoEx01.txt";

            Console.WriteLine("Digite uma frase para ser escrita no arquivo: ");
            File.WriteAllText(caminhoOrigem, Console.ReadLine());

            Console.WriteLine(File.ReadAllText(caminhoOrigem));
        }
    }
}
