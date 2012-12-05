using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreinamentoOrientacaoObjetos.Polimorfismo
{
    public class Programador : Funcionario
    {
        public override void CalcularBonus()
        {
            Console.WriteLine("Programador ganha 10% do salario de bonus!");
        }
    }
}
