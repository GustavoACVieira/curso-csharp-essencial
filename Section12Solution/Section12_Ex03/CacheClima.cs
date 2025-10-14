using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12_Ex03 {
    internal class CacheClima {
        private Dictionary<string, double> cache = new Dictionary<string, double>();

        public async ValueTask<double> ObterTemperaturaAsync(string cidade) {
            if (cache.ContainsKey(cidade))
                return cache[cidade];

            Console.WriteLine("Buscando.....");
            await Task.Delay(5667);
            double aux = new Random().Next(15, 35);
            cache[cidade] = aux;
            return aux;
        }
    }
}
