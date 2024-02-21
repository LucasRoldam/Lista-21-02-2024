using System;

class Program
{
    static void Main(string[] args)
    {
        
        int anoAtual = DateTime.Now.Year;

        Console.Write("Por favor, digite o ano de nascimento: ");
        int anoNascimento = Convert.ToInt32(Console.ReadLine());

        int idade = anoAtual - anoNascimento;

        Console.WriteLine($"Você tem {idade} anos de idade.");

        Console.ReadLine(); 
    }
}