using System;

namespace exercicio07
{
    class Exercicio07
    {
        static void Main()
        {
            double numero, numeroQuadrado, numeroCubo, numeroRaizQuadrada, potencia, numeroRaizCubica;
            Console.WriteLine("Programa valores cubicos");

            Console.Write("Digite o número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero <= 0 )
            Console.Write("O número deve ser positivo.");
            else
            {
                numeroQuadrado = Math.Pow(numero, 2);
                numeroCubo = Math.Pow(numero, 3);
                numeroRaizQuadrada = Math.Sqrt(numero);
                potencia = 1.0 / 3.0;
                numeroRaizCubica = Math.Pow(numero, potencia);

                Console.WriteLine($"O valor do número ao quadro: {numeroQuadrado}");
                Console.WriteLine($"O valor do número ao cubo: {numeroCubo}");
                Console.WriteLine($"O valor da raiz quadrada: {numeroRaizQuadrada}");
                Console.WriteLine($"O valor da raiz cúbica: {numeroRaizCubica}");
            }

        }
    }
}
