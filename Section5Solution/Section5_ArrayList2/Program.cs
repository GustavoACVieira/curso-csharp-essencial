using System.Collections;

namespace Section5_ArrayList2 {
    internal class Program {
        static void Main(string[] args) {
            //Incluir 1 unico elemento
            var lista = new ArrayList() { "Maria", 5, true, " ", null };

            lista.Add(3.5);

            lista.Insert(2, "Paulo");

            //Incluir 1 cloeção de elementos
            var lista2 = new ArrayList() { "Maria", 5, true };

            int[] array1 = { 1, 2, 3 };

            lista.AddRange(array1);
            lista.InsertRange(2, array1);
        }
    }
}
