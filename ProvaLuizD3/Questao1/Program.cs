using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ver = false;
            int[,] matriz = new int[5, 5];
            AtribuirValorMatriz(matriz);
            do
            {
                int op = Menu();
                switch (op)
                {
                    case 0:
                        ver = true;
                        break;
                    case 1:
                        InverterLinha(matriz);
                        break;
                    case 2:
                        InverterColuna(matriz);
                        break;
                    case 3:
                        MediaMatriz(matriz);
                        break;
                    case 4:
                        MultiplicarMaiorElemento(matriz);
                        break;
                    case 5:
                        DividirMenorElemento(matriz);
                        break;
                    default:
                        Console.WriteLine("\nEntrada inválida\n");
                        Menu();
                        break;
                }
            } while (ver == false);
        }
        static void AtribuirValorMatriz(int[,] matriz)
        {
            Console.WriteLine("Aperte ENTER para gerar a matriz...");
            Console.ReadLine();
            Random aleatorio = new Random();
            Console.Write("Matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 101);
                    Console.Write($"{matriz[i, j]}\t");
                }
            }
            Console.WriteLine("\n");

        }
        static void PrintMatriz(int[,] matriz)
        {
            Console.Write("Matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matriz.GetLength(0); j++)
                    Console.Write($"{matriz[i, j]}\t");
            }
            Console.WriteLine("\n");
        }
        static int Menu()
        {
            int op;
            string[] menu = { "Finalizar", "Inverter linha 0 (zero) com a linha 4 (quatro)", "inverter coluna 0 (zero) com a coluna 4 (quatro)", "Média dos elementos da matriz", "Multiplicar matriz pelo seu maior elemeno", "Dividir a matriz pelo seu menor elemento" };
            for (int i = 0; i < menu.Length; i++)
                Console.WriteLine($"[{i}] - {menu[i]}");
            Console.Write("\nEscolha a opção: ");
            op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void InverterLinha(int[,] matriz)
        {
            int temp;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                temp = matriz[0, i];
                matriz[0, i] = matriz[4, i];
                matriz[4, i] = temp;
            }
            PrintMatriz(matriz);
        }
        static void InverterColuna(int[,] matriz)
        {
            int temp;
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                temp = matriz[j, 0];
                matriz[j, 0] = matriz[j, 4];
                matriz[j, 4] = temp;
            }
            PrintMatriz(matriz);
        }
        static void MediaMatriz(int[,] matriz)
        {
            double total = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(0); j++)
                    total += matriz[i, j];
            total /= matriz.Length;
            Console.WriteLine($"A média dos elementos da matriz é {Math.Round(total, 2)}");
        }
        static void MultiplicarMaiorElemento(int[,] matriz)
        {
            int maiorElemento = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(0); j++)
                    if (maiorElemento < matriz[i, j])
                        maiorElemento = matriz[i, j];
            Console.WriteLine("Maior elemento: " + maiorElemento);
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(0); j++)
                    matriz[i, j] *= maiorElemento;
            PrintMatriz(matriz);
        }
        static void DividirMenorElemento(int[,] matriz)
        {
            int menorElemento = int.MaxValue;
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(0); j++)
                    if (menorElemento > matriz[i, j])
                        menorElemento = matriz[i, j];
            Console.WriteLine("Menor elemento:" + menorElemento);
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(0); j++)
                    matriz[i, j] /= menorElemento;
            PrintMatriz(matriz);
        }
    }
}
