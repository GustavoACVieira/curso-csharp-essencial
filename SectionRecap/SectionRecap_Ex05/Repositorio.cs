using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex05 {
    internal class Repositorio<T> {
        public List<T> list = new List<T>();

        public List<T> Adicionar(T item) {
            list.Add(item);
            return list;
        }

        public void Listar() {
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }
    }
}
