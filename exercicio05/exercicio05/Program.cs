using System;

namespace exercicio05
{
    class Program
    {
        static void Main()
        {
            double salarioBase, gratificacao, imposto, salarioReceber;    

            Console.WriteLine("Programa salário + gratificação - imposto");

            Console.Write("Digite o salário base do funcionário: ");
            salarioBase = Convert.ToDouble(Console.ReadLine());

            gratificacao = (salarioBase / 100) * 5;
            imposto = (salarioBase / 100) * 7;
            salarioReceber = salarioBase + gratificacao - imposto;

            Console.WriteLine($"Resultado final: {salarioReceber.ToString("F2")}");
        }
    }
}
