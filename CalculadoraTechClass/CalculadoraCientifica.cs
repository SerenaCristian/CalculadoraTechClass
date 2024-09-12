using System;

namespace CalculadoraTechClass
{
    public class CalculadoraCientifica : CalculadoraBasica
    {

        public CalculadoraCientifica(double adicao, double subtracao, double multiplicacao, double divisao) : base(adicao, subtracao, multiplicacao, divisao)
        {
          
        }


        public double Potencia(double Numero, double expoente)
        {
            return Math.Pow(Numero, expoente);
        }


        public double RaizQuadrada(double numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
            }
            return Math.Sqrt(numero);
        }


    }
}
