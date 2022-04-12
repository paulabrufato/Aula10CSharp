using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Calculadora.src
{
    public class Triangulo : Calculos
    {
        public double Altura { get; set; }
        public double Base { get; set; }
        public double AreaTriangulo { get; set; }
        
        
                

        public Triangulo(){}

        public Triangulo(double altura, double Base, double AreaTriangulo)
        {
          
            Altura = altura;
            Base = Base;
            AreaTriangulo = _calculos.AreaTriangulo(altura, Base);

        }
        
    }
}