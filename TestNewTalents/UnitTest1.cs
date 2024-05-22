using Xunit;
using NewTalents;
using System;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "21/05/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.multiplicar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(8, 4, 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.dividir(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 3, 2)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(
                 () => calc.dividir(3, 0)
                 );
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = construirClasse();
            calc.somar(1, 2);
            calc.somar(2, 2);
            calc.somar(3, 2);
            calc.somar(4, 2);
            calc.somar(5, 2);

            var lista = calc.historico();
           
            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }


    }
}