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
        public void iniciarVet ()
        {
            for(int i = 0; i < dados.Length; i++)
                dados[i] = new AgenciaDados("", "", "");
        }       

        public void lerAgencia()
        {
            string verif;
            for (int i = 0; i < dados.Length; i++)
            {
                dados[i].ler();
                Console.Clear();
                Console.WriteLine("Deseja incluir outra agência? (s/n)");
                verif = Console.ReadLine();
                if (verif != "sim" && verif != "s" && verif != "1")
                {
                    Console.Clear();
                    break;
                }
            }
        }
        public void printAg ()
        {
            for (int i = 0; i < dados.Length; i++)
                dados[i].print(ref i);
        }
        public void excluirAgencia ()
        {
            int escolha;
            printAg();
            Console.Write("Escolha a opção que deseja excluir: ");
            escolha = Convert.ToInt32(Console.ReadLine());
            dados[escolha - 1].apagar();
            Console.Write($"Agência {escolha} excluída\nPressione ENTER para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }

}
