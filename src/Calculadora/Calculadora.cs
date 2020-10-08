using Calculadora.Exceptions;

namespace Calculadora
{
    public class Calculadora
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public int Subtracao(int a, int b)
        {
            return a - b;
        }

        public int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        public decimal Divisao(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new DivisaoPorZeroException();
                
            return dividendo / divisor;
        }
    }
}