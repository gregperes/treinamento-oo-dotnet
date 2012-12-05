using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreinamentoOrientacaoObjetos.Polimorfismo
{
    public class Gerente : Funcionario
    {
        public override void CalcularBonus()
        {
            Console.WriteLine("Gerente ganha 20% do salario de bonus!");
        }
    }
}
