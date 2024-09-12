namespace CalculadoraTechClass
{
    using CalculadoraTechClass.Enumeradores;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('.', 50);
            int opcao = -1;

            while (opcao != 0)
            {
                Console.WriteLine("Selecione a opção desejada: ");
                Console.WriteLine(sep);
                Console.WriteLine("1 - Calculadora");
                Console.WriteLine("0 - Sair");

                MenuCalculadora MenuPrincipal = Enum.Parse<MenuCalculadora>(Console.ReadLine(), true);

                switch (MenuPrincipal)
                {
                    case MenuCalculadora.Calculadora:
                        ExibirOpcoes();
                        break;
                    case MenuCalculadora.Sair:
                        opcao = 0;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void ExibirOpcoes()
        {
            int opcao = -1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.WriteLine("Selecione a operação desejada: ");
                Console.WriteLine(new string('.', 50));
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potência");
                Console.WriteLine("6 - Raiz Quadrada");
                Console.WriteLine("0 - Voltar");

                MenuOperacoes MenuOperacao = Enum.Parse<MenuOperacoes>(Console.ReadLine(), true);

                double valor1, valor2;

                switch (MenuOperacao)
                {
                    case MenuOperacoes.Adicao:
                        Console.Write("Digite o primeiro valor: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo valor: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado: " + CalculadoraClass.OperacaoAdicao(valor1, valor2));
                        Console.ReadKey();
                        break;

                    case MenuOperacoes.Subtracao:
                        Console.Write("Digite o primeiro valor: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo valor: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado: " + CalculadoraClass.OperacaoSubtracao(valor1, valor2));
                        Console.ReadKey();
                        break;

                    case MenuOperacoes.Multiplicacao:
                        Console.Write("Digite o primeiro valor: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo valor: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado: " + CalculadoraClass.OperacaoMultiplicacao(valor1, valor2));
                        Console.ReadKey();
                        break;

                    case MenuOperacoes.Divisao:
                        Console.Write("Digite o primeiro valor: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo valor: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado: " + CalculadoraClass.OperacaoDivisao(valor1, valor2));
                        Console.ReadKey();
                        break;

                    case MenuOperacoes.Potencia:
                        Console.Write("Digite a base: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o expoente: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado: " + CalculadoraClass.OperacaoPotencia(valor1, valor2));
                        Console.ReadKey();
                        break;

                    case MenuOperacoes.RaizQuadrada:
                        Console.Write("Digite o valor: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Resultado: " + CalculadoraClass.OperacaoRaizQuadrada(valor1));
                        Console.ReadKey();
                        break;

                    case MenuOperacoes.Voltar:
                        opcao = 0;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}


