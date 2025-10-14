namespace SectionRecap_Ex37 {
    internal class Program {
        static void Main(string[] args) {
            Sensor sensor = new Sensor();
            SistemaAlerta sistemaAlerta = new SistemaAlerta();

            sistemaAlerta.Monitorar(sensor);

            sensor.LerTemperatura(35);
            sensor.LerTemperatura(42);
            sensor.LerTemperatura(39);
            sensor.LerTemperatura(45);
        }
    }
}
