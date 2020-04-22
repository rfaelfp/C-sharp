using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int numero = getNumero();
                Console.WriteLine(inverterNumero(numero));
            }


        }
        static string inverterNumero (int numero)
        {
            int i;
            string numeroConvertido, numeroResult = "";
            Console.Write("O número invertido é: ");
            numeroConvertido = numero.ToString();
            for (i = numeroConvertido.Length - 1; i >= 0; i--)
            {
                numeroResult += numeroConvertido[i];
            }
            return numeroResult;
        }
        static int getNumero()
        {
            int numero;
            Console.Write("Digite um número para que ele seja invertido: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
