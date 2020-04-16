using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            string url = getUrl();

            Console.WriteLine("Protocolo: " + getProtocolo(url));
            Console.WriteLine("Site: " + getSite(url));
            Console.WriteLine("Estrutura de diretórios: " + getDiretorios(url));
            Console.WriteLine("Página: " + getPagina(url));
            Console.WriteLine("Extensão: " + getExtensao(url));
            }

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
        static string getSite(string url)
        {
            int i;
            string urlMod = "";
            for (i = getProtocolo(url).Length; url[i] != '/'; i++)
                urlMod += url[i];
            return urlMod;
        }
        static string getDiretorios(string url)
        {
            int i, j;
            i = getSite(url).Length + getProtocolo(url).Length + 1;
            j = url.Length - getPagina(url).Length - i;
            return url.Substring(i, j);
        }
        static string getPagina(string url)
        {
            int i;
            for (i = url.Length - 1; url[i] != '/'; i--) ;
            return url.Substring(i);
        }
        static string getExtensao(string url)
        {
            int i;
            for (i = url.Length - 1; url[i] != '.'; i--) ;
            return url.Substring(i);
        }
    }
}
