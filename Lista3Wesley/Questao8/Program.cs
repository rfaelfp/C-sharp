using System;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
                int quantidade;
                Console.Write("Digite a quantidade de pessoas que deseja incluir:");
                quantidade = Convert.ToInt32(Console.ReadLine());
                int[] sexo = new int[quantidade];
                double[] altura = new double[quantidade];
                int i, contadorMulheres = 0, contadorHomens = 0;
                double maiorAltura = 0, menorAltura = double.MaxValue, alturaTotalMulheres = 0, AlturaTotalHomens = 0, mediaAlturaMulheres, mediaAlturaHomens;

                for (i = 0; i < sexo.Length; i++)
                {
                    Console.Write("Digite o sexo (0 = feminino, 1 = masculino): ");
                    sexo[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite a altura: ");
                    altura[i] = Convert.ToDouble(Console.ReadLine());
                    if (altura[i] > maiorAltura)
                    {
                        maiorAltura = altura[i];
                    }
                    if (altura[i] < menorAltura)
                    {
                        menorAltura = altura[i];
                    }
                    if (sexo[i] == 0)
                    {
                        alturaTotalMulheres += altura[i];
                        contadorMulheres++;
                    }
                    else
                    {
                        AlturaTotalHomens += altura[i];
                        contadorHomens++;
                    }

                }
                mediaAlturaMulheres = alturaTotalMulheres / contadorMulheres;
                mediaAlturaHomens = AlturaTotalHomens / contadorHomens;
                Console.WriteLine($"A menor altura é {menorAltura}");
                Console.WriteLine($"A maior altura é {maiorAltura}");
                Console.WriteLine($"A média de altura das mulheres é {mediaAlturaMulheres}");
                Console.WriteLine($"A média de altura dos homens é {mediaAlturaHomens}");
                Console.WriteLine($"A média da pupulação é {(alturaTotalMulheres + AlturaTotalHomens) / quantidade}");
                Console.WriteLine($"O percentual de mulheres na população é {(contadorMulheres * 100) / quantidade}%");
                Console.Write($"A percentual de homens da população é {(contadorHomens * 100) / quantidade }%");
        }
    }
}
