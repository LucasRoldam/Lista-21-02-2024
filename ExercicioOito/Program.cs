using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        
        Console.Write("Digite sua data de nascimento (no formato dd/mm/aaaa): ");
        DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

       
        int idade = CalcularIdade(dataNascimento);

        
        string faixaEtaria = DeterminarFaixaEtaria(idade);

       
        Console.WriteLine($"Olá, {nome}! Com {idade} anos, você está na faixa etária de {faixaEtaria}.");

        Console.ReadLine(); 
    }

    static int CalcularIdade(DateTime dataNascimento)
    {
        DateTime dataAtual = DateTime.Today;
        int idade = dataAtual.Year - dataNascimento.Year;
        if (dataNascimento.Date > dataAtual.AddYears(-idade))
        {
            idade--;
        }
        return idade;
    }

 
    static string DeterminarFaixaEtaria(int idade)
    {
        if (idade >= 0 && idade <= 19)
        {
            return "Jovem";
        }
        else if (idade >= 20 && idade <= 59)
        {
            return "Adulto";
        }
        else
        {
            return "Idoso";
        }
    }
}
