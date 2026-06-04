using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculadora_de_derivadas_e_integrales.Parser;
using calculadora_de_derivadas_e_integrales.Derivadas;
using calculadora_de_derivadas_e_integrales.Utilidades;
using calculadora_de_derivadas_e_integrales.Integrales;

namespace calculadora_de_derivadas_e_integrales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtLimInf.Clear();
            txtLimSup.Clear();
            txtResultado.Clear();
            txtFuncion.Focus();
        }

        private string DerivarTermino(string termino)
        {
            termino = termino.Trim();

            if (EsCociente(termino))
            {
                return DerivarCociente(termino);
            }

            if (EsFuncionCompuesta(termino))
            {
                return DerivarCadena(termino);
            }

            if (EsProducto(termino))
            {
                return DerivarProducto(termino);
            }

            DerivadorTrigonometrico trig = new DerivadorTrigonometrico();

            string r = trig.Derivar(termino);

            if (r != null)
                return r;

            DerivadorLogaritmico log = new DerivadorLogaritmico();

            r = log.Derivar(termino);

            if (r != null)
                return r;

            DerivadorExponencial exp = new DerivadorExponencial();

            r = exp.Derivar(termino);

            if (r != null)
                return r;

            try
            {
                AnalizadorExpresiones analizador = new AnalizadorExpresiones();

                var terminos = analizador.ObtenerPolinomio(termino);

                DerivadorPolinomios derivador = new DerivadorPolinomios();

                return derivador.Derivar(terminos);
            }
            catch
            {
                return "No soportado";
            }
        }

        private string DerivarExpresion(string expresion)
        {
            expresion = expresion.Trim();

            if (EsCociente(expresion))
            {
                return DerivarCociente(expresion);
            }

            DerivadorCompuesto compuesto =
                new DerivadorCompuesto();

            var partes =
                compuesto.SepararTerminos(expresion);

            List<string> derivadas =
                new List<string>();

            foreach (string parte in partes)
            {
                derivadas.Add(
                    DerivarTermino(parte));
            }

            return string.Join("+", derivadas);
        }
        private bool EsProducto(string expresion)
        {
            return expresion.Contains("*");
        }

        private bool EsFuncionCompuesta(string expresion)
        {
            return expresion.StartsWith("sin(")|| expresion.StartsWith("cos(")|| expresion.StartsWith("tan(")|| expresion.StartsWith("ln(")|| expresion.StartsWith("e^(");
        }

        private string DerivarCadena(string expresion)
        {
            DerivadorCadena cadena = new DerivadorCadena();

            if (expresion.StartsWith("sin("))
            {
                string interna = expresion.Substring(4,expresion.Length - 5);

                string dInterna = DerivarTermino(interna);

                return cadena.DerivarSeno(interna, dInterna);
            }

            if (expresion.StartsWith("cos("))
            {
                string interna = expresion.Substring(4, expresion.Length - 5);

                string dInterna = DerivarTermino(interna);

                return cadena.DerivarCoseno(interna, dInterna);
            }

            if (expresion.StartsWith("tan("))
            {
                string interna = expresion.Substring(4, expresion.Length - 5);

                string dInterna = DerivarTermino(interna);

                return cadena.DerivarTangente(interna, dInterna);
            }

            if (expresion.StartsWith("ln("))
            {
                string interna = expresion.Substring(3, expresion.Length - 4);

                string dInterna = DerivarTermino(interna);

                return cadena.DerivarLn(interna, dInterna);
            }

            if (expresion.StartsWith("e^("))
            {
                string interna = expresion.Substring(3, expresion.Length - 4);

                string dInterna = DerivarTermino(interna);

                return cadena.DerivarExponencial(interna, dInterna);
            }

            return null;
        }
        private string DerivarProducto(string expresion)
        {
            string[] partes = expresion.Split('*');

            if (partes.Length != 2)
                return null;

            string u = partes[0];
            string v = partes[1];

            string du = DerivarTermino(u);
            string dv = DerivarTermino(v);

            DerivadorProducto producto = new DerivadorProducto();

            return producto.Derivar(u,du,v,dv);
        }

        private bool EsCociente(string expresion)
        {
            return expresion.Contains("/") && expresion.StartsWith("(");
        }

        private string DerivarCociente(string expresion)
        {
            int division = expresion.IndexOf(")/(");

            if (division == -1)
                return null;

            string u = expresion.Substring(1, division - 1);

            string v =
                expresion.Substring(division + 3,expresion.Length - division - 4);

            string du = DerivarExpresion(u);
            string dv = DerivarExpresion(v);

            DerivadorCociente cociente = new DerivadorCociente();

            return cociente.Derivar(u,du,v,dv);
        }

        private void btnDerivar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAR FUNCIÓN
                if (string.IsNullOrWhiteSpace(txtFuncion.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar una función.");

                    txtFuncion.Focus();

                    return;
                }

                string funcion =
                    txtFuncion.Text.Trim();

                DerivadorCompuesto compuesto =
                    new DerivadorCompuesto();

                var partes =
                    compuesto.SepararTerminos(funcion);

                List<string> derivadas =
                    new List<string>();

                foreach (string parte in partes)
                {
                    derivadas.Add(
                        DerivarTermino(parte));
                }

                string resultado =
                    DerivarExpresion(funcion);

                Simplificador simplificador =
                    new Simplificador();

                resultado =
                    simplificador.Simplificar(resultado);

                txtResultado.Text =
                    resultado;

                lstHistorial.Items.Add(
                    $"[Derivada] d/dx({funcion}) = {resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDAR FUNCIÓN
                if (string.IsNullOrWhiteSpace(txtFuncion.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar una función.");

                    txtFuncion.Focus();

                    return;
                }

                string funcion =
                    txtFuncion.Text.Trim();

                IntegradorTrigonometrico trig =
                    new IntegradorTrigonometrico();

                string resultado =
                    trig.Integrar(funcion);

                if (resultado != null)
                {
                    txtResultado.Text = resultado;

                    lstHistorial.Items.Add(
                        $"[Integral] ∫({funcion})dx = {resultado}");

                    return;
                }

                IntegradorLogaritmico log =
                    new IntegradorLogaritmico();

                resultado = log.Integrar(funcion);

                if (resultado != null)
                {
                    txtResultado.Text = resultado;

                    lstHistorial.Items.Add(
                        $"[Integral] ∫({funcion})dx = {resultado}");

                    return;
                }

                IntegradorExponencial exp =
                    new IntegradorExponencial();

                resultado = exp.Integrar(funcion);

                if (resultado != null)
                {
                    txtResultado.Text = resultado;

                    lstHistorial.Items.Add(
                        $"[Integral] ∫({funcion})dx = {resultado}");

                    return;
                }

                AnalizadorExpresiones analizador =
                    new AnalizadorExpresiones();

                var terminos =
                    analizador.ObtenerPolinomio(funcion);

                IntegradorPolinomios integrador =
                    new IntegradorPolinomios();

                resultado =
                    integrador.Integrar(terminos);

                txtResultado.Text = resultado;

                lstHistorial.Items.Add(
                    $"[Integral] ∫({funcion})dx = {resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }

        private void btnIntegralDef_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtFuncion.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar una función.");

                    txtFuncion.Focus();

                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtLimInf.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar el límite inferior.");

                    txtLimInf.Focus();

                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtLimSup.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar el límite superior.");

                    txtLimSup.Focus();

                    return;
                }

                string funcion =
                    txtFuncion.Text.Trim()
                    .Replace(" ", "")
                    .ToLower();

                double limInf;
                double limSup;

                
                if (!double.TryParse(
                    txtLimInf.Text,
                    out limInf))
                {
                    MessageBox.Show(
                        "El límite inferior debe ser numérico.");

                    txtLimInf.Focus();

                    return;
                }

                
                if (!double.TryParse(
                    txtLimSup.Text,
                    out limSup))
                {
                    MessageBox.Show(
                        "El límite superior debe ser numérico.");

                    txtLimSup.Focus();

                    return;
                }

                IntegradorDefinido integrador =
                    new IntegradorDefinido();

                
                if (funcion == "sin(x)")
                {
                    double resultado =
                        integrador.CalcularSin(
                            limInf,
                            limSup);

                    txtResultado.Text =
                        resultado.ToString();

                    lstHistorial.Items.Add(
                        $"[Integral Definida] ∫[{limInf},{limSup}] sin(x) dx = {resultado}");

                    return;
                }

                
                if (funcion == "cos(x)")
                {
                    double resultado =
                        integrador.CalcularCos(
                            limInf,
                            limSup);

                    txtResultado.Text =
                        resultado.ToString();

                    lstHistorial.Items.Add(
                        $"[Integral Definida] ∫[{limInf},{limSup}] cos(x) dx = {resultado}");

                    return;
                }

                
                if (funcion == "e^x")
                {
                    double resultado =
                        integrador.CalcularExponencial(
                            limInf,
                            limSup);

                    txtResultado.Text =
                        resultado.ToString();

                    lstHistorial.Items.Add(
                        $"[Integral Definida] ∫[{limInf},{limSup}] e^x dx = {resultado}");

                    return;
                }

                
                if (funcion == "1/x")
                {
                    if (limInf == 0 || limSup == 0)
                    {
                        MessageBox.Show(
                            "La función 1/x no está definida en x = 0.");

                        return;
                    }

                    double resultado =
                        integrador.CalcularLogaritmo(
                            limInf,
                            limSup);

                    txtResultado.Text =
                        resultado.ToString();

                    lstHistorial.Items.Add(
                        $"[Integral Definida] ∫[{limInf},{limSup}] 1/x dx = {resultado}");

                    return;
                }

                
                AnalizadorExpresiones analizador =
                    new AnalizadorExpresiones();

                var terminos =
                    analizador.ObtenerPolinomio(
                        funcion);

                double resultadoPolinomio =
                    integrador.Calcular(
                        terminos,
                        limInf,
                        limSup);

                txtResultado.Text =
                    resultadoPolinomio.ToString();

                lstHistorial.Items.Add(
                    $"[Integral Definida] ∫[{limInf},{limSup}] {funcion} dx = {resultadoPolinomio}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }
    }
}
