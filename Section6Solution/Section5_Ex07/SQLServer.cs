using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Ex07 {
    internal class SQLServer : Database {
        public override void Configurar() {
            Console.WriteLine("Configurando"); ;
        }

        public override void Conectar() {
            Console.WriteLine("Conectando no SQL Server");
        }
    }
}
