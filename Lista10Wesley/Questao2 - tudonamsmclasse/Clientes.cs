using System;

namespace Questao2
{
    class Clientes
    {
        ClienteDados[] clientes;

        public Clientes(ClienteDados[] Clientes)
        {
            clientes = Clientes;
        }
        public void iniciarVet()
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                clientes[i] = new ClienteDados("", "", "", "", false, false, 0, true, 0, 0, 0, 0);
            }
        }
        public int PosicaoLivreVet()
        {
            int posicao = 0;
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i].PosicaoLivre() == true)
                {
                    posicao = i;
                    break;
                }
            }
            return posicao;
        }

        public void cadastrar(Agencia ag)
        {
            string ver;
            for (int i = PosicaoLivreVet(); i < clientes.Length; i++)
            {
                ag.printAg();
                clientes[i].ler();
                Console.Clear();
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
        public void inativar(Agencia ag)
        {
            int cli;
            int agencia = GetAgencia(ag);
            for (int i = 0; i < clientes.Length; i++)
                clientes[i].listaClienteAgencia(ref agencia, ref i);
            Console.Write("Escolha o cliente que deseja inativar: ");
            cli = Convert.ToInt32(Console.ReadLine());
            clientes[cli].inativa();

        }
        public void PrintCliente(Agencia ag)
        {
            int agencia = GetAgencia(ag);
            for (int i = 0; i < clientes.Length; i++)
                clientes[i].listaClienteAgencia(ref agencia, ref i);
        }
        public int GetAgencia(Agencia ag)
        {
            int agencia;
            ag.printAg();
            Console.Write("Escolha a agência: ");
            agencia = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return agencia;
        }
        public void SaldoTotalBanco()
        {
            double total = 0;
            for (int i = 0; i < clientes.Length; i++)
                total += (clientes[i].SomaTotalBanco());
            Console.WriteLine($"O saldo total é R${Math.Round(total, 2)}");
            Rodape();
        }
        public void SaldoTotalBancoCorrente()
        {
            double total = 0;
            for (int i = 0; i < clientes.Length; i++)
                total += (clientes[i].SomaTotalBancoCorrente());
            Console.WriteLine($"O saldo total é R${Math.Round(total, 2)}");
            Rodape();
        }
        public void SaldoTotalBancoPoupanca()
        {
            double total = 0;
            for (int i = 0; i < clientes.Length; i++)
                total += (clientes[i].SaldoTotalBancoPoupanca());
            Console.WriteLine($"O saldo total é R${Math.Round(total, 2)}");
            Rodape();
        }
        public void SaldoTotalAgencia(Agencia ag)
        {
            double total = 0;
            int agencia = GetAgencia(ag);
            for (int i = 0; i < clientes.Length; i++)
            {
                total += (clientes[i].SomaContasAgencia(agencia));
            }
            Console.WriteLine($"O saldo total da agência [{agencia}] é R${Math.Round(total, 2)}");
            Rodape();
        }
        public void SaldoTotalCorrente(Agencia ag)
        {
            double total = 0;
            int agencia = GetAgencia(ag);
            for (int i = 0; i < clientes.Length; i++)
            {
                total += (clientes[i].SomaCorrenteAgencia(agencia));
            }
            Console.WriteLine($"O saldo total da agência [{agencia}] na conta corrente é R${Math.Round(total, 2)}");
            Rodape();
        }
        public void SaldoTotalPoupanca(Agencia ag)
        {
            double total = 0;
            int agencia = GetAgencia(ag);
            for (int i = 0; i < clientes.Length; i++)
            {
                total += (clientes[i].SomaPoupancaAgencia(agencia));
            }
            Console.WriteLine($"O saldo total da agência [{agencia}] na conta poupança é R${Math.Round(total, 2)}");
            Rodape();
        }
        public void DepositarCorrente(Agencia ag)
        {
            double valor;
            PrintCliente(ag);
            int numCliente;
            Console.WriteLine("Escolha o cliente: ");
            numCliente = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            clientes[numCliente].DepositarCorrente(valor);

        }
        public void DepositarPoupanca(Agencia ag)
        {
            double valor;
            PrintCliente(ag);
            int numCliente;
            Console.WriteLine("Escolha o cliente: ");
            numCliente = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            clientes[numCliente].DepositarCorrente(valor);
        }
        public void SaqueCorrente(Agencia ag)
        {
            double valor;
            PrintCliente(ag);
            int numCliente;
            Console.WriteLine("Escolha o cliente: ");
            numCliente = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            clientes[numCliente].SaqueCorrente(valor);
        }
        public void SaquePoupanca(Agencia ag)
        {
            double valor;
            PrintCliente(ag);
            int numCliente;
            Console.WriteLine("Escolha o cliente: ");
            numCliente = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());
            clientes[numCliente].SaquePoupanca(valor);
        }
        public void TransfCorrentePoupanca(Agencia ag)
        {
            int numCliente;
            PrintCliente(ag);
            Console.WriteLine("Escolha o cliente: ");
            numCliente = Convert.ToInt32(Console.ReadLine());
            clientes[numCliente].TransfCorrentePoupanca();
        }
        public void Rodape()
        {
            Console.Write("\nAperte ENTER para voltar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
