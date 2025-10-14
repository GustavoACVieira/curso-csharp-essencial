using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex07 {
    abstract class Database {
        public virtual void Conectar() {
            Console.WriteLine("Conectando ao banco de dados...");
        }
        public abstract void Configurar();
    }
}
