using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animais.src
{
    public class VariedadeAnimal
    {
        public string Nome { get; set; }
        public string Filo { get; set; }
        public string Subclasse { get; set; }
        public string Grupos { get; set; }

        public VariedadeAnimal(){}

        public VariedadeAnimal(string nome, string filo, string subclasse, string grupos)
        {
            Nome = nome;
            Filo = filo;
            Subclasse = subclasse;
            Grupos = grupos;
        }
       
    }
}