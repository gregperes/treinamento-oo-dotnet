using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreinamentoOrientacaoObjetos.Interface
{
    public class USBParaPc : IUSB
    {
        public void Conectar()
        {
            Console.WriteLine("conecto no pc");
        }

        public void Desconectar()
        {
            Console.WriteLine("desconecto no pc");
        }
    }
}