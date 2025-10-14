namespace Section10_Ex07_Otimizado {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\Section10Solution\ArquivosTXT\poesia.txt";

			try {
                //using FileStream fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);
                using StreamReader sr = File.OpenText(caminho); //new StreamReader(fs);

                Console.WriteLine(sr.ReadToEnd());
			} catch (IOException ex) {
                Console.WriteLine(ex.Message);
			} catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
