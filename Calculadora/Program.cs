using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.src;

namespace Calculadora
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            Calculos objeto = new Calculos();

            Console.WriteLine($"A área do triangulo é a base x altura / 2, resultando em: {objeto.AreaTriangulo}.");
            Console.WriteLine($"A área do retângulo é a base x sua altura, resultando em: {objeto.Multiplicar}.");
            Console.WriteLine($"A área do quadrado é lado x lado, resultando em: {objeto.Multiplicar}.");

            
        }
    }
}
