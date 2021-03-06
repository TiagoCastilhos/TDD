using Calculadora.Exceptions;
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
            return _calculadora.Subtracao(a, b);
        }

        [TestCase(1, 2, ExpectedResult = 2)]
        [TestCase(30, 2, ExpectedResult = 60)]
        [TestCase(2, 30, ExpectedResult = 60)]
        public int Multiplicacao_DeveriaMultiplicarDoisValores(int a, int b)
        {
            return _calculadora.Multiplicacao(a, b);
        }

        [TestCase(4, 2, ExpectedResult = 2)]
        [TestCase(30, 2, ExpectedResult = 15)]
        public decimal Divisao_DeveriaDividirDoisValores(int a, int b)
        {
            return _calculadora.Divisao(a, b);
        }

        [Test]
        public void Divisao_DivisorEhZero_DeveriaDispararDivisaoPorZeroException()
        {
            Assert.Throws<DivisaoPorZeroException>(() => _calculadora.Divisao(5, 0)); 
        }
    }
}