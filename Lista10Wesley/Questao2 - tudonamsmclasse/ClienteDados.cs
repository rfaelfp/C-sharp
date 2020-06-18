using System;

namespace Questao2
{
    class ClienteDados
    {
        private string nome, cpf, telefone, nascimento;
        private bool corrente, poupanca, ativo;
        private int agencia, codigoCorrente, codigoPoupanca;
        private double saldoCorrente, saldoPoupanca, limiteCorrente;


        public ClienteDados(string Nome, string Cpf, string Telefone, string Nascimento, bool Corrente, bool Poupanca, int Agencia, bool Ativo, int CodigoCorrente, int CodigoPoupanca, double SaldoCorrente, double SaldoPoupanca, double LimiteCorrente)
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
            limiteCorrente = LimiteCorrente;

        }
        public void ler()
        {
            Console.Write("\nEscolha a agência que o cliente será cadastrado: ");
            agencia = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
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
            }

            Console.Write("Conta poupança: (s/n) ");
            inputString = Console.ReadLine();
            if (inputString.ToLower() == "s")
            {
                poupanca = true;
                Console.Write("Codigo conta poupanca: ");
                codigoPoupanca = Convert.ToInt32(Console.ReadLine());
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
            {
                Console.WriteLine($"[{num}] - Cliente: {nome} - CPF: {cpf} - Tel.: {telefone} - Nascimento: {nascimento}");
                if (corrente == true)
                    Console.WriteLine($"Conta corrente: SIM - Código conta corrente: {codigoCorrente}");
                else
                    Console.WriteLine($"Conta poupança: NÃO - Código conta corrente: ---");
                if (poupanca == true)
                    Console.WriteLine($"Conta poupança: SIM - Código conta corrente: {codigoPoupanca}");
                else
                    Console.WriteLine($"Conta poupança: NÃO - Código conta corrente: ---");
                Console.Write("Status da conta: ");
                if (ativo == true)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ativo!\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Inativo!\n");
                    Console.ResetColor();
                }

            }
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
            Console.Write($"Saldo: {saldoCorrente - valor} - Valor depositado: {valor}\nTotal: {saldoCorrente}\n");
            Console.Write("\nAperte ENTER para voltar...");
            Console.ReadLine();
            Console.Clear();
        }
        public bool VerificarExistenciaCorrente ()
        {
            bool ver = false;
            if (corrente == true)
                ver = true;
            return ver;
        }
        public bool VerificarExistenciaPoupanca()
        {
            bool ver = false;
            if (poupanca == true)
                ver = true;
            return ver;
        }
        public void DepositarPoupanca(double valor)
        {
            saldoPoupanca += valor;
            Console.Write($"Saldo: {saldoPoupanca - valor} - Valor depositado: {valor}\nTotal: {saldoPoupanca}\n");
            Console.Write("\nAperte ENTER para voltar...");
            Console.ReadLine();
            Console.Clear();
        }
        public void SaqueCorrente(double valor)
        {

            Console.Write($"Saldo: {saldoCorrente}");
            saldoCorrente -= valor;
            Console.Write($" - Valor do saque: {valor}\nTotal: {saldoCorrente}\n");
            Console.Write("\nAperte ENTER para voltar...");
            Console.ReadLine();
            Console.Clear();
        }
        public void SaquePoupanca(double valor)
        {
            saldoPoupanca -= valor;
            Console.Write($"Saldo: {saldoPoupanca - valor} - Valor do saque: {valor}\nTotal: {saldoPoupanca}\n");
            Console.Write("\nAperte ENTER para voltar...");
            Console.ReadLine();
            Console.Clear();
        }
        public void TransfCorrentePoupanca()
        {
            bool ver = false;
            double valor;
            Console.WriteLine($"Saldo conta corrente: {saldoCorrente.ToString("C")}");
            Console.WriteLine($"Saldo conta poupança: {saldoPoupanca.ToString("C")}");
            do
            {
                Console.Write("Digite o valor da transferência: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor > saldoCorrente)
                    Console.WriteLine("Não há saldo suficiente!");
                else
                {
                    saldoCorrente -= valor;
                    saldoPoupanca += valor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Saldo conta corrente: {saldoCorrente.ToString("C")}");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Saldo conta poupança: {saldoPoupanca.ToString("C")}");
                    Console.ResetColor();
                    Console.WriteLine("Transferência realizada!");
                    ver = true;
                }
            } while (ver == false);
        }
        public void TransfPoupancaCorrente()
        {
            bool ver = false;
            double valor;
            Console.WriteLine($"Saldo conta corrente: {saldoCorrente.ToString("C")}");
            Console.WriteLine($"Saldo conta poupança: {saldoPoupanca.ToString("C")}");
            do
            {
                Console.Write("Digite o valor da transferência: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor > saldoPoupanca)
                    Console.WriteLine("Não há saldo suficiente!");
                else
                {
                    saldoPoupanca -= valor;
                    saldoCorrente += valor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Saldo conta corrente: {saldoCorrente.ToString("C")}");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Saldo conta poupança: {saldoPoupanca.ToString("C")}");
                    Console.ResetColor();
                    Console.WriteLine("Transferência realizada!");
                    ver = true;
                }
            } while (ver == false);
        }
        public void SaldoCorrente()
        {
            if (corrente == true)
            {
                Console.WriteLine($"O saldo da conta corrente é {saldoCorrente.ToString("C")}");
                Console.WriteLine($"O limite da conta corrente é {limiteCorrente.ToString("C")}");
            }
            else
                Console.WriteLine($"O cliente {nome} de CPF {cpf} não possui conta corrente!");
        }
        public void SaldoPoupanca()
        {
            if (poupanca == true)
                Console.WriteLine($"O saldo da conta poupanca é {saldoPoupanca.ToString("C")}");
            else
                Console.WriteLine($"O cliente {nome} de CPF {cpf} não possui conta poupança!");
        }
        public void SaqueLimiteCorrente(double valor)
        {
            string resp;
            if (valor > saldoCorrente)
            {
                if (valor > limiteCorrente + saldoCorrente)
                    Console.WriteLine($"O valor solicitado é maior que o limite do correntista\nSolicitado: {valor} - Limite: {limiteCorrente} - Saldo: {saldoCorrente}");
                else
                {
                    double limite = valor - saldoCorrente, porcento = valor * 0.08;
                    Console.WriteLine($"\nO saldo não é suficiente para operação.");
                    Console.WriteLine($"Saldo: {saldoCorrente.ToString("C")} - Valor solicitado {valor.ToString("C")}");
                    Console.WriteLine($"Você possui um limite de {limiteCorrente.ToString("C")}.");
                    Console.WriteLine($"Será descontado da sua conta corrente {saldoCorrente.ToString("C")} e subtraido do seu limite {limite.ToString("C")} acrescido de 8% ({porcento.ToString("C")})");
                    Console.Write("Gostaria de realizar o saque? (s/n)");

                    resp = Console.ReadLine();
                    if (resp != "s" && resp != "sim" && resp != "1")
                        Console.WriteLine("Cancelado!");
                    else
                    {
                        valor -= saldoCorrente;
                        valor += valor * 0.08;
                        limiteCorrente -= valor;
                        double saldoDevedor = 1000 - limiteCorrente;
                        Console.WriteLine($"Saldo devedor: {saldoDevedor}");
                        Console.WriteLine($"Limite: {limiteCorrente}");
                    }
                }

            }
        }
        public bool VerificarSaqueCorrente (double valor)
        {
            bool ver = false;
            if (valor < saldoCorrente)
                ver = true;

            return ver;

        }
        public void VerificaLimiteCorrente()
        {
            if (corrente == true)
            {
                Console.WriteLine($"O limite da conta corrente é {limiteCorrente.ToString("C")}");
            }
            else
                Console.WriteLine($"O cliente {nome} de CPF {cpf} não possui conta corrente!");
        }
        public void VerificaClientes(ref bool ver)
        {
            if (nome != "" && cpf != "" && telefone != "" && nascimento != "")
                ver = true;
        }
    }
}
