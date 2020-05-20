using System;

class Program
{
    static void Main(string[] args)
    {
        string palavra = "";
        char letra = char.MinValue;
        lerPalavra(ref palavra);
        Console.WriteLine("Palavra: " + palavra);
        Console.WriteLine($"Ocorrências: {numeroOcorrencia(palavra, ref letra)}");
        posicoes(palavra, letra);

    }
    static void lerPalavra(ref string palavra)
    {
        Console.Write("Digite a palavra desejada:  ");
        palavra = Convert.ToString(Console.ReadLine());
    }
    static int numeroOcorrencia(string palavra, ref char letra)
    {
        int i, qtd = 0;
        Console.WriteLine("Digite a letra que deseja localizar: ");
        letra = Convert.ToChar(Console.ReadLine());
        for (i = 0; i < palavra.Length; i++)
            if (palavra[i] == letra)
                qtd++;
        return qtd;
    }
    static void posicoes (string palavra, char letra)
    {
        int i;
        Console.Write("Posições na palavra: ");
        for (i = 0; i < palavra.Length; i++)
            if (palavra[i] == letra)
            {
                Console.Write(i + ", ");
            }
    }
}
