using System;
using Xunit;

namespace Calculadora.Test
{
    public class UnitTest1
    {
        public int expected { get; private set; }
        public string expressao { get; private set; }
        public int result { get; private set; }

        [Fact]
        public void CalcularExpressaoTest_2_mais_2()
        {
            expected = 4;
            expressao = "2+2";

            result = Calculadora.CalcularExpressao(expressao);

            Assert.Equal(expected, result);


        }
        [Fact]
        public void CalcularExpressaoTest_2_mais_4()
        {
            expected = 6;
            expressao = "2+4";

            result= Calculadora.CalcularExpressao(expressao);

            Assert.Equal(expected, result);


        }

        [Fact]
        public void CalcularExpressaTest_2_menos_1()
        {
            expected = 1;
            expressao = "2-1";

            result = Calculadora.CalcularExpressao(expressao);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void CalcularExpressaTest_5_menos_1_mais_3()
        {
            expected = 7;
            expressao = "5-1+3";

            result = Calculadora.CalcularExpressao(expressao);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void CalcularExpressaoTest_2_mais_4_mais_10_menos_3_menos_1_mais_20()
        {
            expected = 34;
            expressao = "2+4+10-3-1+20";

            result = Calculadora.CalcularExpressao(expressao);

            Assert.Equal(expected, result);


        }

        [Fact]
        public void CalcularExpressaoTest_2_mais_4_mais_10_menos_3_menos_1_mais_20_mais_20_menos_4()
        {
            expected = 50;
            expressao = "2+4+10-3-1+20+20-4";

            result = Calculadora.CalcularExpressao(expressao);

            Assert.Equal(expected, result);


        }
    }
}
