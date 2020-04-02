using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int questaoNumero;
            Console.Write("Escolha a questão: ");
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
            if (questaoNumero == 2)
            {
                int limite1, limite2, i, total = 0;
                Console.Write("Digite o limite mais baixo: ");
                limite1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o limite mais alto: ");
                limite2 = Convert.ToInt32(Console.ReadLine());

                for (i = limite1; i <= limite2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + ", ");
                    }
                }
                Console.WriteLine(total);
            }
            if (questaoNumero == 3)
            {
                int numeros = 0, contador = 0, i, resultado;

                for (i = 1; i > 0; i++)
                {
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
                int i, contador = 0;
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
                Console.WriteLine($"A média aritimética é {soma}");

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
                else
                {
                    for (i = (numero - 1); i > 1; --i)
                    {
                        numero *= (i);

                    }
                    Console.Write($"!{valorConsole} = {numero}");
                }
            }
            if (questaoNumero == 7)
            {
                int i, Base, soma = 0;

                Console.WriteLine("digite o valor limite: ");
                Base = Convert.ToInt32(Console.ReadLine());

                for (i = 3; i <= Base; i += 3)
                {

                    Console.Write(i + ", ");
                    soma += i;

                }
                Console.WriteLine("a soma é:" + soma);
                soma = 0;

                for (i = 5; i <= Base; i += 5)
                {
                    Console.Write(i + ", ");
                    soma += i;
                }
                Console.WriteLine("A soma das linhas é: " + soma);
                soma = 0;
                int exp = 1;

                for (i = 0; i <= Base; exp++)
                {
                    soma += i;
                    i = Convert.ToInt32(Math.Pow(2, exp));
                    if (i < Base)
                    {
                        Console.Write(i + ", ");
                    }
                }
                Console.WriteLine("A soma das linhas é: " + soma);
                soma = 0;
                int b = 1;


                for (i = 0; i <= Base; b++)
                {
                    soma += i;
                    i = Convert.ToInt32(Math.Pow(b, 3));
                    if (i < Base)
                    {
                        Console.Write(i + ", ");
                    }
                }
                Console.WriteLine("A soma das linhas é: " + soma);

            }
            if (questaoNumero == 8)
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
            if (questaoNumero == 9)
            {
                int numeroLimite, i, numero1 = 0, numero2 = 1, total = 0;
                Console.Write("Digite o número limite da sequencia Fibonacci: ");
                numeroLimite = Convert.ToInt32(Console.ReadLine());
                Console.Write("0, 1, ");
                for (i = 1; i <= numeroLimite; i = i)
                {
                    if (numero1 < numero2)
                    {
                        numero1 = i;
                    }
                    else
                    {
                        numero2 = i;
                    }
                    if (i <= numeroLimite)
                    {
                        Console.Write($"{i}, ");
                        total += i;
                        i = numero1 + numero2;
                    }
                }
                total += 1;
                Console.Write("O total é " + total);
            }
            if (questaoNumero == 10)
            {

            }
            if (questaoNumero == 11)
            {
                double chico = 1.5, juca = 1.1, i;
                int totalAnos = 0;
                for (i = juca; i < chico; i = juca)
                {
                    chico += 0.02;
                    juca += 0.03;
                    totalAnos++;
                }
                Console.Write($"Será necessário {totalAnos} anos para que Juca seja maior que Chico.");
            }
            if (questaoNumero == 12)
            {

                int numeroEntrada, i, contador = 0;
                
                Console.Write("Digite o número para saber se é primo: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= numeroEntrada; i++)
                {
                    if (numeroEntrada % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine($"O número {numeroEntrada} é primo!");
                }
                else
                {
                    Console.WriteLine($"O número {numeroEntrada} não é primo!");
                }

            }
            if (questaoNumero == 13)
            {
                double limite, c, f;

                Console.WriteLine("Digite o valor em fahrenheit de 50 a 70: ");
                limite = Convert.ToDouble(Console.ReadLine());

                for (f = 0; f <= limite; f++)
                {

                    Console.Write("fahrenheit" + f);

                    c = (f - 32) / 1.8;


                    Console.WriteLine(" \t celsius " + c.ToString("F2"));

                }
            }
            if (questaoNumero == 14)
            {
                int i, quantidadeCasaXadrez = 64;
                double quantidade = 1, total = 1;
                Console.WriteLine("Programa para calcular quantidade de grãos de trigo em um tabuleiro");
                for (i = 1; i <= quantidadeCasaXadrez; i++)
                {
                    quantidade *= 2;
                    total += quantidade;
                }
                Console.Write($"O monge receberá {total} grãos da rainha.");

            }
        }
    }
}