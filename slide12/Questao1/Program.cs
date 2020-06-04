using System;
class Program
{

    struct Cadastro
    {
        public string[] cursos;
        public int qtd;


        public Cadastro(string[] curso, int qtd)
        {
            this.cursos = curso;
            this.qtd = qtd;
        }

        public void cadastrar ()
        {
            for (int i = 0; i <this.cursos.Length; i++)
            {
            Console.Write("Digite o nome do aluno: ");
            this.cursos[i] = Console.ReadLine();
            }
        }
    }
    static void Main(string[] args)
    {
        Cadastro[] cadCurso = new Cadastro[3];
        cadCurso.cadastrar();
    }

}
