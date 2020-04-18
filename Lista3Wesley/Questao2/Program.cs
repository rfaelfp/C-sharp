using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite1, limite2, i, total = 0;
            Console.Write("Digite o limite mais baixo: ");
            limite1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o limite mais alto: ");
            limite2 = Convert.ToInt32(Console.ReadLine());

            for (i = limite1; i <= limite2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine(total);
        }
    }
}
