using System;
using System.Collections.Generic;
using System.Text;

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
        public void cadastro ()
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i].ler();
            }
        }
        public void print ()
        {
            for (int i = 0; i < alunos.Length; i++)
                alunos[i].print();
            Console.WriteLine("Aperte enter para voltar ao menu...");
            Console.ReadLine();
            Console.Clear();
        }
        public void nota ()
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i].cabecalho();
                Console.ResetColor();
                alunos[i].AtribuirNota();
            }
        }
    }
}
