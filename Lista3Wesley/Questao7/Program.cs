using System;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, Base, soma = 0;

            Console.WriteLine("digite o valor limite: ");
            Base = Convert.ToInt32(Console.ReadLine());

            for (i = 3; i <= Base; i += 3)
            {
                Console.Write(i + ", ");
                soma += i;
            }
            Console.WriteLine("a soma é:" + soma);

            soma = 0;
            for (i = 5; i <= Base; i += 5)
            {
                Console.Write(i + ", ");
                soma += i;
            }
            Console.WriteLine("A soma das linhas é: " + soma);

            soma = 0;
            int exp = 1;

            for (i = 0; i <= Base; exp++)
            {
                soma += i;
                i = Convert.ToInt32(Math.Pow(2, exp));
                if (i < Base)
                    Console.Write(i + ", ");
            }
            Console.WriteLine("A soma das linhas é: " + soma);

            soma = 0;
            int b = 1;
            for (i = 0; i <= Base; b++)
            {
                soma += i;
                i = Convert.ToInt32(Math.Pow(b, 3));
                if (i < Base)
                    Console.Write(i + ", ");
            }
            Console.WriteLine("A soma das linhas é: " + soma);
        }
    }
}
