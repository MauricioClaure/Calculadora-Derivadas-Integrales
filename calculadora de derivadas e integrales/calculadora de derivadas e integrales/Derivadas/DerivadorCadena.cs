using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Derivadas
{
    public class DerivadorCadena
    {
        public string DerivarSeno(string interna,string derivadaInterna)
        {
            return $"cos({interna})*({derivadaInterna})";
        }

        public string DerivarCoseno(string interna,string derivadaInterna)
        {
            return $"-sin({interna})*({derivadaInterna})";
        }

        public string DerivarTangente(string interna,string derivadaInterna)
        {
            return $"sec²({interna})*({derivadaInterna})";
        }

        public string DerivarLn(string interna,string derivadaInterna)
        {
            return $"(1/({interna}))*({derivadaInterna})";
        }

        public string DerivarExponencial(string interna, string derivadaInterna)
        {
            return $"e^({interna})*({derivadaInterna})";
        }
    }
}
