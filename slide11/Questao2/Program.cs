using System;

namespace Questao2
{
    class Program
    {
        struct DadosVeiculo
        {
            public string chassi, marca, modelo, cor, vendido;
            public int ano;

            public DadosVeiculo (string chassi, string marca, string modelo, string cor, int ano, string vendido)
            {
                this.chassi = chassi;
                this.marca = marca;
                this.modelo = modelo;
                this.cor = cor;
                this.ano = ano;
                this.vendido = vendido;
            }

            public void ler (int controle, string tipo)
            {
                Console.WriteLine($"Registro de {tipo}.");
                Console.Write($"{controle}º veículo - chassi: ");
                chassi = Console.ReadLine();
                Console.Write($"{controle}º veículo - marca: ");
                marca = Console.ReadLine();
                Console.Write($"{controle}º veículo - modelo: ");
                modelo = Console.ReadLine();
                Console.Write($"{controle}º veículo - cor: ");
                cor = Console.ReadLine();
                Console.Write($"{controle}º veículo - ano: ");
                ano = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            public void print (string tipo)
            {
                Console.WriteLine(tipo.ToUpper() + ":");
                Console.Write($"Chassi: {chassi}\t");
                Console.WriteLine($"Marca: {marca}");
                Console.Write($"Modelo: {modelo}\t");
                Console.WriteLine($"Cor: {cor}");
                Console.Write($"Ano: {ano}\n\n");
            }
            public bool verificaVenda()
            {
                bool ver = false;
                return ver; 
            }
        }

        static void Main(string[] args)
        {
            string c = "carro", m = "moto";
            DadosVeiculo[] dadosCarros = new DadosVeiculo[tamVet(c)];
            DadosVeiculo[] dadosMotos = new DadosVeiculo[tamVet(m)];
            Cadastro cadCarros = new Cadastro(dadosCarros);
            Cadastro cadMotos = new Cadastro(dadosMotos);
            cadCarros.registrar(c);
            cadMotos.registrar(m);
            cadCarros.printVeiculo(c);
            cadMotos.printVeiculo(m);
        }
        static int tamVet (string tipo)
        {
            int tam = 0;
            Console.Write($"Digite a quantidade de {tipo}: ");
            tam = Convert.ToInt32(Console.ReadLine());
            return tam;
        }
        struct Cadastro
        {
            DadosVeiculo[] dadosVeiculos;

            public Cadastro(DadosVeiculo[] dadosVeiculos)
            {
                this.dadosVeiculos = dadosVeiculos;
            }
            public void registrar (string tipo)
            {
                int controle = 1;
                for (int i = 0; i < dadosVeiculos.Length; i++)
                {
                    dadosVeiculos[i].ler(controle, tipo);
                    controle++;
                }
            }
            public void printVeiculo (string tipo)
            {
                for (int i = 0; i < dadosVeiculos.Length; i++)
                    dadosVeiculos[i].print(tipo);
            }
        }

    }
}
