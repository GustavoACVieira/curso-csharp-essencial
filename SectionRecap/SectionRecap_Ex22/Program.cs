namespace SectionRecap_Ex22 {
    internal class Program {
        static void Main(string[] args) {
            Action<string> imprimirMsg = (string msg) => Console.WriteLine(msg);
            Func<int, int, int> imprimirResult = (n1, n2) => n1 + n2;
            Predicate<int> verificarPar = (int n1) => n1 % 2 == 0;

            imprimirMsg("Olá Mundo!!");
            Console.WriteLine(imprimirResult(3, 4));
            Console.WriteLine(verificarPar(3) ? "É par" : "É impar");
        }
    }
}
