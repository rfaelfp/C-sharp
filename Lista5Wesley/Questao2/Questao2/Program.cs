using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verificacao = true;
            while (verificacao == true) 
            { 
            int num1 = 0, num2 = 0;
            int RetornuNumero1 = pegarNumero(num1);
            int RetornuNumero2 = pegarNumero(num2);
            if (RetornuNumero2 != 0)
                { 
                int result = calculoNumero(RetornuNumero1, RetornuNumero2);
                Console.WriteLine(result);
                }
            }
        }
        static int pegarNumero(int numero)
        {
            Console.Write("Infomer os números: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
        static int calculoNumero(int num1, int num2)
        {
            int piso = num1 / num2;
            Convert.ToInt32(piso);
            return num1 - (piso * num2);
        }
    }
}
