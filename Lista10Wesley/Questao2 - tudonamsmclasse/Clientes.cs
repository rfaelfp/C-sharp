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
                clientes[i] = new ClienteDados("", "", "", "", false, false, 0, true, 0, 0, 0, 0, 1000);
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
                if (ag.printAg() == false)
                {

                    clientes[i].ler();
                    Console.Clear();
                    Console.Write("Cadastrar outro cliente ? (s/n)");
                    ver = Console.ReadLine();
                    Console.Clear();
                    if (ver != "sim" && ver != "s" && ver != "1")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                    break;
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
        public bool PrintCliente(Agencia ag)
        {
            bool ver = false;
            int agencia = GetAgencia(ag);
            if (agencia != -1)
            {
                for (int i = 0; i < clientes.Length; i++)
                    clientes[i].listaClienteAgencia(ref agencia, ref i);
                ver = true;
            }
            return ver;

        }
        public int GetAgencia(Agencia ag)
        {
            int agencia = -1;
            if (ag.printAg() == false)
            {
                Console.Write("\nEscolha a agência: ");
                agencia = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            return agencia;
        }
        public bool VerificaCliente()
        {
            bool ver = false;
            for (int i = 0; i < clientes.Length; i++)
                clientes[i].VerificaClientes(ref ver);
            return ver;
        }
        public void SaldoTotalBanco()
        {
            double total = 0;
            for (int i = 0; i < clientes.Length; i++)
                total += (clientes[i].SomaTotalBanco());
            Console.WriteLine($"O saldo total é {total.ToString("C")}");
            Rodape();
        }
        public void SaldoTotalBancoCorrente()
        {
            double total = 0;
            for (int i = 0; i < clientes.Length; i++)
                total += (clientes[i].SomaTotalBancoCorrente());
            Console.WriteLine($"O saldo total é {total.ToString("C")}");
            Rodape();
        }
        public void SaldoTotalBancoPoupanca()
        {
            double total = 0;
            for (int i = 0; i < clientes.Length; i++)
                total += (clientes[i].SaldoTotalBancoPoupanca());
            Console.WriteLine($"O saldo total é {total.ToString("C")}.");
            Rodape();
        }
        public void SaldoTotalAgencia(Agencia ag)
        {
            double total = 0;
            int agencia = GetAgencia(ag);
            if (agencia != -1)
            {
                for (int i = 0; i < clientes.Length; i++)
                {
                    total += (clientes[i].SomaContasAgencia(agencia));
                }
                Console.WriteLine($"O saldo total da agência [{agencia}] é {total.ToString("C")}.");
                Rodape();
            }
        }
        public void SaldoTotalCorrente(Agencia ag)
        {
            double total = 0;
            int agencia = GetAgencia(ag);
            if (agencia != -1)
            {
                for (int i = 0; i < clientes.Length; i++)
                {
                    total += (clientes[i].SomaCorrenteAgencia(agencia));
                }
                Console.WriteLine($"O saldo total da agência [{agencia}] na conta corrente é {total.ToString("C")}.");
                Rodape();
            }
        }
        public void SaldoTotalPoupanca(Agencia ag)
        {
            double total = 0;
            int agencia = GetAgencia(ag);
            if (agencia != -1)
            {
                for (int i = 0; i < clientes.Length; i++)
                {
                    total += (clientes[i].SomaPoupancaAgencia(agencia));
                }
                Console.WriteLine($"O saldo total da agência [{agencia}] na conta poupança é {total.ToString("C")}.");
                Rodape();
            }
        }
        public void DepositarCorrente(Agencia ag)
        {
            double valor;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    int numCliente;
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    if (clientes[numCliente].VerificarExistenciaCorrente() == true)
                    {
                        Console.Write("Digite o valor: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        clientes[numCliente].DepositarCorrente(valor);
                    }
                    else
                    {
                        Console.WriteLine("O cliente não possui conta corrente.");
                        Rodape();
                    }
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();
                }
            }


        }
        public void DepositarPoupanca(Agencia ag)
        {
            double valor;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    int numCliente;
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    if (clientes[numCliente].VerificarExistenciaPoupanca() == true)
                    {
                        Console.Write("Digite o valor: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        clientes[numCliente].DepositarPoupanca(valor);
                        Rodape();
                    }
                    else
                    {
                        Console.WriteLine("O cliente não possui conta poupança.");
                        Rodape();
                    }
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();
                }
            }
        }
        public void SaqueCorrente(Agencia ag)
        {
            double valor;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    int numCliente;
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    if (clientes[numCliente].VerificarExistenciaCorrente() == true)
                    {
                        Console.Write("Digite o valor: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        if (clientes[numCliente].VerificarSaqueCorrente(valor) == true)
                            clientes[numCliente].SaqueCorrente(valor);
                        else
                            clientes[numCliente].SaqueLimiteCorrente(valor);
                        Rodape();
                    }
                    else
                    {
                        Console.WriteLine("O cliente não possui conta corrente.");
                        Rodape();
                    }

                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();
                }
            }
        }
        public void SaquePoupanca(Agencia ag)
        {
            double valor;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    int numCliente;
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    if (clientes[numCliente].VerificarExistenciaPoupanca() == true)
                    {

                        Console.Write("Digite o valor: ");
                        valor = Convert.ToDouble(Console.ReadLine());
                        clientes[numCliente].SaquePoupanca(valor);
                        Rodape();
                    }
                    else
                    {
                        Console.WriteLine("O cliente não possui conta poupança.");
                        Rodape();
                    }
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();
                }
            }
        }
        public void TransfCorrentePoupanca(Agencia ag)
        {
            int numCliente;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    if (clientes[numCliente].VerificarExistenciaCorrente() == true && clientes[numCliente].VerificarExistenciaPoupanca() == true)
                    {
                        clientes[numCliente].TransfCorrentePoupanca();
                        Rodape();
                    }
                    else
                    {
                        Console.WriteLine("O cliente não possui conta corrent e/ou conta poupança");
                        Rodape();
                    }
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();
                }
            }
        }
        public void TransfPoupancaCorrente(Agencia ag)
        {
            int numCliente;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    if (clientes[numCliente].VerificarExistenciaCorrente() == true && clientes[numCliente].VerificarExistenciaPoupanca() == true)
                    {
                        clientes[numCliente].TransfCorrentePoupanca();
                        Rodape();
                    }
                    else
                    {
                        Console.WriteLine("O cliente não possui conta corrente e/ou conta poupança");
                        Rodape();
                    }
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();
                }
            }

        }
        public void SaldoCorrente(Agencia ag)
        {
            int numCliente;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    clientes[numCliente].SaldoCorrente();
                    Rodape();
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();
                }
            }

        }
        public void SaldoPoupanca(Agencia ag)
        {
            int numCliente;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    clientes[numCliente].SaldoPoupanca();
                    Rodape();
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();

                }
            }
        }
        public void VerificaCorrente(Agencia ag)
        {
            int numCliente;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    clientes[numCliente].SaldoPoupanca();
                    Rodape();
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();

                }
            }
        }
        public void VerificaLimiteCorrente(Agencia ag)
        {
            int numCliente;
            if (PrintCliente(ag) == true)
            {
                if (VerificaCliente() == true)
                {
                    Console.Write("Escolha o cliente: ");
                    numCliente = Convert.ToInt32(Console.ReadLine());
                    clientes[numCliente].VerificaLimiteCorrente();
                    Rodape();
                }
                else
                {
                    Console.WriteLine("Não há clientes cadastrados na agência!");
                    Rodape();

                }
            }
        }
        public void Rodape()
        {
            Console.Write("\nAperte ENTER para voltar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}