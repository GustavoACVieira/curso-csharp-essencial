namespace Section5_Ex02 {
    internal class Program {
        static void Main(string[] args) {
            ISalvar sXml = new SalvarXml();
            ISalvar sJson = new SalvarJson();

            sXml.Salvar();
            sJson.Salvar();

            Console.WriteLine();

            sXml.Compactar();
            sJson.Compactar();
        }
    }
}
