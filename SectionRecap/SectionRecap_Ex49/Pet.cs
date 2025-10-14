using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionRecap_Ex49 {
    internal class Pet {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Som { get; set; }

        public Pet(string? nome, int idade, string? som) {
            Nome = nome;
            Idade = idade;
            Som = som;
        }
    }
}
