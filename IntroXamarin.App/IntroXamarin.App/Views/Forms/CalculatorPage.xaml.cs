using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroXamarin.App.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        public double numUno = 0, numDos = 0, resultado = 0;
        string operador = "";
        //int operador = 4;
        bool hayPunto = false, unoDecimal = false, dosDecimal = false;
        // private void Igualar_valores(String operando, int valor)
        // {
        //     bool validaLbl = entNumber.Text.GetType() != operador.GetType();
        //     bool validaSpn = spnFirst.Text.GetType() != operador.GetType();
        //     if (resultado != 0 || ((validaLbl || validaSpn) || (validaLbl && validaSpn)))
        //         unoDecimal = true;
        //     if (unoDecimal)
        //         numUno = double.Parse(entNumber.Text);
        //     else
        //         numUno = int.Parse(entNumber.Text);
        //     spnFirst.Text = numUno + " ";
        //     entNumber.Text = "0";
        //     spnSecond.Text = operando;
        //     operador = valor;
        //     hayPunto = false;
        // }

        // private bool Hallar_Lleno()
        // {
        //     return spnFirst.Text == "" && spnSecond.Text == "";
        // }
        private void escribir(String numero)
        {
            if (entNumber.Text == "0" && numero != ".")
            {
                entNumber.Text = numero;
            }
            else
            {
                entNumber.Text += numero;//
            }
        }
        // /*private void Restar_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("-");

        // }*/
        // private void Sumar_Clicked(object sender, EventArgs e)
        // {
        //     Igualar_valores("+", 0);
        //     if (!Hallar_Lleno())
        //         spnThird.Text = "";
        // }

        ///* private void Multi_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("*");
        // }

        // private void Dividir_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("/");
        // }*/


        // private void Borrar_Clicked(object sender, EventArgs e)
        // {

        // }

        ///* private void Uno_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("1");
        // }
        // private void Dos_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("2");
        // }

        // private void Tres_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("3");
        // }

        // private void Cuatro_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("4");
        // }

        // private void Cinco_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("5");
        // }


        // private void Seis_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("6");
        // }

        // private void Siete_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("7");
        // }

        // private void Ocho_Clicked(object sender, EventArgs e)
        // {
        //     Ingresar_Numero("8");
        // }*/

        // private void Igual_Clicked(object sender, EventArgs e)
        // {
        //     if (spnFirst.Text != "" && spnSecond.Text != "")
        //     {
        //         spnThird.Text = " " + entNumber.Text;
        //         if (dosDecimal)
        //             numDos = double.Parse(spnThird.Text);
        //         else
        //             numDos = int.Parse(spnThird.Text);
        //         if (operador == 0)
        //         {
        //             resultado = numUno + numDos;
        //             entNumber.Text = resultado + "";
        //         }
        //         else if (operador == 1)
        //         {
        //             resultado = numUno - numDos;
        //             entNumber.Text = resultado + "";
        //         }
        //         else if (operador == 2)
        //         {
        //             resultado = numUno * numDos;
        //             entNumber.Text = resultado + "";
        //         }
        //         else
        //         {
        //             if (numDos == 0) { numDos = 1; }
        //             resultado = numUno / numDos;
        //             entNumber.Text = resultado + "";
        //         }
        //         numUno = 0; numDos = 0; resultado = 0;
        //         operador = 4; unoDecimal = false; dosDecimal = false;
        //     }
        // }

        /*private void Nueve_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("9");
        }


        private void Cero_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("0");
        }

        private void Punto_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero(".");
        }*/

        public CalculatorPage()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            entNumber.Text = "";
        }
        public void common_clicked(object sender, EventArgs evt)
        {
            String numero = entNumber.Text;
            String texto = ((Button)sender).Text;

            if (texto == "+" || texto == "-" || texto == "*" || texto == "/")
            {
                operador = texto;
                numUno = Convert.ToInt32(numero);
                limpiar();
            }
            else if (texto == "=")
            {
                numDos = Convert.ToInt32(numero);
                limpiar();
                calcular(operador);
            }
            else
            {
                escribir(((Button)sender).Text);
            }
        }

        public void calcular(string operador)
        {
            switch (operador)
            {
                case "+":
                    escribir(Convert.ToString(numUno + numDos));
                    break;
                case "-":
                    escribir(Convert.ToString(numUno - numDos));
                    break;
                case "*":
                    escribir(Convert.ToString(numUno * numDos));
                    break;
                case "/":
                    if (numDos == 0)
                    {
                        escribir("¡Error, division entre 0!");
                    }
                    else
                    {
                        escribir(Convert.ToString(numUno / numDos));
                    }
                    break;
            }
        }

    }
}