using System;

namespace Questao2
{
    class AgenciaDados
    {
        private string codigo, endereco, telefone;

        public AgenciaDados(string Codigo, string Endereco, string Telefone)
        {
            codigo = Codigo;
            endereco = Endereco;
            telefone = Telefone;
        }

        public void ler ()
        {
            Console.Write("Código da agência: ");
            codigo = Console.ReadLine();
            Console.Write("Endereço da agência: ");
            endereco = Console.ReadLine();
            Console.Write("Telefone da agência: ");
            telefone = Console.ReadLine();
        }
        public void apagar ()
        {
            codigo = "";
            endereco = "";
            telefone = "";
        }
        public void print (ref int i)
        {
            Console.WriteLine($"[{i + 1}] - Ag. {codigo} - {endereco} - {telefone}");
        }
    }
}