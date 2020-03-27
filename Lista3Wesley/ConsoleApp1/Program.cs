using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int questaoNumero;
            Console.WriteLine("Escolha a questão: ");
            questaoNumero = Convert.ToInt32(Console.ReadLine());
            if (questaoNumero == 1)
            {
                int n, i, resultado;
                Console.WriteLine("Digite o valor limite da tabuada: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < n; i++)
                {
                    resultado = i * n;
                    Console.WriteLine($"{i} x {n} = {resultado}");
                }
            }
            if (questaoNumero == 2) { 
            int limite1, limite2, i, total = 0;
            Console.Write("Digite o limite mais baixo: ");
            limite1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o limite mais alto: ");
            limite2 = Convert.ToInt32(Console.ReadLine());

            for (i = limite1; i <= limite2; i++)
            {
                if (i % 2 == 0)
                {
                    total++;
                }
            }
            Console.WriteLine(total);
            }
            if (questaoNumero == 3)
            {
                int numeros = 0, contador = 0, i, resultado;

                for (i = 1; i > 0; i++) { 
                Console.WriteLine("Digite os números: ");
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i % 2 == 1)
                    {
                        numeros += i;
                        contador++;
                    }
                }
                resultado = numeros / contador;
                Console.WriteLine(resultado);

            }
            if (questaoNumero == 4)
            {
                int i, contador = 0,  resultado;
                Console.WriteLine("Aperte qualquer tecla para encontrar o quinto número maior que 1000 cuja a divisão por 11 tenha resto 5");
                for (i = 1000; i > 1; i++)
                {
                    if (i % 11 == 5)
                    {
                        contador++;
                        if (contador == 5)
                        {
                            Console.WriteLine($"Resultado {i}");
                            i = 0;
                        }
                    }
                }
            }
            if (questaoNumero == 5)
            {
                int[] numeros = new int[5];
                int i, soma = 0, maiorNumero = 0, menorNumero = Int32.MaxValue;
                for (i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Digite 5 números: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                    soma += numeros[i];
                    if (numeros[i] > maiorNumero)
                    {
                        maiorNumero = numeros[i];
                    }
                    if (numeros[i] < menorNumero)
                    {
                        menorNumero = numeros[i];
                    }
                }
                Console.WriteLine($"O maior número é {maiorNumero}");
                Console.WriteLine($"O menor número é {menorNumero}");
                soma /= numeros.Length;
                Console.WriteLine($"A soma aritimética é {soma}");

            }
            if (questaoNumero == 6)
            {
                int numero, i, valorConsole;
                Console.Write("Digite o número que o fatorial será iniciado: ");
                numero = Convert.ToInt32(Console.ReadLine());
                valorConsole = numero;
                if (numero < 0)
                {
                    Console.Write("O número é inválido");
                }
                else if (numero == 0)
                {
                    Console.Write("O fatorial de 0 é 1");
                }
                else { 
                for(i = (numero - 1); i > 1; --i)
                {
                    numero *=  (i);

                }
                Console.Write($"!{valorConsole} = {numero}");
                }
            }
            if (questaoNumero == 7)
            {
                int numeroEntrada, i, resultado3 = 0, total3 = 0;
                int[] multiplos = { 3, 5 };
                
                Console.Write("Escreva o número da entrada: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());
                //int[] multiplos3 = new int[numeroEntrada / 3 + 1];

                for (i = 1; i < numeroEntrada; i+=3)
                {
                    if (numeroEntrada > resultado3)
                    {
                        resultado3 += 3;
                        total3 += resultado3;
                        Console.Write($"{resultado3}, ");
                        //multiplos3[i] += resultado3;
                        //i += 1;
                    }
                }
                Console.WriteLine($"Total da linha: {total3}");
                //Console.WriteLine("[{0}]", string.Join(", ", multiplos3));
            }
        }
    }
}
