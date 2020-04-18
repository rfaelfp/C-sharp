using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseT, alturaT, result;
            Console.Write("Digite a base do triângulo: ");
            baseT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura do triângulo: ");
            alturaT = Convert.ToDouble(Console.ReadLine());

            result = (baseT * alturaT) / 2;

            Console.WriteLine("A área do triângulo é " + result);
        }
    }
}
