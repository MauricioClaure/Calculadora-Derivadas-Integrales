using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Integrales
{
    public class IntegradorTrigonometrico
    {
        public string Integrar(string funcion)
        {
            funcion = funcion.Replace(" ", "");

            switch (funcion)
            {
                case "sin(x)":
                    return "-cos(x) + C";

                case "cos(x)":
                    return "sin(x) + C";

                case "sec²(x)":
                    return "tan(x) + C";

                default:
                    return null;
            }
        }
    }
}
