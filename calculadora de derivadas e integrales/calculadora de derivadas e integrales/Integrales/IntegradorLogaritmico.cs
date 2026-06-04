using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Integrales
{
    public class IntegradorLogaritmico
    {
        public string Integrar(string funcion)
        {
            funcion = funcion.Replace(" ", "");

            switch (funcion)
            {
                case "1/x":
                    return "ln|x| + C";

                default:
                    return null;
            }
        }
    }
}
