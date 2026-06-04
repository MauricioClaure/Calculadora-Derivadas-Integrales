using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Derivadas
{
    public class DerivadorExponencial
    {
        public string Derivar(string funcion)
        {
            funcion = funcion.Replace(" ", "");

            switch (funcion)
            {
                case "e^x":
                    return "e^x";

                default:
                    return null;
            }
        }
    }

}

