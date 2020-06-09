using System;

namespace Questao1
{
    class Cadastro
    {
        private DadosAlunos[] alunos;

        public Cadastro(DadosAlunos[] Alunos)
        {
            alunos = Alunos;
        }
        public void IniciarVet(DadosAlunos[] aluno)
        {
            for (int i = 0; i < aluno.Length; i++)
                aluno[i] = new DadosAlunos("", "", 0, new int[4], new int[4]);
        }
        public void cadastro()
        {
            string teste;
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i].ler();
                Console.WriteLine("Gostaria de incluir mais alunos? (sim/não)");
                teste = Console.ReadLine().ToLower();
                Console.Clear();
                if (teste != "sim" && teste != "s" && teste != "1")
                    break;
            }
        }
        public void print()
        {
            for (int i = 0; i < alunos.Length; i++)
                alunos[i].print();
            compMenu();
        }
        public void nota()
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i].cabecalho();
                alunos[i].AtribuirNota();
                Console.Clear();
            }
            compMenu();
        }
        public void alunosAprovados()
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i].cabecalho();
                alunos[i].aprovados();
            }
            compMenu();
        }
        public void alunosReprovados()
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i].cabecalho();
                alunos[i].reprovados();
            }
            compMenu();

        }
        public void compMenu()
        {
            Console.WriteLine("\nAperte ENTER para voltar ao menu...\n\n");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
