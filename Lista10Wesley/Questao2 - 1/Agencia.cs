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
                dados[i] = new AgenciaDados("", "", 0);
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
                    break;
            }
        }
    }

}
