using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class ContasDados
    {
        private int codigoCorrente, codigoPoupanca, cliente;
        private double saldoCorrente, saldoPoupanca;

        public ContasDados (int CodigoCorrente, int CodigoPoupanca, double SaldoCorrente, double SaldoPoupanca, int Cliente)
        {
            codigoCorrente = CodigoCorrente;
            codigoPoupanca = CodigoPoupanca;
            saldoCorrente = SaldoCorrente;
            saldoPoupanca = SaldoPoupanca;
            cliente = Cliente;
        }

        public void LerDadosConta (ref int escolha)
        {
            Console.Write("Codigo conta corrente: ");
            codigoCorrente = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserir saldo: ");
            saldoCorrente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Código poupança: ");
            codigoPoupanca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserir saldo: ");
            saldoPoupanca = Convert.ToDouble(Console.ReadLine());
            cliente = escolha;
        }
    }
}
