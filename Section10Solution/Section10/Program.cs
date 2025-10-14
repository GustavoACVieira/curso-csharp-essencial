namespace Section10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando FileStream

            string caminho = @"C:\ws-c#\Section10Solution\ArquivosTXT";

            FileStream fs3 = new FileStream(caminho, FileMode.Open, FileAccess.Read, FileShare.Read);

            FileStream fs1 = File.Open(caminho, FileMode.Open, FileAccess.Read, FileShare.Read);

            FileInfo fInfo = new FileInfo(caminho);
            FileStream fs2 = fInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read);

            //Para liberar recursos
            //Usando Close
            //fs1.Close();
            //fs2.Close();
            //fs3.Close();
            //using é mais comum
        }
    }
}
