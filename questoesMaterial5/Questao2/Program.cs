using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = int.MaxValue, result, contador = 0, soma = 0, continuar;
            bool controle = true;
            while (controle == true)
            {
            Console.Write("Digite um número: ");
            result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result);
            if (result > num1)
                num1 = result;
            if (result < num2)
                num2 = result;
            contador++;
                soma += result;
                Console.WriteLine("Gostaria de continuar? Aperte 0 para Não e 1 para Sim: ");
                continuar = Convert.ToInt32(Console.ReadLine());
                if (continuar == 0)
                    controle = false;
            }
            Console.WriteLine($"O maior número é {num1}");
            Console.WriteLine($"O menor número é {num2}");
            Console.WriteLine($"A média aritimética é {soma / contador}");


        }
    }
}
