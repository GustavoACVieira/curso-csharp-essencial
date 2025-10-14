using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7_Ex07 {
    internal class Exemplo {
        public static void ReverterEImprimir<T>(T[] valor) {
            Array.Reverse(valor);
            foreach (T item in valor) {
                Console.WriteLine(item);
            }
        }

    }
}
