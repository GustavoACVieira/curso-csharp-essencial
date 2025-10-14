using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex37 {
    internal class SistemaAlerta {
        public void Monitorar(Sensor sensor) {
            sensor.TemperaturaAlta += (sender, temp) => Console.WriteLine($"ALERTA! Temperatura crítica: {temp}°C");
        }
    }
}
