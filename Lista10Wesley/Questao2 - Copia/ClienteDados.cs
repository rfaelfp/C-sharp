using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Questao2
{
    class ClienteDados
    {
        private string nome, cpf, telefone, nascimento;
        private bool corrente, poupanca, ativo;
        private int agencia;

        public ClienteDados (string Nome, string Cpf, string Telefone, string Nascimento, bool Corrente, bool Poupanca, int Agencia, bool Ativo)
        {
            nome = Nome;
            cpf = Cpf;
            telefone = Telefone;
            nascimento = Nascimento;
            corrente = Corrente;
            poupanca = Poupanca;
            agencia = Agencia;
            ativo = Ativo;
        }
        public void ler ()
        {
            Console.Write("Escolha a agência que o cliente será cadastrada: ");
            agencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("Telefone: ");
            telefone = Console.ReadLine();
            Console.Write("Data nascimento: ");
            nascimento = Console.ReadLine();
            Console.Write("Conta corrente: (sim/não) ");
            string inputString = Console.ReadLine();
            if (inputString.ToLower() == "sim")
                corrente = true;
            Console.Write("Conta poupança: (sim/não) ");
            inputString = Console.ReadLine();
            if (inputString.ToLower() == "sim")
                poupanca = true;
        }
        public void inativa ()
        {
            Console.Write("Confirme a inativação: (sim/não)");
            string inputString = Console.ReadLine();
            if (inputString.ToLower() == "sim")
                ativo = false;
        }
        public void listaClienteAgencia(ref int numAgencia, ref int num)
        {            
            if (numAgencia == agencia)
                Console.WriteLine($"[{num}] - Cliente: {nome} - CPF: {cpf} - Tel.: {telefone}");
        }
    }
}
