using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreinamentoOrientacaoObjetos.Encapsulamento
{
    public class Cliente
    {
        private string cpf;

        public string CPF
        {
            get { return this.cpf; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("O CPF nao pode ser vazio!");
                    return;
                }

                this.cpf = value; 
            }
        }
    }
}