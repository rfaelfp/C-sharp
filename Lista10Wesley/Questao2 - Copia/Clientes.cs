using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class Clientes
    {
        ClienteDados[] clientes;

        public Clientes (ClienteDados[] Clientes)
        {
            clientes = Clientes;
        }
        public void iniciarVet()
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                clientes[i] = new ClienteDados("", "", "", "", false, false, 0, true);
            }
        }

        public void cadastrar (Agencia ag)
        {
            string ver;
            for (int i = 0; i < clientes.Length; i++)
            {
                ag.printAg();
                clientes[i].ler();
                Console.Write("\nCadastrar outro cliente ? (s/n)");
                ver = Console.ReadLine();
                Console.Clear();
                if (ver != "sim" && ver != "s" && ver != "1")
                {
                    Console.Clear();
                    break;
                }
            }
        }
        public void inativar (Agencia ag)
        {
            int agencia, cli;
            ag.printAg();
            Console.Write("Escolha a agência que está o cliente: ");
            agencia = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < clientes.Length; i++)
                clientes[i].listaClienteAgencia(ref agencia, ref i);
            Console.Write("Escolha o cliente que deseja inativar: ");
            cli = Convert.ToInt32(Console.ReadLine());
            clientes[cli].inativa();

        }
        public void PrintCliente(int agencia)
        {
            for (int i = 0; i < clientes.Length; i++)
                clientes[i].listaClienteAgencia(ref agencia, ref i);
        }
    }
}
