using System;

namespace Questao2
{
    class AgenciaDados
    {
        private string codigo, endereco;
        private double telefone;

        public AgenciaDados(string Codigo, string Endereco, double Telefone)
        {
            codigo = Codigo;
            endereco = Endereco;
            telefone = Telefone;
        }

        public void ler ()
        {
            Console.Write("Códido da agência: ");
            codigo = Console.ReadLine();
            Console.Write("Endereço da agência: ");
            endereco = Console.ReadLine();
            Console.Write("Telefone da agência: ");
            telefone = Convert.ToDouble(Console.ReadLine());
        }
    }
}