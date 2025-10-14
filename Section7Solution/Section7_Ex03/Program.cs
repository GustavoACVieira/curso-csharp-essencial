namespace Section7_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            ClasseGenerica<int> arrayIntGenerico = new ClasseGenerica<int>();

            Console.WriteLine("Informe o primeiro número: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            var num2 = int.Parse(Console.ReadLine());

            var resultado = arrayIntGenerico.ADDNum(num1, num2);

            Console.WriteLine($"Resultado da soma: {resultado}");

        }
    }
}
