using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreinamentoOrientacaoObjetos.Interface
{
    public class USBParaMac : IUSB
    {
        public void Conectar()
        {
            Console.WriteLine("conecto no mac");
        }

        public void Desconectar()
        {
            Console.WriteLine("desconecto no mac");
        }
    }
}
