namespace SectionRecap_Ex50 {
    internal class Program {
        static void Main(string[] args) {
            Calculadora calculadora = new();

			try {
                var soma = calculadora.Somar(12, 4);
                Console.WriteLine($"12 + 4 = {soma}");

                var subtracao = calculadora.Subtrair(12, 4);
                Console.WriteLine($"12 - 4 = {subtracao}");

                var multiplicacao = calculadora.Multiplicar(12, 4);
                Console.WriteLine($"12 * 4 = {multiplicacao}");

                var divisao = calculadora.Dividir(12, 0);
                Console.WriteLine($"12 / 4 = {divisao}");

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
			}
        }
    }
}
