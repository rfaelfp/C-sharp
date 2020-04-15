using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string url;
            string[] protocolo;
            Console.Write("Digite a url desejada: ");
            url = Convert.ToString(Console.ReadLine());
            protocolo = getProtocolo(url);
            //Console.WriteLine(protocolo);
        }
        static string[] getProtocolo(string urlRet)
        {
            int i;
            string[] retorno = new string[6];
            for (i = 0; i < 6; i++)
                retorno[i] += urlRet[i];
            Console.WriteLine(retorno);
            return retorno;
        }


    }
}
