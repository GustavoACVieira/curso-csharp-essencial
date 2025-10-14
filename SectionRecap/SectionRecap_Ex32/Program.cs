namespace SectionRecap_Ex32 {
    internal class Program {
        static void Main(string[] args) {
            Alarme alarme = new Alarme();

            alarme.AlarmeDisparado += QuandoAlarmeDisparar;

            alarme.Disparar();
        }

        static void QuandoAlarmeDisparar(object? sender, EventArgs e) {
            Console.WriteLine("Alarme disparado!!!");
        }
    }
}
