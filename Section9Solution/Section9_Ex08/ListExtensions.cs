using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9_Ex08 {
    public static class ListExtensions {
        public static int SomaNumerosImpares(this List<int> list) {
            int soma = 0;
            foreach (int i in list) {
                if (i % 2 != 0) {
                    soma += i;
                }
            }
            return soma;
        }
    }
}
