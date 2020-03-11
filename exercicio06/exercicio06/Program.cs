using System;

namespace exercicio06
{
    class Program
    {
        static void Main()
        {
            double baseTriangulo, alturaTriangulo, resultado;

            Console.WriteLine("Programa área do triângulo.");

            Console.Write("Valor base do triângulo: ");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor altura triângulo: ");
            alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            resultado = (baseTriangulo * alturaTriangulo) / 2;
            Console.WriteLine($"Área do triângulo: {resultado}");

        }
    }
}
