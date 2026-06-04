using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Derivadas
{
    public class DerivadorProducto
    {
        public string Derivar(string u, string du, string v, string dv)
        {
            return $"{du}*{v}+{u}*{dv}";
        }
    }
}

