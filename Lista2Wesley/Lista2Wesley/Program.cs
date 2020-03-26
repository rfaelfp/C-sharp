using System;

namespace Lista2Wesley
{
    class Program
    {
        static void Main(string[] args)
        {
            int exercicioNumero;
            Console.Write("Escolha o exercício: ");
            exercicioNumero = Convert.ToInt32(Console.ReadLine());
            if (exercicioNumero == 1)
            {
				int[] meuArray = new int[3];
				int maior = 0, menor = Int32.MaxValue, i, mediaAritimetica;
				for (i = 0; i < 3; i++)
				{
					Console.Write("Digite o número: ");
					meuArray[i] = Convert.ToInt32(Console.ReadLine());
				}
				for (i = 0; i < 3; i++)
				{
					if (meuArray[i] > maior)
					{
						maior = meuArray[i];
					}
				}
				for (i = 0; i < 3; i++)
				{
					if (meuArray[i] < menor)
					{
						menor = meuArray[i];
					}
				}
				mediaAritimetica = (meuArray[0] + meuArray[1] + meuArray[2]) / 3;
				Console.WriteLine($"O maior número digitado é {maior}");
				Console.WriteLine($"O menor número digitado é {menor}");
				Console.Write($"A média aritimética é {mediaAritimetica}");
			}
			if (exercicioNumero == 2)
			{
				int valorCompra, valorPago, resto, i;
				int[] valoresDinheiro = new int[6] { 0, 0, 0, 0, 0, 0 }; // cada indexador refere-se ao valor de uma nota.
				Console.Write("Digite o valor da compra: ");
				valorCompra = Convert.ToInt32(Console.ReadLine());
				Console.Write("Digite o valor da pago: ");
				valorPago = Convert.ToInt32(Console.ReadLine());
				resto = valorPago - valorCompra;
				if (valorPago < valorCompra)
				{
					Console.WriteLine("O valor da compra é maior que o valor pago!");
				}
				else
				{
					for (i = resto; i > 0 ; i++)
					{
						if (resto > 50)
						{
							resto -= 50;
							i -= 51;
							valoresDinheiro.SetValue(valoresDinheiro[0] + 1, 0);
						}
						else if (resto <= 50 && resto >= 20)
						{
							resto -= 20;
							i -= 21;
							valoresDinheiro.SetValue(valoresDinheiro[1] +1, 1);
						}
						else if (resto < 20 && resto >= 10)
						{
							resto -= 10;
							i -= 11;
							valoresDinheiro.SetValue(valoresDinheiro[2] + 1, 2);
						}
						else if (resto < 10 && resto >= 5)
						{
							resto -= 5;
							i -= 6;
							valoresDinheiro.SetValue(valoresDinheiro[3] + 1, 3);
						}
						else if (resto < 5 && resto >= 2)
						{
							resto -= 2;
							i -= 3;
							valoresDinheiro.SetValue(valoresDinheiro[4] + 1, 4);
						}
						else
						{
							resto -= 1;
							i -= 2;
							valoresDinheiro.SetValue(valoresDinheiro[5] + 1, 5);
						}
					}
					Console.WriteLine($"Notas de R$ 50,00: {valoresDinheiro[0]}");
					Console.WriteLine($"Notas de R$ 20,00: {valoresDinheiro[1]}");
					Console.WriteLine($"Notas de R$ 10,00: {valoresDinheiro[2]}");
					Console.WriteLine($"Notas de R$ 5,00: {valoresDinheiro[3]}");
					Console.WriteLine($"Notas de R$ 2,00: {valoresDinheiro[4]}");
					Console.WriteLine($"Notas de R$ 1,00: {valoresDinheiro[5]}");
				}
			}
			if (exercicioNumero == 3)
			{
				double eixoX, eixoY, resultado;
				Console.Write("Informe a abscissa do ponto: ");
				eixoX = Convert.ToDouble(Console.ReadLine());
				Console.Write("Informe a ordenada do ponto: ");
				eixoY = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine($"P ({eixoX}, {eixoY})");
				if (eixoX > 0 && eixoY > 0)
				{
					Console.WriteLine("1º quadrante");
				}
				else if (eixoX < 0 && eixoY > 0)
				{
					Console.WriteLine("2º quadrante");
				}
				else if (eixoX < 0 && eixoY < 0)
				{
					Console.WriteLine("3º quadrante");
				}
				else 
				{
					Console.WriteLine("4º quadrante");
				}
			}
			if (exercicioNumero == 6)
			{
				char[] valoresDinheiro = new char[5] {'+', '-', '*', '/', '^'};
				int valorIndex;
				double num1, num2, resultado, operador;
				//char operador;
				Console.WriteLine("Digite o primeiro número: ");
				num1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Digite o primeiro número: ");
				num2 = Convert.ToDouble(Console.ReadLine());

				valorIndex = Convert.ToInt32(Console.ReadLine());
				operador = valoresDinheiro[valorIndex];

				resultado = num1, operador, num2;
				Console.WriteLine(resultado);


				

			}
        }
    }
}
