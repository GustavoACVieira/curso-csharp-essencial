using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex34 {
    internal class Relogio {
        public event EventHandler? TicTac;

        public void Iniciar() {
            Console.WriteLine("Relógio iniciando...");
            Thread.Sleep(1500);
            TicTac?.Invoke(this, EventArgs.Empty);
        }
    }
}
