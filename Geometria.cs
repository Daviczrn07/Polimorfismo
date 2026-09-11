using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class Geometria
    {
        public double CalcularArea(double Lado)
        {
            return Lado * Lado;
        }

        public double CalcularArea(double Base, double Altura)
        {
            return Base * Altura;
        }

        public double CalcularArea(double Raio, bool isCirculo)
        {
            return Math.PI * Raio * Raio;
        }
    }
}
