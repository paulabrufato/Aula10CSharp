using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Calculadora.src
{
    public class Retangulo : Calculos
    {
         public double Altura { get; set; }
        public double Base { get; set; }
        public double AreaRetangulo { get; set; }
        
      

        public Retangulo(){}

        public Retangulo(double altura, double Base, double AreaRetangulo)
        {
           
            Altura = altura;
            Base = Base;
            AreaRetangulo = _calculos.Multiplicar(Altura, Base);

        }
              
    }
}