using System;
        enum curso = {Curso1, Curso2, Curso3, Curso4};

class Program
{
    
    struct AlunosDados
    {
        public string nome, matricula;

        public AlunosDados (string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }
        public void registroAluno ()
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            matricula = Console.ReadLine();
            Console.Clear();
        }
        public void printAluno ()
        {
            Console.WriteLine("Aluno: " + nome);
            Console.WriteLine("Matrícula: " + matricula);
        }
    }
    struct Curso
    {
        public int escolhaCurso;

        public Curso (int escolhaCurso)
        {
            this.escolhaCurso = escolhaCurso;
        }

    }
    static void Main(string[] args)
    {
        int op = menu();
        if (op == 0)
            registrarAluno();
    }
    struct CadastroAlunos
    {
        AlunosDados[] alunos;

        public CadastroAlunos(AlunosDados[] alunos)
        {
            this.alunos = alunos;
        }
    }
    static int menu ()
    {
        string[] vetOp = { "Registrar aluno", "Atribuir curso", "Imprimir Cadastro", "Imprimir disciplinas aprovados", "Imprimir disciplinas reprovados" };
        int op = 0, opEscolha;
        for (int i = 0; i < vetOp.Length; i++)
        {
            Console.WriteLine($"[{op}] {vetOp[i]}");
            op++;
        }
        Console.Write("Digite a opção: ");
        opEscolha = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        return opEscolha;
    }
    public void registrarAluno ()
    {
        int tam;
        Console.Write("Quantidade de alunos: ");
        tam = Convert.ToInt32(Console.ReadLine());
        AlunosDados[] alunos = new AlunosDados[tam];
        CadastroAlunos cadAlunos = new CadastroAlunos(alunos);

        for (int i = 0; i < alunos.Length; i++)
            alunos[i].registroAluno();
    }
    
    static void print()
    {
        for (int i = 0; i < )
    }
}
