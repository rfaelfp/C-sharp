using System;
class Programa
{
    static void Main()
    {
        int x = 15, y = 23;
        string frase = "Fundamentos de Programação .. Indicador de Desempenho 01";
        string resp = metodo(frase, x, y);
        Console.WriteLine(resp);
    }
    static string metodo(string frase, int a, int b)
    {
        string result = "";
        for (int i = a++; i < --b; i++)
            result += frase[i];
        return result;
    }
}
