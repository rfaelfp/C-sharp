using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            Console.WriteLine("Sistema Bancário");
            AgenciaDados[] agencia = new AgenciaDados[5];
            Agencia ag = new Agencia(agencia);
            ag.iniciarVet();
            string[] opcoesMenu = { "Operações de agência", "Operação de conta", "Depósito/Transferência/Saldo" };
            string[] opcoesBanco = { "Incluir agência", "Excluir agência", "Imprimir dados agência", "Saldo do banco", "Saldo conta corrente", "Saldo conta poupança" };
            string[] opcoesAgencia = { "A abertura de conta em cada agência", "O encerramento de conta em cada agência", "A impressão de dados das contas de cada agência", "A impressão do saldo total depositado em cada agência", "A impressão do saldo total em conta corrente de cada agência", "A impressão do saldo total em conta poupança de cada agência" };
            string[] opcoesConta = { "Realizar depósitos nas contas correntes", "Realizar depósitos nas contas poupança", "Realizar saques nas contas correntes", "Realizar saques nas contas poupanças", "Transferir dinheiro de conta corrente para conta poupança", "Transferir dinheiro de conta poupança para conta corrente", "Verificar o saldo de conta corrente", "Verificar o saldo de conta poupança", "Verificar o limite da conta corrente usado pelo cliente" };
            Menu menu = new Menu(opcoesMenu);
            Menu menuBanco = new Menu(opcoesBanco);
            Menu menuAgencia = new Menu(opcoesAgencia);
            Menu menuConta = new Menu(opcoesConta);
            MenuEscolha opM = new MenuEscolha(0, opcoesMenu);
            do
            {
                menu.print();
                switch (opM.escolher())
                {
                    case 1:
                        menuBanco.print();
                        MenuEscolha op1 = new MenuEscolha(0, opcoesBanco);
                        int e = op1.escolher();
                        if (e == 1)
                            ag.lerAgencia();
                        else if (e == 2)
                            ag.excluirAgencia();
                        else if (e == 3)
                            ag.printAg();

                        break;
                    case 2:
                        menuAgencia.print();
                        MenuEscolha op2 = new MenuEscolha(0, opcoesAgencia);
                        op2.escolher();
                        break;
                    case 3:
                        menuConta.print();
                        MenuEscolha op3 = new MenuEscolha(0, opcoesConta);
                        op3.escolher();
                        break;
                    default:
                        break;
                }
            } while (loop == true);
        }
    }
}
