using System.Collections;

namespace Section5_ArrayList4 {
    internal class Program {
        static void Main(string[] args) {
            //Verificando se um elemento esta na coleção
            var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

            var res1 = lista.Contains(5);
            var res2 = lista.Contains(null);

            bool res3 = lista.Contains(45);
            bool res4 = lista.Contains("Mari");

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(lista.Contains("Mari"));

            //Ordenando
            var lista2 = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

            lista2.Sort();

            //Removendo todos os elementos sem alterar capacity
            lista2.Clear();
        }
    }
}
