using System;

namespace CalculadoraTechClass
{
    public class CalculadoraCientifica : CalculadoraBasica
    {
        
        public CalculadoraCientifica() : base(0,0,0,0)
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

        
        public double LogaritmoNatural(double numero)
        {
            if (numero <= 0)
            {
                Console.WriteLine("O logaritmo natural só é definido para números positivos.");
            }
            return Math.Log(numero);
        }
    }
}
