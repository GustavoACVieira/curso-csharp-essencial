
using System;

namespace Section10_Ex19 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoDir = @"C:\ws-c#\Section10Solution\ArquivosTXT";
            DirectoryInfo dirInfo = new DirectoryInfo(caminhoDir);
            foreach (var arquivo in dirInfo.GetFiles("*", SearchOption.AllDirectories)) {
                Console.WriteLine(arquivo.FullName);
            }
        }
    }
}
