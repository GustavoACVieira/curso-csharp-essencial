using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex37 {
    internal class Sensor {
        public event EventHandler<double>? TemperaturaAlta;

        public void LerTemperatura(double valor) {
            Console.WriteLine($"\nTemperatura lida: {valor}°C");
            if (valor > 40)
            TemperaturaAlta?.Invoke(this, valor);
        }
    }
}
