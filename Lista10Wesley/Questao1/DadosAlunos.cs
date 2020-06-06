using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1
{
    class DadosAlunos
    {
        private string nome, matricula;
        int curso;

        public DadosAlunos (string Nome, string Matricula, int Curso)
        {
            nome = Nome;
            matricula = Matricula;
            curso = Curso;
        }
        public void ler ()
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Matricula: ");
            matricula = Console.ReadLine();
            Console.Write("Curso: ");
            curso = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
        public void print ()
        {
            Console.WriteLine(nome);
            Console.WriteLine(matricula);
            Console.WriteLine((Curso) curso);
        }


        
    }
}
