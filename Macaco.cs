using Heranca;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Macaco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Macaco: UGH UGH AAH AAH!");
        }
    }
}
