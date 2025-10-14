namespace Section5_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            Carro carro = new Carro();
            carro.Dirigir();

            Console.WriteLine("Informe a quantidade de gasolina que você ira colocar: ");
            int qtdGas = int.Parse(Console.ReadLine());
            
            if (carro.Abastecer(qtdGas))
                carro.Dirigir();
        }
    }
}
