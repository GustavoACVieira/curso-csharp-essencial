namespace Section9_Ex14 {
    internal class Program {
        static void Main(string[] args) {
            Action<string> exibirMsg = x => Console.WriteLine($"Resultado: {x}");
            Func<int, int, double> func = (a, b) => b == 0 ? double.NaN : a / b;

            Console.WriteLine("informe o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            var result = func(n1, n2);
            exibirMsg(result.ToString());
        }
    }
}
