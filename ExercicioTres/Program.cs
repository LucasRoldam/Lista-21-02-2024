using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.Write("Informe a distância total em quilômetros percorrida: ");
        double distanciaPercorridaKM = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Informe o gasto de combustível em litros: ");
        double combustivelGastoLitros = Convert.ToDouble(Console.ReadLine());

      
        double mediaGasto = distanciaPercorridaKM / combustivelGastoLitros;

        Console.WriteLine($"A média de gasto do automóvel é de {mediaGasto} km/l.");

        Console.ReadLine(); 
    }
}