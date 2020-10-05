using NUnit.Framework;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        private Calculadora _calculadora;

        [SetUp]
        public void Setup()
        {
            //Executa depois de cada teste rodado
            _calculadora = new Calculadora();
        }

        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(30, 2, ExpectedResult = 32)]
        public int Soma_DeveriaSomarDoisValores(int a, int b)
        {
            return _calculadora.Soma(a, b);
        }

        [TestCase(1, 2, ExpectedResult = -1)]
        [TestCase(30, 2, ExpectedResult = 28)]
        [TestCase(2, 30, ExpectedResult = -28)]
        public int Subtracao_DeveriaSubtrairDoisValores(int a, int b)
        {
            return _calculadora.Subtração(a, b);
        }

        [TestCase(1, 2, ExpectedResult = 2)]
        [TestCase(30, 2, ExpectedResult = 60)]
        [TestCase(2, 30, ExpectedResult = 60)]
        public int Multiplicação_DeveriaMultiplicarDoisValores(int a, int b)
        {
            return _calculadora.Multiplicação(a, b);
        }
    }
}