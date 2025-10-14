using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Section8_Ex04 {
    internal class SaldoInsuficienteException : Exception {
        public SaldoInsuficienteException() {
        }

        public SaldoInsuficienteException(string? message) : base(message) {
        }

        public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException) {
        }

        
    }
}
