using System;

namespace Questao1
{
    enum Curso { Curso1 = 1, Curso2, Curso3, Curso4 };
    enum Materia { Materia1 = 1, Materia2, Materia3, Materia4 }
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            DadosAlunos[] aluno = new DadosAlunos[qtdAlunos()];
            Cadastro cad = new Cadastro(aluno);
            cad.IniciarVet(aluno);
            do
            {
                op = menu();

                switch (op)
                {
                    case 0:
                        Console.Clear();
                        cad.cadastro();
                        break;
                    case 1:
                        cad.print();
                        break;
                    case 2:
                        cad.nota();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            } while (op != 6);

            static int qtdAlunos()
            {
                int qtd;
                Console.Write("Digite a quantidade de alunos: ");
                qtd = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                return qtd;
            }

            static int menu()
            {
                int opList = 0, opNum;
                Console.WriteLine("Sistema de cadastro de alunos.");
                string[] op = { "Cadastrar aluno", "Imprimir alunos", "Atribuir nota", "Imprimir lista de aprovados", "lista de reprovados", "Sair" };
                for (int i = 0; i < op.Length; i++)
                {
                    Console.WriteLine($"[{opList}] - {op[i]}");
                    opList++;
                }
                Console.Write("\nDigite a opção desejada: ");
                opNum = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                return opNum;
            }
        }
    }
}
