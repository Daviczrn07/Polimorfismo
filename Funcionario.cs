using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalcularBonusAnual()
        {
            return 0.1 * Salario;
        }

    }

}


