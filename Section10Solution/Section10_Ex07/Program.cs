namespace Section10_Ex07 {
    internal class Program {
        static void Main(string[] args) {
            //Criando o arquivo poesia.txt
            string caminho = @"C:\ws-c#\Section10Solution\ArquivosTXT\poesia.txt";
            //string conteudo = "O poeta é um fingidor. " +
            //                  "\r\nFinge tão completamente " +
            //                  "\r\nQue chega a fingir que é dor " +
            //                  "\r\nA dor que deveras sente.";

            //File.WriteAllText(caminho, conteudo);

            //FileStream fs1 = null;
            StreamReader sr = null;

            try {
                //fs1 = new FileStream(caminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                sr = File.OpenText(caminho); //new StreamReader(fs1);

                Console.WriteLine(sr.ReadToEnd());
            } catch (IOException ex) {
                Console.WriteLine(ex.Message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            } finally {
                if (sr != null) sr.Close();
                //if (fs1 != null) fs1.Close();
            }
        }
    }
}
