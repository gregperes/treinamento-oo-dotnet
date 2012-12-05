using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreinamentoOrientacaoObjetos.Encapsulamento;
using TreinamentoOrientacaoObjetos.Heranca;
using TreinamentoOrientacaoObjetos.Sobrecarga;
using TreinamentoOrientacaoObjetos.Polimorfismo;
using TreinamentoOrientacaoObjetos.Interface;

namespace TreinamentoOrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.CPF = string.Empty;

            var cachorro = new Cachorro();
            cachorro.Andar();
            cachorro.Comer();
            cachorro.Latir();

            var gerencia = new GerenciamentoConta();
            gerencia.Sacar(new ContaPoupanca());
            gerencia.Sacar(new ContaCorrente());

            var programador = new Programador();
            programador.CalcularBonus();

            var gerente = new Gerente();
            gerente.CalcularBonus();

            var usbpc = new USBParaPc();
            usbpc.Conectar();

            var usbmac = new USBParaMac();
            usbmac.Conectar();

            Console.ReadKey();
        }
    }
}
