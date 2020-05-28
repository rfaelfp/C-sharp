using System;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World!");
    }
    struct Pessoa
    {
        public string nome, dataNascimento;

        public Pessoa (string nome, string dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }
    }
    struct PessoaFisica
    {
        public int cpf;
        public Pessoa pessoa;

        public PessoaFisica(string nome, string dataNascimento, int cpf)
        {
            this.pessoa.nome = nome;
            this.pessoa.dataNascimento = dataNascimento;
            this.cpf = cpf;
        }
    }
    struct PessoaJuridica
    {
        public int cnpj;
        public Pessoa pessoa;

        public PessoaJuridica (string nome, string dataNascimento, int cnpj)
        {
            this.pessoa.nome = nome;
            this.pessoa.dataNascimento = dataNascimento;
            this.cnpj = cnpj;
        }
    }
    struct Cadastro
    {
        public int qtdPF, qtdPJ;
        public PessoaFisica[] pessoasFisicas;
        public PessoaJuridica[] pessoasJuridicas;

        public Cadastro (PessoaFisica[], )

    }
}