using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculadora_de_derivadas_e_integrales.Parser;

namespace calculadora_de_derivadas_e_integrales.Derivadas
{
    public class DerivadorPolinomios
    {
        public string Derivar(List<Termino> terminos)
        {
            StringBuilder resultado = new StringBuilder();

            foreach (var termino in terminos)
            {
                if (termino.Exponente == 0)
                {
                    if (resultado.Length > 0)
                        resultado.Append("+");

                    resultado.Append("0");

                    continue;
                }

                double nuevoCoeficiente = termino.Coeficiente * termino.Exponente;

                int nuevoExponente = termino.Exponente - 1;

                if (resultado.Length > 0 && nuevoCoeficiente > 0)
                {
                    resultado.Append("+");
                }

                if (nuevoExponente == 0)
                {
                    resultado.Append(nuevoCoeficiente);
                }
                else if (nuevoExponente == 1)
                {
                    resultado.Append($"{nuevoCoeficiente}x");
                }
                else
                {
                    resultado.Append($"{nuevoCoeficiente}x^{nuevoExponente}");
                }
            }

            return resultado.ToString();
        }
    }
}
