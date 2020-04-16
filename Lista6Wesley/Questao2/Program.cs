using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = getUrl();

            Console.Write(getProtocolo(url));
            Console.WriteLine(getEndereco(url);
        }
        static string getUrl()
        {
            string url;
            Console.Write("Digite a url desejada: ");
            url = Convert.ToString(Console.ReadLine());
            return url;
        }
        static string getProtocolo(string url)
        {
            url = url.Substring(0, 5) == "https" ? url.Substring(0, 8) : url.Substring(0, 7);
            return url;
        }   
        static string getEndereco(string url)
        {

        }
    }
}
