using Heranca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Cobra : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Cobra: SSSSSSSSSSSSS!");
        }
    }
}
