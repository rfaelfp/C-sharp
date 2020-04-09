using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool verificacao = true;
            while (verificacao == true)
            {
                inverterNumero();
                Console.WriteLine();
            }


        }
        static void inverterNumero ()
        {
            int numero, i;
            string numeroConvertido;
            Console.Write("Digite um número para que ele seja invertido: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("O número invertido é: ");
            numeroConvertido = numero.ToString();
            for (i = numeroConvertido.Length - 1; i >= 0; i--)
            {
                Console.Write(numeroConvertido[i]);
            }
        }
    }
}
