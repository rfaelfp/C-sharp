using System;

namespace Questao2
{
    class Agencia
    {
        private AgenciaDados[] dados;

        public Agencia(AgenciaDados[] Dados)
        {
            this.dados = Dados;
        }
        public void iniciarVet()
        {
            for (int i = 0; i < dados.Length; i++)
                dados[i] = new AgenciaDados("", "", "");
        }
        public int PosicaoLivreVet()
        {
            int posicao = 0;
            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i].PosicaoLivre() == true)
                {
                    posicao = i;
                    break;
                }
            }
            return posicao;
        }

        public void lerAgencia()
        {
            string verif;
            for (int i = PosicaoLivreVet(); i < dados.Length; i++)
            {
                dados[i].ler();
                Console.Clear();
                Console.WriteLine("Deseja incluir outra agência? (s/n)");
                verif = Console.ReadLine();
                Console.Clear();
                if (verif != "sim" && verif != "s" && verif != "1")
                    break;
            }
        }
        public bool printAg()
        {
            bool ver = false;
            int contVer = 0;
            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i].print(ref i) == true)
                    contVer++;
                if (dados.Length == contVer)
                {
                    ver = true;
                    Console.WriteLine("Não há agências cadastradas!");
                    Console.Write($"\nPressione ENTER para voltar ao menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return ver;
        }
        public void excluirAgencia()
        {
            int escolha;
            printAg();
            Console.Write("\nEscolha a opção que deseja excluir: ");
            escolha = Convert.ToInt32(Console.ReadLine());
            dados[escolha - 1].apagar();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write($"\nAgência {escolha} excluída\n");
            Console.ResetColor();
            Console.Write("\nPressione ENTER para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }

}
