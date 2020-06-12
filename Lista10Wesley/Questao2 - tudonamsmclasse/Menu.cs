using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class Menu
    {
        private string[] opcao;

            public Menu (string[] Opcao)
        {
            opcao = Opcao;
        }
        public void print ()
        {
            Console.Clear();
            for (int i = 0; i < opcao.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] - {opcao[i]}");
            }
        }
    }
}
