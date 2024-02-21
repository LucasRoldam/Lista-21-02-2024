using System;

class Program
{
    static void Main(string[] args)
    {
        
        double taxaCambio = 0.193259;

        
        Console.Write("Digite o valor em BRL: ");
        double valorBRL = Convert.ToDouble(Console.ReadLine());

        
        double valorUSD = valorBRL * taxaCambio;

        
        Console.WriteLine($"{valorBRL} BRL equivalem a {valorUSD} USD.");

        Console.ReadLine();
    }
}