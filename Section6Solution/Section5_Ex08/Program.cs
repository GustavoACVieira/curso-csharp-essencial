using System.Runtime.Intrinsics.X86;

namespace Section5_Ex08 {
    internal class Program {
        static void Main(string[] args) {
            Forma c = new Circulo(3.5);
            Console.WriteLine($"Área do círculo de raio 3.5. A = { c.Area()}");
            Forma q = new Quadrado(5.5);
            Console.WriteLine("Área do quadrado = {0}", q.Area());
            Forma t = new Triangulo(3.0, 5.0);
            Console.WriteLine("Área do triângulo = {0}", t.Area());
        }
    }
}
