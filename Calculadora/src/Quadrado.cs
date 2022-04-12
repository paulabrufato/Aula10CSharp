using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Calculadora.src
{
    public class Quadrado : Calculos
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double AreaQuadrado { get; set; }
       

        public Quadrado(){}

        public Quadrado(double lado1, double lado2, double areaquadrado)
        {
            
            Lado1 = lado1;
            Lado2 = lado2;
            AreaQuadrado = _calculos.Multiplicar(lado1, lado2);

        }
      
    }
}