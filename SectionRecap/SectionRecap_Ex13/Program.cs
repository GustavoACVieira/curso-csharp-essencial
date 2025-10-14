namespace SectionRecap_Ex13 {
    internal class Program {
        static void Main(string[] args) {
            ContaBancaria conta = new ContaBancaria(100, "Gustavo");

            Console.WriteLine("\nSaldo inicial: ");
            Console.WriteLine($"Nome: {conta.Nome} - Saldo: {conta._Saldo.ToString()}");

            Console.WriteLine("\nSaldo após 1 saque: ");
            conta.Sacar(53.34);
            Console.WriteLine($"Nome: {conta.Nome} - Saldo: {conta._Saldo}");

            Console.WriteLine("\nSaldo após 1 deposito: ");
            conta.Depositar(64);
            Console.WriteLine($"Nome: {conta.Nome} - Saldo: {conta._Saldo}");

            Console.WriteLine("\nSaldo após 2 saque: ");
            conta.Sacar(200);
            Console.WriteLine($"Nome: {conta.Nome} - Saldo: {conta._Saldo}");
        }
    }
}
