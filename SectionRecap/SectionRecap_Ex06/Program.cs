namespace SectionRecap_Ex06 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("## Divisão Segura ##\n");

            try {
                Console.WriteLine("Informe o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o primeiro número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());


                if (num2 == 0)
                    throw new DivideByZeroException("Não é possível dividir por zero!");

                Console.WriteLine("Resultado: " + (num1 / num2));
            } catch (FormatException ex) {
                Console.WriteLine("Opa!");
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n" + ex.StackTrace);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n" + ex.StackTrace);
            }
        }
    }
}
