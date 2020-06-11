using System;

namespace Questao2
{
    class MenuEscolha
    {
        private int escolha;

        public MenuEscolha(int Escolha)
        {
            escolha = Escolha;
        }
        public int escolher()
        {
            Console.Write("\nEscolha a opção: ");
            escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return escolha;
        }
        public string[] DefineOpcao(ref int escolha)
        {
            string[] opcao = { };
            if (escolha == 0)
            {
                string[] opcoesMenu = { "Operações de agência", "Operação de conta", "Depósito/Transferência/Saldo" };
                opcao = opcoesMenu;
            }
            else if (escolha == 1)
            {
                string[] opcoesBanco = { "Incluir agência", "Excluir agência", "Imprimir dados agência", "Saldo do banco", "Saldo conta corrente", "Saldo conta poupança" };
                opcao = opcoesBanco;
            }
            else if (escolha == 2)
            {
                string[] opcoesAgencia = { "A abertura de conta em cada agência", "O encerramento de conta em cada agência", "A impressão de dados das contas de cada agência", "A impressão do saldo total depositado em cada agência", "A impressão do saldo total em conta corrente de cada agência", "A impressão do saldo total em conta poupança de cada agência" };
                opcao = opcoesAgencia;
            }
            else if (escolha == 3)
            {
                string[] opcoesConta = { "Realizar depósitos nas contas correntes", "Realizar depósitos nas contas poupança", "Realizar saques nas contas correntes", "Realizar saques nas contas poupanças", "Transferir dinheiro de conta corrente para conta poupança", "Transferir dinheiro de conta poupança para conta corrente", "Verificar o saldo de conta corrente", "Verificar o saldo de conta poupança", "Verificar o limite da conta corrente usado pelo cliente" };
                opcao = opcoesConta;
            }
            return opcao;
        }
        public void PrintOpcao(string[] op)
        {
            for (int i = 0; i < op.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] - {op[i]}");
            }
        }

    }
}
