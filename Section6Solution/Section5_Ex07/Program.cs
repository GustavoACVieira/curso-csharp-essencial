namespace Section5_Ex07 {
    internal class Program {
        static void Main(string[] args) {
            Database data = new SQLServer();

            data.Conectar();
            data.Configurar();
        }
    }
}
