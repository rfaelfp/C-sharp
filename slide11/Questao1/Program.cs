using System;

class Program
{
    struct DadosAlunos
    {
        public string matricula, nome;
        public double nota;

        public DadosAlunos (string matricula, string nome, int nota)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.nota = nota;
        }
        public void ler ()
        {
            Console.Write("Digite a matrícula: ");
            matricula = Console.ReadLine();
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a nota: ");
            nota = Convert.ToInt32(Console.ReadLine());
        }
        public void print ()
        {
            Console.WriteLine($"O(a) aluno(a) {nome} de matrícula {matricula} recebeu {nota} de nota.");
        }
        public bool verificaNota ()
        {
            bool verifica = false;
            if (nota >= 70)
                verifica = true;
            return verifica;

        }
    }
    static void Main(string[] args)
    {
        DadosAlunos[] alunos = new DadosAlunos[tamVet()];
        Cadastro meusAlunos = new Cadastro(alunos);
        meusAlunos.preencherVet();
        meusAlunos.printVet();
        meusAlunos.printAvaliacao();
    }
    struct Cadastro
    {
        DadosAlunos[] aluno;

        public Cadastro(DadosAlunos[] aluno)
        {
            this.aluno = aluno;
        }

        public void preencherVet ()
        {
            for (int i = 0; i < this.aluno.Length; i++)
            {
                aluno[i].ler();
            }
        }
        public void printVet ()
        {
            for (int i = 0; i < this.aluno.Length; i++)
            {
                aluno[i].print();
            }
        }
        public void printAvaliacao ()
        {
            for (int i = 0; i < this.aluno.Length; i++)
            {
                if(aluno[i].verificaNota() == true)
                {
                    Console.WriteLine($"O aluno(a) {aluno[i].nome} foi aprovado com {aluno[i].nota} pontos.");
                }                
            }
        }
    }
        static int tamVet ()
        {
            int tam = 0;
            Console.Write("Digite a quantidade de alunos que deseja incluir: ");
            tam = Convert.ToInt32(Console.ReadLine());
            return tam;

        }
}
