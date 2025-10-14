using System;

namespace Section8_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
            int index = 0;

            Console.WriteLine("Array int: ");
            foreach (int valor in numeros) {
                Console.WriteLine(valor);
            }

            try {
                Console.WriteLine("Informe um indexador para acessar o array: ");
                index = int.Parse(Console.ReadLine());

                if (index < 0 || index > numeros.Length) {
                    throw new IndexOutOfRangeException("O indexador excedeu o array");
                } else if (index.Equals(null)) {
                    throw new ArgumentNullException("O indexador não pode ser null");
                }
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine("Erro: " + ex.Message);
            } catch (ArgumentNullException ex) {
                Console.WriteLine("Erro: " + ex.Message);
            } catch (Exception ex) {
                Console.WriteLine("Erro: " + ex.Message);
            }

            Console.WriteLine($"Número na posição {index} : {numeros[index]}");

        }
    }
}
