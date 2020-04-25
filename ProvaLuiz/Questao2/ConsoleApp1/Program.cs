using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int n;
            string[] diasSemana = { "", "domingo", "segunda", "terça", "quarta", "quinta", "sexta", "sábado" };
            Console.Write("Digite um número de 1 a 7 para sabre o dia da semana: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 || n > 7)
            {
                Console.WriteLine("Não existe dia de semana com esse número!");
            }
            else
            {
                ;
                Console.WriteLine($"O dia da semana digitado é {diasSemana[n]}!");
            }
        }
    }
}