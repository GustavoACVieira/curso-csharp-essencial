using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7_Ex03 {
    internal class ClasseGenerica<T> where T : struct, IComparable, IConvertible, IFormattable {
        public T ADDNum(T num1, T num2) {
            dynamic dynamicNum1 = num1;
            dynamic dynamicNum2 = num2;
            return dynamicNum1 + dynamicNum2;
        }
    }
}
