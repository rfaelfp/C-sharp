using System;

namespace Questao13
{
    class Program
    {
        static void Main(string[] args)
        {
                double limite, c, f;

                Console.WriteLine("Digite o valor em fahrenheit de 50 a 70: ");
                limite = Convert.ToDouble(Console.ReadLine());

                for (f = 0; f <= limite; f++)
                {

                    Console.Write("fahrenheit" + f);

                    c = (f - 32) / 1.8;


                    Console.WriteLine(" \t celsius " + c.ToString("F2"));
                }
        }
    }
}
