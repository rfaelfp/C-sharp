using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class MenuEscolha
    {
        private int escolha;
        private string[] opcao;

            public MenuEscolha (int Escolha, string[] Opcao)
        {
            escolha = Escolha;
            opcao = Opcao;
        }
        public int escolher ()
        {
            do
            {
                Console.Write("\nEscolha a opção: ");
                escolha = Convert.ToInt32(Console.ReadLine());
            }
            while (escolha < 1 || escolha > opcao.Length);
            Console.Clear();
            return escolha;
        }
    }
}
