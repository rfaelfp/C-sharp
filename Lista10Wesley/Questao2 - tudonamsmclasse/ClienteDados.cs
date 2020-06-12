using System;

namespace Questao2
{
    class ClienteDados
    {
        private string nome, cpf, telefone, nascimento;
        private bool corrente, poupanca, ativo;
        private int agencia, codigoCorrente, codigoPoupanca;
        private double saldoCorrente, saldoPoupanca;


        public ClienteDados(string Nome, string Cpf, string Telefone, string Nascimento, bool Corrente, bool Poupanca, int Agencia, bool Ativo, int CodigoCorrente, int CodigoPoupanca, double SaldoCorrente, double SaldoPoupanca)
        {
            nome = Nome;
            cpf = Cpf;
            telefone = Telefone;
            nascimento = Nascimento;
            corrente = Corrente;
            poupanca = Poupanca;
            agencia = Agencia;
            ativo = Ativo;
            codigoCorrente = CodigoCorrente;
            codigoPoupanca = CodigoPoupanca;
            saldoCorrente = SaldoCorrente;
            saldoPoupanca = SaldoPoupanca;
        }
        public void ler()
        {
            Console.Write("Escolha a agência que o cliente será cadastrado: ");
            agencia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("Telefone: ");
            telefone = Console.ReadLine();
            Console.Write("Data nascimento: ");
            nascimento = Console.ReadLine();
            Console.Write("Conta corrente: (s/n) ");
            string inputString = Console.ReadLine();
            if (inputString.ToLower() == "s")
            {
                corrente = true;
                Console.Write("Codigo conta corrente: ");
                codigoCorrente = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserir saldo: ");
                saldoCorrente = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Conta poupança: (s/n) ");
            inputString = Console.ReadLine();
            if (inputString.ToLower() == "s")
            {
                poupanca = true;
                Console.Write("Codigo conta poupanca: ");
                codigoPoupanca = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserir saldo: ");
                saldoPoupanca = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void inativa()
        {
            Console.Write("Confirme a inativação: (s/n)");
            string inputString = Console.ReadLine();
            if (inputString.ToLower() == "s")
                ativo = false;
            Console.Clear();
        }
        public bool PosicaoLivre()
        {
            bool ver = false;
            if (nome == "" && cpf == "" && nascimento == "")
                ver = true;
            return ver;
        }
        public void listaClienteAgencia(ref int numAgencia, ref int num)
        {
            if (numAgencia == agencia)
                Console.WriteLine($"[{num}] - Cliente: {nome} - CPF: {cpf} - Tel.: {telefone}");
        }
        public void ListarClientes(ref int num)
        {
            Console.WriteLine($"[{num}] - Cliente: {nome} - CPF: {cpf} - Tel.: {telefone}");
        }
        public double SomaTotalBanco()
        {
            double acumula = 0;
            if (codigoCorrente != 0)
                acumula += saldoCorrente;
            if (codigoPoupanca != 0)
                acumula += saldoPoupanca;
            return acumula;
        }
        public double SomaTotalBancoCorrente()
        {
            double acumula = 0;
            if (codigoCorrente != 0)
                acumula += saldoCorrente;
            return acumula;
        }
        public double SaldoTotalBancoPoupanca()
        {
            double acumula = 0;
            if (codigoPoupanca != 0)
                acumula += saldoPoupanca;
            return acumula;
        }
        public double SomaContasAgencia(int ag)
        {
            double acumula = 0;
            if (codigoCorrente != 0 && ag == agencia)
                acumula += saldoCorrente;
            if (codigoPoupanca != 0 && ag == agencia)
                acumula += saldoPoupanca;
            return acumula;
        }
        public double SomaCorrenteAgencia(int ag)
        {
            double acumula = 0;
            if (codigoCorrente != 0 && ag == agencia)
                acumula += saldoCorrente;
            return acumula;
        }
        public double SomaPoupancaAgencia(int ag)
        {
            double acumula = 0;
            if (codigoCorrente != 0 && ag == agencia)
                acumula += saldoPoupanca;
            return acumula;
        }
        public void DepositarCorrente(double valor)
        {
            saldoCorrente += valor;
        }
        public void DepositarPoupanca(double valor)
        {
            saldoPoupanca += valor;
        }
        public void SaqueCorrente(double valor)
        {
            saldoCorrente -= valor;
        }
        public void SaquePoupanca(double valor)
        {
            saldoPoupanca -= valor;
        }
        public void TransfCorrentePoupanca()
        {
            bool ver = false;
            double valor;
            Console.WriteLine($"Saldo conta corrente: R$: {Math.Round(saldoCorrente, 2)}");
            Console.WriteLine($"Saldo conta poupança: R$: {Math.Round(saldoPoupanca, 2)}");
            do
            {
                Console.WriteLine("Digite o valor da transferência: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor > saldoCorrente)
                    Console.WriteLine("Não há saldo suficiente!");
                else
                {
                    saldoCorrente -= valor;
                    saldoPoupanca += valor;
                    Console.WriteLine("Transferência realizada!");
                    ver = true;
                }
            } 
                while (ver == false) ;

        }
    }
}
