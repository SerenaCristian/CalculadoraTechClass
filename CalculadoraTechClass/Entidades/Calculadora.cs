namespace CalculadoraTechClass
{
    class CalculadoraClass
    {
        public static double OperacaoAdicao(double valor1, double valor2) => valor1 + valor2;
        public static double OperacaoSubtracao(double valor1, double valor2) => valor1 - valor2;
        public static double OperacaoMultiplicacao(double valor1, double valor2) => valor1 * valor2;
        public static double OperacaoDivisao(double valor1, double valor2) => valor1 / valor2;

       
        public static double OperacaoPotencia(double valorBase, double expoente) => Math.Pow(valorBase, expoente);

        
        public static double OperacaoRaizQuadrada(double valor) => Math.Sqrt(valor);
    }
}
