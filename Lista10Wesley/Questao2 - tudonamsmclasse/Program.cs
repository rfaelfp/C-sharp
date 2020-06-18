using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            AgenciaDados[] agencia = new AgenciaDados[5];
            Agencia ag = new Agencia(agencia);
            ag.iniciarVet();
            ClienteDados[] clientes = new ClienteDados[15];
            Clientes c = new Clientes(clientes);
            c.iniciarVet();
            MenuEscolha opM = new MenuEscolha(0);
            do
            {
                int op = 0;
                opM.PrintOpcao(opM.DefineOpcao(ref op));
                switch (opM.escolher())
                {
                    case 1:
                        int op1 = 1;
                        opM.PrintOpcao(opM.DefineOpcao(ref op1));
                        int opSub1 = opM.escolher();
                        if (opSub1 == 1)
                            ag.lerAgencia();
                        else if (opSub1 == 2)
                            ag.excluirAgencia();
                        else if (opSub1 == 3)
                            ag.printAg();
                        else if (opSub1 == 4)
                            c.SaldoTotalBanco();
                        else if (opSub1 == 5)
                            c.SaldoTotalBancoCorrente();
                        else if (opSub1 == 6)
                            c.SaldoTotalBancoPoupanca();
                        break;
                    case 2:
                        int op2 = 2;
                        opM.PrintOpcao(opM.DefineOpcao(ref op2));
                        int opSub2 = opM.escolher();
                        if (opSub2 == 1)
                            c.cadastrar(ag);
                        else if (opSub2 == 2)
                            c.inativar(ag);
                        else if (opSub2 == 3)
                            c.PrintCliente(ag);
                        else if (opSub2 == 4)
                            c.SaldoTotalAgencia(ag);
                        else if (opSub2 == 5)
                            c.SaldoTotalCorrente(ag);
                        else if (opSub2 == 6)
                            c.SaldoTotalPoupanca(ag);
                        break;
                    case 3:
                        int op3 = 3;
                        opM.PrintOpcao(opM.DefineOpcao(ref op3));
                        int opSub3 = opM.escolher();
                        if (opSub3 == 1)
                            c.DepositarCorrente(ag);
                        else if (opSub3 == 2)
                            c.DepositarPoupanca(ag);
                        else if (opSub3 == 3)
                            c.SaqueCorrente(ag);
                        else if (opSub3 == 4)
                            c.SaquePoupanca(ag);
                        else if (opSub3 == 5)
                            c.TransfCorrentePoupanca(ag);
                        else if (opSub3 == 6)
                            c.TransfPoupancaCorrente(ag);
                        else if (opSub3 == 7)
                            c.SaldoCorrente(ag);
                        else if (opSub3 == 8)
                            c.SaldoPoupanca(ag);
                        else if (opSub3 == 9)
                            c.VerificaLimiteCorrente(ag);
                        else if (opSub3 == 10) ;
                        break;
                    default:
                        break;
                }
            } while (loop == true);
        }
    }
}
