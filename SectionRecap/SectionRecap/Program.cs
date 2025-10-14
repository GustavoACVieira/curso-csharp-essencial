namespace SectionRecap {
    internal class Program {
        static void Main(string[] args) {
            //Crie um programa que receba 10 números inteiros, armazene-os em um array e exiba apenas os números pares na tela.
            int[] arrayPar = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"Informe o {i + 1} elemento do array: ");
                arrayPar[i] = Convert.ToInt32( Console.ReadLine());
            }

            foreach (var arP in arrayPar) {
                if (arP % 2 == 0)
                    Console.WriteLine(arP);
            }
        }
    }
}
