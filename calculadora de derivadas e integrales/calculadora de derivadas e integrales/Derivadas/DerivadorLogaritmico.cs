using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Derivadas
{
    public class DerivadorLogaritmico
    {
        public string Derivar(string funcion)
        {
            funcion = funcion.Replace(" ", "");

            switch (funcion)
            {
                case "ln(x)":
                    return "1/x";

                case "log(x)":
                    return "1/(x ln(10))";

                default:
                    return null;
            }
        }
    }
}

