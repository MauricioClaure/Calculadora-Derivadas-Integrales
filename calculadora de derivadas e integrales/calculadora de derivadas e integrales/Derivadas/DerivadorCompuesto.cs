using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_derivadas_e_integrales.Derivadas
{
    public class DerivadorCompuesto
    {
        public List<string> SepararTerminos(string expresion)
        {
            expresion = expresion.Replace("-", "+-");

            string[] partes = expresion.Split('+');

            List<string> resultado = new List<string>();

            foreach (string parte in partes)
            {
                if (!string.IsNullOrWhiteSpace(parte))
                {
                    resultado.Add(parte.Trim());
                }
            }

            return resultado;
        }
    }
}
