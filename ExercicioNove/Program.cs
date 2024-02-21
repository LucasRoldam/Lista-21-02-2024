using System;


struct Livro
{
    public string Titulo;
    public string Autor;
    public double Valor;

    public override string ToString()
    {
        return $"Título: {Titulo}\nAutor: {Autor}\nValor: {Valor:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {

        Livro livro;
        Console.WriteLine("Cadastro de Livro");
        Console.Write("Título: ");
        livro.Titulo = Console.ReadLine();
        Console.Write("Autor: ");
        livro.Autor = Console.ReadLine();
        Console.Write("Valor: ");
        livro.Valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nDetalhes do Livro:");
        Console.WriteLine(livro.ToString());

        Console.ReadLine(); 
    }
}
