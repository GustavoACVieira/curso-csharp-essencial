namespace SectionRecap_Ex34 {
    internal class Program {
        static void Main(string[] args) {
            Relogio relogio = new Relogio();

            relogio.TicTac += Tic;
            relogio.TicTac += Tac;
            relogio.TicTac += Sonoro;

            relogio?.Iniciar();
        }

        static void Tic(object? sender, EventArgs e) {
            Console.WriteLine("tic");
        }

        static void Tac(object? sender, EventArgs e) {
            Console.WriteLine("tac");
        }

        static void Sonoro(object? sender, EventArgs e) {
            Console.WriteLine("prim!! prim!! prim!! prim!!");
        }
    }
}
