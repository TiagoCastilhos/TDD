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
        public int Soma_DeveriaSomarDoisValores(int a, int b)
        {
            var calculadora = new Calculadora();

            return calculadora.Soma(a, b);
        }
    }
}