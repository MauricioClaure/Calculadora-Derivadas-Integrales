using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculadora_de_derivadas_e_integrales.Utilidades;

namespace calculadora_de_derivadas_e_integrales.Utilidades
{
    public class Simplificador
    {
        public string Simplificar(string expresion)
        {
            expresion = expresion.Replace("+0", "");
            expresion = expresion.Replace("0+", "");
            expresion = expresion.Replace("+-", "-");

            return expresion;
        }
    }
}
