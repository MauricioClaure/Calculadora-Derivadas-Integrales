using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Derivadas
{
    public class DerivadorTrigonometrico
    {
        public string Derivar(string funcion)
        {
            funcion = funcion.Replace(" ", "");

            switch (funcion)
            {
                case "sin(x)":
                    return "cos(x)";

                case "sen(x)":
                    return "cos(x)";

                case "cos(x)":
                    return "-sin(x)";

                case "tan(x)":
                    return "sec²(x)";

                default:
                    return null;
            }
        }
    }
}
