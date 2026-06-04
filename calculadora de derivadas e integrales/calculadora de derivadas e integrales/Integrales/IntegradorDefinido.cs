using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculadora_de_derivadas_e_integrales.Parser;

namespace calculadora_de_derivadas_e_integrales.Integrales
{
    public class IntegradorDefinido
    {
        public double Calcular(
            List<Termino> terminos,
            double a,
            double b)
        {
            double resultado = 0;

            foreach (var termino in terminos)
            {
                int nuevoExp =
                    termino.Exponente + 1;

                double nuevoCoef =
                    termino.Coeficiente /
                    nuevoExp;

                double fb =
                    nuevoCoef *
                    Math.Pow(b, nuevoExp);

                double fa =
                    nuevoCoef *
                    Math.Pow(a, nuevoExp);

                resultado += (fb - fa);
            }

            return resultado;
        }
        public double CalcularSin(double a, double b)
        {
            return Math.Cos(a) - Math.Cos(b);
        }

        public double CalcularCos(
            double a,
            double b)
        {
            return Math.Sin(b) -
                   Math.Sin(a);
        }

        public double CalcularExponencial(
            double a,
            double b)
        {
            return Math.Exp(b) -
                   Math.Exp(a);
        }

        public double CalcularLogaritmo(
            double a,
            double b)
        {
            return Math.Log(Math.Abs(b)) -
                   Math.Log(Math.Abs(a));
        }
    }
}
