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
                    break;
            }
        }
        public void inativar ()
        {

        }
    }
}
