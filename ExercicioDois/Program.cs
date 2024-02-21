using System;

class Program
{
    static void Main(string[] args)
    {
        
        double taxaCambio = 5.22;

        Console.Write("Digite o valor em USD: ");
        double valorUSD = Convert.ToDouble(Console.ReadLine());

        double valorBRL = valorUSD * taxaCambio;

        Console.WriteLine($"{valorUSD} USD equivalem a {valorBRL} BRL.");

        Console.ReadLine();
    }
}