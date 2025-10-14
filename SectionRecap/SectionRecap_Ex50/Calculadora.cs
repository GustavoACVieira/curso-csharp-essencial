using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex50 {
    internal class Calculadora {
        public double Somar(double x, double y) {
            return x + y;
        }

        public double Subtrair(double x, double y) {
            return x - y;
        }

        public double Multiplicar(double x, double y) {
            return x * y;
        }

        public double Dividir(double x, double y) {
            if (y == 0) throw new DivideByZeroException("Divisão por zero é impossível!");
            return x / y;
        }
    }
}
