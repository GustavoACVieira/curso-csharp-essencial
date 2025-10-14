namespace SectionRecap_Ex18 {
    internal class Program {
        static void Main(string[] args) {
            int a = 1, b = 2;
            Console.WriteLine($"Valor A antes: {a} - Valor B antes: {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Valor A depois: {a} - Valor B depois: {b}");

            string a2 = "Gustavo", b2 = "André";
            Console.WriteLine($"\nValor A antes: {a2} - Valor B antes: {b2}");
            Swap(ref a2, ref b2);
            Console.WriteLine($"Valor A depois: {a2} - Valor B depois: {b2}");

            double a3 = 4.5, b3 = 2.5;
            Console.WriteLine($"\nValor A antes: {a3} - Valor B antes: {b3}");
            Swap(ref a3, ref b3);
            Console.WriteLine($"Valor A depois: {a3} - Valor B depois: {b3}");

        }

        static void Swap<T> (ref T a, ref T b) {
            T aux = a;
            a = b;
            b = aux;
        }
    }
}
