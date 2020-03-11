using System;

namespace exercicio04
{
    class Program
    {
        static void Main()
        {
            float salario, percentualAumento, resultado;
            Console.WriteLine("Programa salário mais aumento");

            Console.Write("Digite o montante do salário: ");
            salario = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o percentual do aumento: ");
            percentualAumento = Convert.ToInt32(Console.ReadLine());

            resultado = (salario / 100) * percentualAumento + salario;
            Console.WriteLine($"Salário total {resultado.ToString("F2")}");

        }
    }
}
