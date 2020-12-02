using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calculadora
    {
        
        public static int CalcularExpressao(string expressao)
        {
            int resultado = 0;
            string[] numeroSoma;
            string[] numeroSubtrai;
            string caracter;
            string operadorAnterior="+";
            int inicio = 0;
            int largura = expressao.Length;
            for (int i = 0; i < largura; i++)
            {
                caracter = expressao.Substring(i, 1);
                if ("+-".Contains(caracter) || i==(largura-1))
                {
                    
                    if (i == (largura - 1))
                    {
                        if (operadorAnterior.Equals("-"))
                        {
                            numeroSubtrai = expressao.Substring(inicio).Split("-");
                            resultado = resultado - Subtrair(numeroSubtrai);
                            operadorAnterior = caracter;
                            inicio = i + 1;
                        }
                        if (operadorAnterior.Equals("+"))
                        {
                            numeroSoma = expressao.Substring(inicio).Split("+");
                            resultado = resultado + Somar(numeroSoma);
                            operadorAnterior = caracter;
                            inicio = i + 1;
                        }
                    }

                    if (!caracter.Equals(operadorAnterior))
                    {
                        if (operadorAnterior == "")
                        {
                            operadorAnterior = caracter;
                        }else if (operadorAnterior.Equals("-"))
                        {
                            numeroSubtrai = expressao.Substring(inicio, i-inicio).Split("-");
                            resultado = resultado - Subtrair(numeroSubtrai);
                            operadorAnterior = caracter;
                            inicio = i + 1;
                        }else if (operadorAnterior.Equals("+"))
                        {
                            numeroSoma = expressao.Substring(inicio, i-inicio).Split("+");
                            resultado = resultado + Somar(numeroSoma);
                            operadorAnterior = caracter;
                            inicio = i + 1;
                        }
                    }


                }
            }

            return resultado;
            

        }

        private static int Somar(string[] numero)
        {
            int soma = 0;
            foreach (var item in numero)
            {
                soma = soma + Convert.ToInt32(item);
            }
            return soma;
        }

        private static int Subtrair(string[] numeroSubtrai)
        {
            int subtracao = Convert.ToInt32(numeroSubtrai[0]);
            numeroSubtrai[0] = "0";
            foreach (var item in numeroSubtrai)
            {
                subtracao = subtracao - Convert.ToInt32(item);
            }
            return subtracao;
        }

        
    }
}
