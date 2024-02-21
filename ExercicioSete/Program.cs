using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        nome = nome.ToLower();

        int contadorConsoantes = 0;

        foreach (char c in nome)
        {
            if (c >= 'a' && c <= 'z' && c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
            {
                contadorConsoantes++;
            }
        }

        Console.WriteLine($"O nome {nome} possui {contadorConsoantes} consoantes.");

        Console.ReadLine(); 
    }
}
