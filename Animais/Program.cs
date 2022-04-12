using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animais.src;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animais");

            List<VariedadeAnimal> animais = new List<VariedadeAnimal>(
                new VariedadeAnimal[]{
                    new Girafa("Girafa", "Chordata", "Vertebrados", "Terrestre"),
                    new Baleia("Baleia", "Chordata", "Vertebrados", "Aquático"),
                    new UrsoPolar("Urso Polar", "Chordata", "Vertebrados", "Terrestre e Aquático")
                }
            );
            foreach (VariedadeAnimal variedadeAnimal in animais)
            {
                if(variedadeAnimal.Grupos == "Terrestre")
                {
                    Console.WriteLine($"{variedadeAnimal.Nome} pertence ao Filo {variedadeAnimal.Filo} da subclasse dos {variedadeAnimal.Subclasse} e do grupo dos animais {variedadeAnimal.Grupos}");
                }
                else if(variedadeAnimal.Grupos == "Aquático")
                {
                   Console.WriteLine($"{variedadeAnimal.Nome} pertence ao Filo {variedadeAnimal.Filo} da subclasse dos {variedadeAnimal.Subclasse} e do grupo dos animais {variedadeAnimal.Grupos}"); 
                }
                else if(variedadeAnimal.Grupos == "Terrestre e Aquático")
                {
                   Console.WriteLine($"{variedadeAnimal.Nome} pertence ao Filo {variedadeAnimal.Filo} da subclasse dos {variedadeAnimal.Subclasse} e do grupo dos animais {variedadeAnimal.Grupos}"); 
                }
            }
        }
    }
}
