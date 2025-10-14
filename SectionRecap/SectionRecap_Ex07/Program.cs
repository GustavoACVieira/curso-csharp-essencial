namespace SectionRecap_Ex07 {
    internal class Program {
        public delegate double Operacao(double x, double y);

        static void Main(string[] args) {
            int opcao = 0;
            Operacao op;
            double num1 = 0, num2 = 0;

            do {
                Console.WriteLine("\nInforme a operação que deseja fazer: ");
                Console.WriteLine("""
                    1-Soma
                    2-Subtração
                    3-Multiplicação
                    4-Divisão
                    0-Sair
                    """);
                opcao = Convert.ToInt32(Console.ReadLine());

                try {
                    Console.WriteLine("\nInforme o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nInforme o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                } catch (FormatException ex) {
                    Console.WriteLine("Formato errado!!");
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.Message);

                } catch (Exception ex) {
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.Message);

                }

                switch (opcao) {
                    case 0:
                        break;
                    case 1:
                        op = Somar;
                        Console.WriteLine($"Resultado: {op(num1, num2)}");
                        break;
                    case 2:
                        op = Subtrair;
                        Console.WriteLine($"Resultado: {op(num1, num2)}");
                        break;
                    case 3:
                        op = Multiplicar;
                        Console.WriteLine($"Resultado: {op(num1, num2)}");
                        break;
                    case 4:
                        op = Dividir;
                        try {
                            if (num2 != 0)
                                Console.WriteLine($"Resultado: {op(num1, num2)}");
                            else
                                throw new DivideByZeroException("Impossível dividir por zero!");
                        } catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.StackTrace);
                        }
                        break;
                }
            } while (opcao != 0);
        }

        public static double Somar(double x, double y) {
            return x + y;
        }

        public static double Subtrair(double x, double y) {
            return x - y;
        }

        public static double Multiplicar(double x, double y) {
            return x * y;
        }

        public static double Dividir(double x, double y) {
            return x / y;
        }

    }
}
