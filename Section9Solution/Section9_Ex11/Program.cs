namespace Section9_Ex11 {
    internal class Program {
        delegate int Calcular(int n);

        static void Main(string[] args) {
            int numFat;
			try {
                Console.WriteLine("Informe o número que deseja descobrir o fatorial: ");
                numFat = Convert.ToInt32(Console.ReadLine());

                Calcular fat = delegate (int n) {
                    int resultado = 1;
                    for (int i = 1; i <= numFat; i++) 
                        resultado *= i;
                    return resultado;
                };
                Console.WriteLine("Fatorial de " + numFat + ": " + fat(numFat));

			} catch (FormatException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
			} catch (OverflowException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
