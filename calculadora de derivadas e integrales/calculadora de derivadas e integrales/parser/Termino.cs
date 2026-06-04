using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Parser
{
    public class Termino
    {
        public double Coeficiente { get; set; }
        public int Exponente { get; set; }
    }

    public class AnalizadorExpresiones
    {
        public List<Termino> ObtenerPolinomio(string expresion)
        {
            List<Termino> terminos = new List<Termino>();

            expresion = expresion.Replace("-", "+-");

            string[] partes = expresion.Split('+');

            foreach (string parte in partes)
            {
                if (string.IsNullOrWhiteSpace(parte))
                    continue;

                Termino termino = new Termino();

                if (parte.Contains("x"))
                {
                    string[] datos = parte.Split('x');

                    if (datos[0] == "" || datos[0] == "+")
                        termino.Coeficiente = 1;
                    else if (datos[0] == "-")
                        termino.Coeficiente = -1;
                    else
                        termino.Coeficiente = Convert.ToDouble(datos[0]);

                    if (parte.Contains("^"))
                    {
                        termino.Exponente =
                            Convert.ToInt32(
                                parte.Substring(
                                    parte.IndexOf("^") + 1));
                    }
                    else
                    {
                        termino.Exponente = 1;
                    }
                }
                else
                {
                    termino.Coeficiente =
                        Convert.ToDouble(parte);

                    termino.Exponente = 0;
                }

                terminos.Add(termino);
            }

            return terminos;
        }
    }
}
