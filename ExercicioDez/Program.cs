using System;
using System.Collections.Generic;

class Aluno
{
    public string Nome { get; set; }
    public string RA { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public int TotalFaltas { get; set; }

    public Aluno(string nome, string ra)
    {
        Nome = nome;
        RA = ra;
    }

    public double CalcularMedia()
    {
        double media = (NotaProva * 7 + NotaTrabalho * 3) / 10;
        return media;
    }

    public double CalcularFrequenciaPercentual()
    {
        double percentual = ((25 - TotalFaltas) / 25.0) * 100;
        return percentual;
    }

    public string Situacao()
    {
        double media = CalcularMedia();
        double frequencia = CalcularFrequenciaPercentual();

        if (media >= 7 && frequencia >= 75)
        {
            return "APROVADO";
        }
        else
        {
            return "REPROVADO";
        }
    }
}

class Program
{
    static List<Aluno> alunos = new List<Aluno>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Cadastro de Alunos");
            Console.WriteLine("2 - Cadastro de Notas");
            Console.WriteLine("3 - Cadastro Total de Faltas");
            Console.WriteLine("4 - Relação de Alunos, Notas, Média, Faltas e Situação");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarAluno();
                    break;
                case 2:
                    CadastrarNotas();
                    break;
                case 3:
                    CadastrarFaltas();
                    break;
                case 4:
                    ExibirRelatorio();
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 0);
    }

    static void CadastrarAluno()
    {
        Console.WriteLine("\nCadastro de Aluno:");
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();
        Console.Write("RA do aluno: ");
        string ra = Console.ReadLine();

        alunos.Add(new Aluno(nome, ra));
    }

    static void CadastrarNotas()
    {
        Console.WriteLine("\nCadastro de Notas:");
        Console.Write("Digite o RA do aluno: ");
        string ra = Console.ReadLine();
        Aluno aluno = alunos.Find(a => a.RA == ra);

        if (aluno != null)
        {
            Console.Write("Digite a nota da prova (máximo 10): ");
            double notaProva = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota do trabalho (máximo 10): ");
            double notaTrabalho = double.Parse(Console.ReadLine());

            aluno.NotaProva = Math.Min(10, Math.Max(0, notaProva));
            aluno.NotaTrabalho = Math.Min(10, Math.Max(0, notaTrabalho));
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }

    static void CadastrarFaltas()
    {
        Console.WriteLine("\nCadastro de Faltas:");
        Console.Write("Digite o RA do aluno: ");
        string ra = Console.ReadLine();
        Aluno aluno = alunos.Find(a => a.RA == ra);

        if (aluno != null)
        {
            Console.Write("Digite o total de faltas do aluno: ");
            aluno.TotalFaltas = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }

    static void ExibirRelatorio()
    {
        Console.WriteLine("\nRelatório de Alunos:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"RA: {aluno.RA}");
            Console.WriteLine($"Nota da Prova: {aluno.NotaProva}");
            Console.WriteLine($"Nota do Trabalho: {aluno.NotaTrabalho}");
            Console.WriteLine($"Média: {aluno.CalcularMedia()}");
            Console.WriteLine($"Total de Faltas: {aluno.TotalFaltas}");
            Console.WriteLine($"Percentual de Frequência: {aluno.CalcularFrequenciaPercentual()}%");
            Console.WriteLine($"Situação: {aluno.Situacao()}");
            Console.WriteLine();
        }
    }
}
