namespace Section9_Ex08 {
    internal class Program {
        static void Main(string[] args) {
            List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int soma = listInt.SomaNumerosImpares();
            Console.WriteLine($"Soma dos impares: {soma}");
        }
    }
}
