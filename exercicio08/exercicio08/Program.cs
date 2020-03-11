using System;

namespace exercicio08
{
    class Exercicio08
    {
        static void Main()
        {
            double numeroBase, numeroElevado, resultado;

            Console.WriteLine("Programa cálculo base elevada");

            Console.Write("Digite o valor da base: ");
            numeroBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor a ser elevado: ");
            numeroElevado = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(numeroBase, numeroElevado);
            Console.WriteLine(resultado.ToString("F4"));

        }
    }
}
