using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Bancário");
            AgenciaDados[] agencia = new AgenciaDados[5];
            Agencia ag = new Agencia(agencia);
            ag.iniciarVet();
            //menu();
            switch (menu())
            {
                case 1:
                    ag.lerAgencia();
                    break;
                default:
                    break;
            }
        }
        static int menu()
        {
            int cont = 1, opGeral, opSubMenu = 0;
            string[] opcao = { "Operações de agência", "Operação de conta", "Depósito/Transferência/Saldo" };
            string[] opcaoAg = { "Incluir agência", "Excluir agência", "Imprimir dados agência", "Saldo do banco", "Saldo conta corrente", "Saldo conta poupança" };
            for (int i = 0; i < opcao.Length; i++)
            {
                Console.WriteLine($"[{cont}] - {opcao[i]}");
                cont++;
            }
            Console.Write("\nEscolha a opção: ");
            opGeral = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (opGeral == 1)
            {
                cont = 1;
                for (int i = 0; i < opcaoAg.Length; i++)
                {
                    Console.WriteLine($"[{cont}] - {opcaoAg[i]}");
                    cont++;
                }
                Console.Write("\nEscolha a opção: ");
                opSubMenu = Convert.ToInt32(Console.ReadLine());
            }
                return opSubMenu;
        }
    }
}
