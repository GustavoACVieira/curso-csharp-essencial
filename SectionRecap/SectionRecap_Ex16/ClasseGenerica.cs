using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex16 {
    internal class Repository<T> {
        public List<T> _values = new();
        public void Add(T values) => _values.Add(values);
        public IEnumerable<T> ListAll() => _values;
    }
}
