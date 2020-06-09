using System;

namespace Questao1
{
    class DadosAlunos
    {
        private string nome, matricula;
        private int curso;
        private int[] materia, nota;

        public DadosAlunos(string Nome, string Matricula, int Curso, int[] Materia, int[] Nota)
        {
            nome = Nome;
            matricula = Matricula;
            curso = Curso;
            materia = Materia;
            nota = Nota;
        }
        public void ler()
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Matricula: ");
            matricula = Console.ReadLine();
            listar(1);
            Console.Write("Código do curso: ");
            curso = Convert.ToInt32(Console.ReadLine());
            listar(2);
            lerMateria();
            Console.Clear();
        }
        public void print()
        {
            Console.WriteLine($"Aluno: {nome}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Matriculado no curso: {(Curso)curso}");
            Console.Write($"Matéria(s): ");
            printMateria();
        }
        public void lerMateria()
        {
            string teste;
            for (int i = 0; i < materia.Length; i++)
            {
                Console.Write("Código da matéria: ");
                materia[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gostaria de incluir mais matérias? (sim/não)");
                teste = Console.ReadLine().ToLower();
                if (teste != "sim" && teste != "s" && teste != "1")
                    break;

            }
        }
        public void cabecalho ()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Aluno: {nome} - matrícula: {matricula}");
        }
        public void printMateria()
        {

            for (int i = 0; i < materia.Length; i++)
                if (materia[i] != 0)
                Console.Write((Materia) materia[i] + ", ");
            Console.WriteLine("\n\n");
        }
        public void AtribuirNota()
        {
            for (int i = 0; i < nota.Length; i++)
            {
                if (materia[i] != 0)
                {
                    Console.Write($"{(Materia) materia[i]}: ");
                    nota[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }

            }
        }
        public void listar(int op)
        {
            int m = 1;
            if (op == 1)
                foreach (var e in Enum.GetValues(typeof(Curso)))
                {
                    Console.WriteLine($"[{m}]: {(Curso)e}");
                    m++;
                }
            if (op == 2)
            {
                foreach (var e in Enum.GetValues(typeof(Materia)))
                {
                    Console.WriteLine($"[{m}]: {(Materia)e}");
                    m++;
                }
            }

        }
    }
}
