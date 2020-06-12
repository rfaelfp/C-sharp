using System;

namespace Questao2
{
    class Contas
    {
        ContasDados[] dados;

        public Contas(ContasDados[] Dados)
        {
            dados = Dados;
        }
        public void iniciarVet()
        {
            for (int i = 0; i < dados.Length; i++)
                dados[i] = new ContasDados(0, 0, 0, 0, -1);
        }
        public void ler(Clientes c, Agencia ag)
        {
            int escolhaC, escolhaAg;
            ag.printAg();
            Console.WriteLine("Escolha a agência: ");
            escolhaAg = Convert.ToInt32(Console.ReadLine());
            c.PrintCliente(escolhaAg);
            Console.WriteLine("Escolha o cliente que deseja abrir a conta: ");
            escolhaC = Convert.ToInt32(Console.ReadLine());
            dados[escolhaC].LerDadosConta(ref escolhaC);
        }
    }
}
