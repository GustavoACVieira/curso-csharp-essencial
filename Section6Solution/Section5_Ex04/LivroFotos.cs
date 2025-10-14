using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex04 {
    internal class LivroFotos {
        private int _numPaginas;
        public int NumPaginas {
            set { _numPaginas = value; }
        }

        public LivroFotos() {
            NumPaginas = 16;
        }

        public LivroFotos(int NumPaginas) {
            this.NumPaginas = NumPaginas;
        }

        public int GetNumeroPaginas() {
           return _numPaginas; 
        }
    }
}
