using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string url; 
            url = getUrl();

            getProtocolo(url);
        }
        static string getUrl()
        {
            string url;
            Console.Write("Digite a url desejada: ");
            url = Convert.ToString(Console.ReadLine());
            return url;
        }
        static void getProtocolo(string url)
        {
            if (url.Substring(0, 5) == "https")
            Console.Write(url.Substring(0, 8));
            else
            {
                Console.Write(url.Substring(0, 7));
            }
            
        }   
    }
}
