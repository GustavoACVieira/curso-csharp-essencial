using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex32 {
    internal class Alarme {
        public event EventHandler? AlarmeDisparado;

        public void Disparar() {
            Console.WriteLine("Ativando...");
            AlarmeDisparado?.Invoke(this, EventArgs.Empty);
        }
    }
}
