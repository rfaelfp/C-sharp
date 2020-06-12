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
            ContasDados[] contasDados = new ContasDados[15];
            Contas contas = new Contas(contasDados);
            contas.iniciarVet();
            MenuEscolha opM = new MenuEscolha(0);
            do
            {
                int op = 0;
                Console.WriteLine("Sistema Bancário");
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
                        else if (opSub1 == 4) ;
                        else if (opSub1 == 5) ;
                        else if (opSub1 == 6) ;
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
                            contas.ler(c, ag);
                        break;
                    case 3:
                        int op3 = 3;
                        opM.PrintOpcao(opM.DefineOpcao(ref op3));
                        break;
                    default:
                        break;
                }
            } while (loop == true);
        }
    }
}
