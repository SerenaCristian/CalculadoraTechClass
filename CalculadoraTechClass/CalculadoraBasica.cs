using System;


namespace CalculadoraTechClass
{
    public class CalculadoraBasica 
    {
        public double Adicao { get; private set; }
        public double Subtracao { get; private set; }

        public double Multiplicacao { get; private set; }

        public double Divisao{ get; private set; }


        public CalculadoraBasica(double adicao, double subtracao, double multiplicacao, double divisao) 
        {
            Adicao = adicao;
            Subtracao = subtracao;
            Multiplicacao = multiplicacao;
            Divisao = divisao;
        }

        public double OperacaoAdicao(double valor1, double valor2) 
        {
            return valor1 += valor2; 
        }

        public double OperacaoSubtracao(double valor1, double valor2)
        {
            return valor1 -= valor2;
        }

        public double OperacaoMultiplicacao(double valor1, double valor2)
        {
            return valor1 *= valor2;
        }

        public double OperacaoDivisao(double valor1, double valor2)
        {
            return valor1 / valor2;
        }


    }
}
