using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("0 - Sair");

            Console.Write("Opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                break;
            }

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero!");
                        continue; 
                    }
                    break;
                case 5:
                    if (num2 != 0)
                    {
                        resultado = num1 % num2;
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero!");
                        continue; 
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    continue; 
            }

            Console.WriteLine($"Resultado: {resultado}\n");
        }
    }
}
