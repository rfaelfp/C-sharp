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
			else if (exercicioEscolha == 12)
			{
				double alturaDegrau, alturaASerAlcancada, quantidadeDegraus;
				Console.Write("Digite a altura do degrau: ");
				alturaDegrau = Convert.ToDouble(Console.ReadLine());
				Console.Write("Digite a altura que deseja alcançar: ");
				alturaASerAlcancada = Convert.ToDouble(Console.ReadLine());

				quantidadeDegraus = alturaDegrau / alturaASerAlcancada;
				Console.WriteLine($"Será necessário subir {quantidadeDegraus} degraus.");
			}
			else if (exercicioEscolha == 13)
			{
				double anguloGrauEscada, alturaParede, radiano, hipotenusa, resultado;
				Console.Write("Indique o angulo em graus da escada: ");
				anguloGrauEscada = Convert.ToDouble(Console.ReadLine());
				Console.Write("Indique o altura da parede: ");
				alturaParede = Convert.ToDouble(Console.ReadLine());
				radiano = anguloGrauEscada * (Math.PI / 180);
				hipotenusa = Math.Cos(radiano);
				resultado = alturaParede / hipotenusa;
				Console.Write(resultado);
			}
			else if (exercicioEscolha == 14)
			{
				double numero, parteInteira, parteFracionada, arredondado;
				Console.WriteLine("Digite o número desejado: ");
				numero = Convert.ToDouble(Console.ReadLine());
				parteInteira = Math.Floor(numero);
				Console.Write(parteInteira);
			}//voltar nesse exercício
			else if (exercicioEscolha == 15)
			{
				int hora, minuto, guardaHora, resultado;
				Console.Write("Digite a hora: ");
				hora = Convert.ToInt32(Console.ReadLine());
				Console.Write("Digite os minutos: ");
				minuto = Convert.ToInt32(Console.ReadLine());
				guardaHora = hora * 60;
				resultado = guardaHora + minuto;
				Console.WriteLine(resultado);
			}
			else if (exercicioEscolha == 16)
			{
				double custoTeatroTotal, precoConvite, qtdConvites;
				Console.Write("Digite o custo do teatro: ");
				custoTeatroTotal = Convert.ToDouble(Console.ReadLine());
				Console.Write("Digite o preço do convite: ");
				precoConvite = Convert.ToDouble(Console.ReadLine());
				qtdConvites = custoTeatroTotal / precoConvite;
				qtdConvites = Math.Ceiling(qtdConvites);
				Console.WriteLine($"É necessário vender {qtdConvites} para pagar o custo do teatro.");
			}
			else if (exercicioEscolha == 17)

			{
				int i, numeroBase, resultado;
				Console.WriteLine("Programa tabuada");
				Console.Write("Digite o numero a ser multiplicado: ");
				numeroBase = Convert.ToInt32(Console.ReadLine());
				for (i = 1; i <= 10; i++)
				{
					resultado = i * numeroBase;
					Console.WriteLine($"{numeroBase} X {i} = {resultado}");
				}
			}
			else if (exercicioEscolha == 18)
			{
			DateTime dataAtual = DateTime.Now;
			string ano = dataAtual.Year.ToString();
			int anoAtualConvertido = Convert.ToInt32(ano), anoNascimento, anos;
				double meses, dias, semanas;
				Console.WriteLine("Digite o ano de nascimento: ");
				anoNascimento = Convert.ToInt32(Console.ReadLine());
				anos = anoAtualConvertido - anoNascimento;
				Console.WriteLine(anos + " anos");
				meses = 12 * anos;
				Console.WriteLine(meses + " meses");
				dias = anos * 365;
				Console.WriteLine(dias + " dias");
				semanas = anos * 52.1429;
				Console.WriteLine(semanas.ToString("F2") + " semanas");
			}
			else if (exercicioEscolha == 19)
			{
				double catetoX, catetoY, hipotenusa, resultado;
				Console.Write("Digite a altura do cateto: ");
				catetoX = Convert.ToDouble(Console.ReadLine());
				Console.Write("Digite a largura do cateto: ");
				catetoY = Convert.ToDouble(Console.ReadLine());
				resultado = Math.Pow(catetoX, 2) + Math.Pow(catetoY, 2);
				hipotenusa = Math.Sqrt(resultado);
				Console.WriteLine($"O valor da hipotenusa é {hipotenusa.ToString("F2")}");

			}
			else if (exercicioEscolha == 20)
			{
				    double raio, cumprimentoEsfera, areaEsfera, volumeEsfera;
				    Console.WriteLine("Digite o tamanho do raio: ");
				    raio = Convert.ToDouble(Console.ReadLine());

				    cumprimentoEsfera = 2 * (Math.PI) * raio;
				    areaEsfera = (Math.PI) * Math.Pow(raio, 2);
				    volumeEsfera = (4 * (Math.PI) * Math.Pow(raio, 3)) / 3;

				    Console.WriteLine($"O cumprimento da esfera é {cumprimentoEsfera}");
				    Console.WriteLine($"Á área da esfera é {areaEsfera}");
				    Console.WriteLine($"O volume da esfera é {volumeEsfera}");
			}// voltar porque não está dando para dividir 1/4
			else if (exercicioEscolha == 21)
			{
				double dimensaoA, dimensaoB, totalMetrosQuadrados, potenciaUtilizada;
				Console.WriteLine("Digite a primeira dimensão em m²: ");
				dimensaoA = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Digite a segunda dimensão em m²: ");
				dimensaoB = Convert.ToDouble(Console.ReadLine());

				totalMetrosQuadrados = dimensaoA * dimensaoB;
				potenciaUtilizada = totalMetrosQuadrados * 18;
				Console.WriteLine($"O espaço possui {totalMetrosQuadrados}m² sendo necessário utilizar {potenciaUtilizada} W para iluminar.");
			}
			}
		}
}
