using System;
using Calculadora.Exceptions;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var resposta = Menu();
            var calculadora = new Calculadora();

            switch (resposta)
            {
                case 1:
                    Soma(calculadora);
                    break;
                case 2:
                    Subtracao(calculadora);
                    break;
                case 3:
                    Multiplicacao(calculadora);
                    break;
                case 4:
                    Divisao(calculadora);
                    break;
            }

            Console.Read();
        }

        static int Menu()
        {
            Console.WriteLine("Escolha uma operacao: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            return int.Parse(Console.ReadLine());
        }

        static void Soma(Calculadora calculadora)
        {
            Console.WriteLine("Escolha o primeiro numero:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo numero:");
            var b = int.Parse(Console.ReadLine());
            var resultado = calculadora.Soma(a, b);

            Console.WriteLine($"Resultado da soma: {resultado}");
        }

        static void Subtracao(Calculadora calculadora)
        {
            Console.WriteLine("Escolha o primeiro numero:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo numero:");
            var b = int.Parse(Console.ReadLine());
            var resultado = calculadora.Subtração(a, b);

            Console.WriteLine($"Resultado da subtracao: {resultado}");
        }

        static void Multiplicacao(Calculadora calculadora)
        {
            Console.WriteLine("Escolha o primeiro numero:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo numero:");
            var b = int.Parse(Console.ReadLine());
            var resultado = calculadora.Multiplicacao(a, b);

            Console.WriteLine($"Resultado da multiplicacao: {resultado}");
        }

        static void Divisao(Calculadora calculadora)
        {
            Console.WriteLine("Escolha o primeiro numero:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo numero:");
            var b = int.Parse(Console.ReadLine());

            try
            {
                var resultado = calculadora.Divisao(a, b);

                Console.WriteLine($"Resultado da divisao: {resultado}");
            }
            catch (DivisaoPorZeroException)
            {
                Console.WriteLine("Divisor nao pode ser 0");
            }
        }
    }
}