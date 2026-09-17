using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class Gerente : Funcionario
    {
        public virtual double CalcularBonusAnual()
        {
            return (0.15 * Salario) + 1000;
        }
    }
}
