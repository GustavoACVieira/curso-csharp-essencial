using System;

namespace Section5_Params1 {
    internal class Calcular {
        public static int Soma(params int[] numeros) {
            int total = 0;
            foreach (int nmr in numeros)
                total += nmr;
            return total;
        }
    }
}
