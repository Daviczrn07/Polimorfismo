using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    internal class Desenvolvedor : Funcionario
    {
        public virtual double CalcularBonusAnual()
        {
            return 0.12 * Salario;
        }
    }
}
