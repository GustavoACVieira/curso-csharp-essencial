using System.Collections;

namespace Section5_ArrayList3 {
    internal class Program {
        static void Main(string[] args) {
            //Removendo elementos
            var lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, null };

            lista.Remove(null);

            lista.RemoveAt(4);

            lista.RemoveRange(0, 2);
        }
    }
}
