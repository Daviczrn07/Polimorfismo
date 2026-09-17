using Heranca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Leao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Leão: Roar!");
        }
    }
}
