using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animais.src
{
    public class Baleia : VariedadeAnimal
    {
        public Baleia(){}
        public Baleia(string nome, string filo, string subclasse, string grupos) : base(nome, filo, subclasse, grupos) {}
    }
}