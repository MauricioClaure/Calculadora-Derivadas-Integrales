using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculadora_de_derivadas_e_integrales.Parser;
namespace calculadora_de_derivadas_e_integrales.Integrales
{
    public class IntegradorPolinomios
    {
        public string Integrar(List<Termino> terminos)
        {
            StringBuilder resultado =
                new StringBuilder();

            foreach (var termino in terminos)
            {
                int nuevoExponente =
                    termino.Exponente + 1;

                double nuevoCoeficiente =
                    termino.Coeficiente /
                    nuevoExponente;

                if (resultado.Length > 0 &&
                    nuevoCoeficiente > 0)
                {
                    resultado.Append("+");
                }

                if (nuevoExponente == 1)
                {
                    resultado.Append(
                        $"{nuevoCoeficiente}x");
                }
                else
                {
                    resultado.Append(
                        $"({nuevoCoeficiente})x^{nuevoExponente}");
                }
            }

            resultado.Append(" + C");

            return resultado.ToString();
        }
    }
}
