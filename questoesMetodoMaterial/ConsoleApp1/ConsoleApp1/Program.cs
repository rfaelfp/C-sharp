using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroQuestao;
            Console.Write("Digite a questão requerida: ");
            numeroQuestao = Convert.ToInt32(Console.ReadLine());

            if (numeroQuestao == 1)
            {
                int numeroEntrada;
                Console.Write("Digite um número: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());

                numeroParImpar(numeroEntrada);
                numerosImpares(numeroEntrada);
            }
            if (numeroQuestao == 2)
            {
                int primeiroNumero, segundoNumero;
                Console.Write("Digite o primeiro número: ");
                primeiroNumero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                segundoNumero = Convert.ToInt32(Console.ReadLine());

                maiorNumero(primeiroNumero, segundoNumero);
                numerosPares(primeiroNumero, segundoNumero);
            }
            if (numeroQuestao == 3)
            {
                int[] meuVetorEntrada = new int[10];
                Console.WriteLine("Questão do vetor");
                getVetor(meuVetorEntrada);
                printVetor(meuVetorEntrada);
                printVetorInverso(meuVetorEntrada);
                printVetorMeioInicio(meuVetorEntrada);
                printVetorMeioFim(meuVetorEntrada);
            }
        }
        static void numeroParImpar(int numeroSaida)
        {
            if (numeroSaida % 2 == 0)
            {
                Console.WriteLine($"O número {numeroSaida} é par!");
            }
            else
            {
                Console.WriteLine($"O número {numeroSaida} é impar!");
            }
        }
        static void numerosImpares (int numeroSaida)
        {
            for (int i = 0; i <= numeroSaida; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + ", ");
                }
            }
        }
        static void maiorNumero (int primeiroNumeroSaida, int segundoNumeroSaida)
        {
            if (primeiroNumeroSaida > segundoNumeroSaida)
            {
                Console.WriteLine($"O {primeiroNumeroSaida} é o maior número digitado");
            } 
            else
            {
                Console.WriteLine($"O {segundoNumeroSaida} é o maior número digitado");
            }
        }
        static void numerosPares(int primeiroNumeroSaida, int segundoNumeroSaida)
        {
            Console.Write("Os números pares no intervalo são: ");
            if (primeiroNumeroSaida > segundoNumeroSaida)
            {
                for (int i = segundoNumeroSaida; i <= primeiroNumeroSaida; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + ", ");
                    }
                }
            }
            else
            {
                for (int i = primeiroNumeroSaida; i <= segundoNumeroSaida; i++)
                {
                    if (i % 2 == 0) 
                    { 
                    Console.Write(i + ", ");
                    }
                }
            }
        }
        static void getVetor (int[] meuArray)
        {
            int[] meuVetor = new int[10];
            int i;
            for (i = 0; i < meuVetor.Length; i++)
            {
                Console.Write("Digite os valores para serem inserido no vetor: ");
                meuVetor[i] = Convert.ToInt32(Console.ReadLine());
                meuArray[i] = meuVetor[i];
            }
        }
        static void printVetor(int[] meuArray)
        {
            Console.Write("O vetor informado é: ");
            foreach (int elemento in meuArray)
            {
            Console.Write(elemento + ", ");
            }
        }
        static void printVetorInverso(int[] meuArray)
        {
            Console.WriteLine();
            Console.Write("O vetor de trás para frente é: ");
            for (int i = meuArray.Length - 1; i >= 0; i--)
            {

                Console.Write(meuArray[i] + ", ");
            }
        }
        static void printVetorMeioInicio(int[] meuArray)
        {
            Console.WriteLine();
            Console.Write("O vetor do meio para o início é: ");
            for (int i = (meuArray.Length / 2) - 1; i >= 0; i--)
            {
                Console.Write(meuArray[i] + ", ");
            }
        }
        static void printVetorMeioFim(int[] meuArray)
        {
            Console.WriteLine();
            Console.Write("O vetor do meio para o fim é: ");
            for (int i = (meuArray.Length / 2) - 1; i < meuArray.Length - 1; i++)
            {
                Console.Write(meuArray[i] + ", ");
            }
        }
    }
}
