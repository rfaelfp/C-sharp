using System;

namespace Questao1
{
    enum Curso { Curso1, Curso2, Curso3, Curso4, NaoHáCurso = -1 };
    enum Materia { Materia1, Materia2, Materia3, Materia4 }
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            bool ver = false;
            DadosAlunos[] aluno = new DadosAlunos[qtdAlunos()];
            Cadastro cad = new Cadastro(aluno);
            cad.IniciarVet(aluno);
            do
            {
                op = menu();
            if (op >= 0 && op <= 3)
                {
                    if (op == 0)
                        cad.cadastro();
                    else if (op == 1)
                        cad.print();
                }
                    if (op == 4)
                        listar(op);
                    else if (op == 5)
                        listar(op);
                    else if (op == 6)
                {
                        ver = true;
                        Environment.Exit(0);
                }

            }
            while (ver == false);

            static int qtdAlunos()
            {
                int qtd;
                Console.Write("Digite a quantidade de alunos: ");
                qtd = Convert.ToInt32(Console.ReadLine());
                return qtd;
            }

        }
        static void listar(int op)
        {
            if (op == 4)
                foreach (var e in Enum.GetValues(typeof(Curso)))
                {
                    Console.WriteLine(e);
                }
            if (op == 5)
            {
                foreach (var e in Enum.GetValues(typeof(Materia)))
                {
                    Console.WriteLine(e);
                }
            }
        }
        static int menu()
        {
            int opList = 0, opNum;
            Console.WriteLine("Sistema de cadastro de alunos.");
            string[] op = { "Cadastrar aluno", "Imprimir alunos", "Imprimir lista de aprovados", "lista de reprovados", "Imprimir cursos", "Imprimir matérias", "Sair" };
            for (int i = 0; i < op.Length; i++)
            {
                Console.WriteLine($"[{opList}] - {op[i]}");
                opList++;
            }
            Console.Write("\nDigite a opção desejada: ");
            opNum = Convert.ToInt32(Console.ReadLine());

            return opNum;
        }
    }
}
