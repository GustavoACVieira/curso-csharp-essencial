using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex36 {
    internal class Downloader {
        public event EventHandler<int>? ProgressoAlterado;

        public void Baixar() {
            Console.WriteLine("Iniciando download...");
            for (int i = 0; i <= 100; i += 10) {
                Thread.Sleep(2500);
                ProgressoAlterado?.Invoke(this, i);
            }
            Console.WriteLine("Download Concluído!!!");
        }
    }
}
