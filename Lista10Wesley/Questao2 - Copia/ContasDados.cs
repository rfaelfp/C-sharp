using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class ContasDados
    {
        private int codigoCorrente, codigoPoupanca;
        private double saldoCorrente, saldoPoupanca;

        public ContasDados (int CodigoCorrente, int CodigoPoupanca, double SaldoCorrente, double SaldoPoupanca)
        {
            codigoCorrente = CodigoCorrente;
            codigoPoupanca = CodigoPoupanca;
            saldoCorrente = SaldoCorrente;
            saldoPoupanca = SaldoPoupanca;
        }

        public void ler ()
        {

        }
    }
}
