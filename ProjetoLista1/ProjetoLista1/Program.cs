using System;

namespace ProjetoLista1
{
    class Program
    {
        static void Main()
        {
            int exercicioEscolha;
            Console.Write("Gentileza escolher entre o exercício 01 a 25: ");
            exercicioEscolha = Convert.ToInt32(Console.ReadLine());
            if (exercicioEscolha < 1 | exercicioEscolha > 25)
                Console.WriteLine("O número não é válido.");
            else if (exercicioEscolha == 1) { 
				int numero1, numero2, numero3, numero4, soma;

			Console.WriteLine("Programa que soma quatro números");

			Console.Write("Digite o primeiro número = ");
			numero1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(numero1);

			Console.Write("Digite o segundo número = ");
			numero2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(numero2);

			Console.Write("Digite o terceiro número = ");
			numero3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(numero3);

			Console.Write("Digite o quarto número = ");
			numero4 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(numero4);

			soma = numero1 + numero2 + numero3 + numero4;

			Console.WriteLine("Soma = " + soma);
			}
			else if (exercicioEscolha == 2)
			{
			float nota1, nota2, nota3, mediaAritimetica;

			Console.WriteLine("Programa de média aritimética");

			Console.Write("Digite a primeira nota ");
			nota1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Digite a segunda nota ");
			nota2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Digite a terceira nota ");
			nota3 = Convert.ToInt32(Console.ReadLine());

			mediaAritimetica = (nota1 + nota2 + nota3) / 3;
			Console.WriteLine($"A média aritimética é {mediaAritimetica.ToString("F2")}");
			}
			else if (exercicioEscolha == 10)
			{
			DateTime dataAtual = DateTime.Now;
			string ano = dataAtual.Year.ToString(), verificacao;
			int anoNascimento, anoFuturo, idadadeAtual, anoAtual = Convert.ToInt32(ano);

			Console.Write("Digite o ano de nascimento: ");
			anoNascimento = Convert.ToInt32(Console.ReadLine());
				verificacao = Convert.ToString(anoNascimento);
				if (verificacao.Length != 4 | anoNascimento > anoAtual)
					Console.WriteLine($"O ano {verificacao} não é um ano válido");
				else { 
				idadadeAtual = anoAtual - anoNascimento;
				Console.WriteLine($"Sua idade atual é: {idadadeAtual}");
				anoFuturo = 2050 - anoNascimento;
				Console.WriteLine($"No ano de 2050 você terá {anoFuturo} anos.");
				}
			}
			else if (exercicioEscolha == 11)
			{
			double precoFabrica, percentualLucro, percentualImposto, valorLucro, valorImposto, precoFinal;
			Console.WriteLine("Digite o valor de fábrica do carro: ");
			precoFabrica = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o percentual de lucro: ");
			percentualLucro = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o percentual do imposto: ");
			percentualImposto = Convert.ToDouble(Console.ReadLine());

			valorLucro = (precoFabrica / 100) * percentualLucro + precoFabrica;
			valorImposto = (precoFabrica / 100) * percentualImposto + precoFabrica;
			precoFinal = precoFabrica + (precoFabrica / 100) * percentualLucro + (precoFabrica / 100) * percentualImposto;

			Console.WriteLine(valorLucro);
			Console.WriteLine(valorImposto);
			Console.WriteLine(precoFinal.ToString("C2"));
			}
			}
		}
}
