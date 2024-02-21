using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        nome = nome.ToLower();

        int contadorVogais = 0;

        foreach (char c in nome)
        {
 
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                contadorVogais++;
            }
        }

        Console.WriteLine($"O nome {nome} possui {contadorVogais} vogais.");

        Console.ReadLine(); 
    }
}
