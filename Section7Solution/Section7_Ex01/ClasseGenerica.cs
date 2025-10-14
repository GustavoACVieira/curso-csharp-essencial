using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7_Ex01 {
    internal class ClasseGenerica<T> {
        public T[] obj = new T[5];
        public int count = 0;

        public void Adicionar(T obj) {
            if (count < 5) {
                this.obj[count] = obj;
            }
            count++;
        }

        public T this[int index] {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
}
