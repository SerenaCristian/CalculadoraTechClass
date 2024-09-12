using System;
using CalculadoraTechClass;

class Program
{
    static void Main(string[] args)
    {
        string sep = new string('.', 50);
        int op = 0;
        double valor1, valor2 = 0;

        Console.WriteLine(sep);
        Console.WriteLine("Calculadora Tech Class");
        Console.WriteLine(sep);

        Console.WriteLine("Escolha o tipo de calculadora:");
        Console.WriteLine("1 - Calculadora Básica");
        Console.WriteLine("2 - Calculadora Científica");
        Console.Write("Digite sua escolha: ");
        int escolha = int.Parse(Console.ReadLine());

        Console.WriteLine(sep);
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        if (escolha == 2)
        {
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Raiz Quadrada");
        }

        Console.WriteLine(sep);
        Console.Write("Selecione a operação que deseja executar: ");
        op = int.Parse(Console.ReadLine());

        Console.Write("Digite o 1º Valor: ");
        valor1 = double.Parse(Console.ReadLine());

        if (op != 6)
        {
            Console.Write("Digite o 2º Valor: ");
            valor2 = double.Parse(Console.ReadLine());
        }

        CalculadoraCientifica calcCientifica = new CalculadoraCientifica(0,0,0,0);

        switch (op)
        {
            case 1:
                Console.WriteLine($"Adição: {calcCientifica.OperacaoAdicao(valor1, valor2)}");
                break;

            case 2:
                Console.WriteLine($"Subtração: {calcCientifica.OperacaoSubtracao(valor1, valor2)}");
                break;

            case 3:
                Console.WriteLine($"Multiplicação: {calcCientifica.OperacaoMultiplicacao(valor1, valor2)}");
                break;

            case 4:
                if (valor2 != 0)
                {
                    Console.WriteLine($"Divisão: {calcCientifica.OperacaoDivisao(valor1, valor2)}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;

            case 5:
                Console.WriteLine($"Potência: {calcCientifica.Potencia(valor1, valor2)}");
                break;

            case 6:
                Console.WriteLine($"Raiz Quadrada: {calcCientifica.RaizQuadrada(valor1)}");
                break;

            default:
                Console.WriteLine("Opção inválida! Por favor, selecione uma opção entre 1 e 6.");
                break;
        }

        Console.WriteLine(sep);
    }
}
