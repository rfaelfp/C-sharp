using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class Contas
    {
        Clientes[] clientes;
        ContasDados dados;

        public Contas (Clientes[] Clientes, ContasDados Dados)
        {
            clientes = Clientes;
            dados = Dados;
        }

        public void ler()
        {
            int escolha;
            Console.WriteLine("Escolha o cliente que deseja abrir a conta: ");
            escolha = Convert.ToInt32(Console.ReadLine());
            clientes[escolha]
        }
    }
}
