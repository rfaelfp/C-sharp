using System;

class Programa
{
    static void Main()
    {
        PessoaFisica[] vetPessoaFisica = new PessoaFisica[3];
        PessoaJuridica[] vetPessoaJuridica = new PessoaJuridica[3];
        Cadastro cadastro = new Cadastro(vetPessoaFisica, vetPessoaJuridica);

        cadastro.cadastrar();

        cadastro.imprimirPessoasFísicas();
        cadastro.imprimirPessoasJuridicas();
    }
}

struct Pessoa
{
    public string nome;
    public string nascimento;

    public Pessoa(string nome, string nascimento)
    {
        this.nome = nome;
        this.nascimento = nascimento;
    }
}

struct PessoaFisica
{
    public Pessoa pessoa;
    public string cpf;

    public PessoaFisica(string nome, string nascimento, string cpf)
    {
        //this.pessoa = new Pessoa (nome, nascimento); ou
        this.pessoa.nome = nome;
        this.pessoa.nascimento = nascimento;
        this.cpf = cpf;
    }
}

struct PessoaJuridica
{
    public Pessoa pessoa;
    public string cnpj;

    public PessoaJuridica(string nome, string nascimento, string cnpj)
    {
        this.pessoa = new Pessoa(nome, nascimento);
        //ou this.pessoa.nome = nome;
        // this.pessoa.nascimento = nascimento;
        this.cnpj = cnpj;
    }
}

struct Cadastro
{
    public int qtdPessoasFisicas, qtdPessoasJuridicas;
    public PessoaFisica[] pessoasFisicas;
    public PessoaJuridica[] pessoasJuridicas;

    public Cadastro(PessoaFisica[] vetPFs, PessoaJuridica[] vetPJs)
    {
        this.pessoasFisicas = vetPFs;
        this.pessoasJuridicas = vetPJs;
        this.qtdPessoasFisicas = 0;
        this.qtdPessoasJuridicas = 0;
    }

    public void cadastrar()
    {
        string opcao;

        do
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Módulo de Cadastro");
            Console.ResetColor();

            Console.WriteLine("\nInforme: \n[1] Para cadastrar pessoa física. \n[2] Para cadastrar pessoa jurídica.");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                this.cadastrarPessoaFisica();
            }
            else
            {
                this.cadastrarPessoaJuridica();
            }
            Console.WriteLine("\nDeseja realizar um novo cadastro? \n[s] Para realizar um novo cadastro. \n[n] Para sair do módulo de cadastro.");
            opcao = Console.ReadLine().ToLower();

            Console.Clear();
        } while ((opcao == "s") || (opcao == "sim") || (opcao == "1"));
    }

    private void cadastrarPessoaFisica()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPessoa Física");
        Console.ResetColor();

        if (qtdPessoasFisicas < this.pessoasFisicas.Length)
        {
            Console.WriteLine("Informe o nome: ");
            this.pessoasFisicas[qtdPessoasFisicas].pessoa.nome = Console.ReadLine();

            Console.WriteLine("Informe a data de nascimento: ");
            this.pessoasFisicas[qtdPessoasFisicas].pessoa.nascimento = Console.ReadLine();

            Console.WriteLine("Informe o CPF: ");
            this.pessoasFisicas[qtdPessoasFisicas].cpf = Console.ReadLine();

            qtdPessoasFisicas++;
        }
        else
            Console.WriteLine("Atenção: cadastro cheio! O cadastro tem limite máximo de {0} registros.", this.pessoasFisicas.Length);
    }

    private void cadastrarPessoaJuridica()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPessoa Juridica");
        Console.ResetColor();

        if (qtdPessoasJuridicas < this.pessoasJuridicas.Length)
        {
            Console.WriteLine("Informe o nome: ");
            this.pessoasJuridicas[qtdPessoasJuridicas].pessoa.nome = Console.ReadLine();

            Console.WriteLine("Informe a data de nascimento: ");
            this.pessoasJuridicas[qtdPessoasJuridicas].pessoa.nascimento = Console.ReadLine();

            Console.WriteLine("Informe o CPF: ");
            this.pessoasJuridicas[qtdPessoasJuridicas].cnpj = Console.ReadLine();

            qtdPessoasJuridicas++;
        }
        else
            Console.WriteLine("Atenção: cadastro cheio! O cadastro tem limite máximo de {0} registros.", this.pessoasFisicas.Length);
    }

    public void imprimirPessoasFísicas()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPessoas Físicas");
        Console.ResetColor();

        for (int i = 0; i < this.qtdPessoasFisicas; i++)
            Console.WriteLine("{0}, {1}, {2}", this.pessoasFisicas[i].pessoa.nome, this.pessoasFisicas[i].pessoa.nascimento, this.pessoasFisicas[i].cpf);
    }

    public void imprimirPessoasJuridicas()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPessoas Juridicas");
        Console.ResetColor();

        for (int i = 0; i < this.qtdPessoasJuridicas; i++)
            Console.WriteLine("{0}, {1}, {2}", this.pessoasJuridicas[i].pessoa.nome, this.pessoasJuridicas[i].pessoa.nascimento, this.pessoasJuridicas[i].cnpj);
    }
}