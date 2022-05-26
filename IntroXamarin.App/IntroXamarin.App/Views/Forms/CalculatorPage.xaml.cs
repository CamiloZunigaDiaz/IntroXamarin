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
        double numUno = 0, numDos = 0;
        bool tienePunto = false;
        string operador = "";

        public CalculatorPage()
        {
            InitializeComponent();
            escribir(""); // Evita que el texto sea 'null' al iniciar la aplicación.
        }

        private void escribir(String texto)
        {
            if (texto == ".")
            {
                if (!tienePunto && entNumber.Text == "0")
                {
                    tienePunto = true;
                }
                else return;
            }
            else if (entNumber.Text == "0")
            {
                limpiar();
            }
            entNumber.Text += texto;
        }

        public void limpiar()
        {
            entNumber.Text = "";
            tienePunto = false;
        }

        public void common_clicked(object sender, EventArgs evt)
        {
            String numero = entNumber.Text;
            String texto = ((Button)sender).Text;

            if (texto == "+" || texto == "-" || texto == "*" || texto == "/")
            {
                if (numero == "" || numero.EndsWith(".")) return;
                operador = texto;
                numUno = Convert.ToDouble(numero);
                limpiar();
            }
            else if (texto == "=")
            {
                if (numero == "" || numero.EndsWith(".")) return;
                numDos = Convert.ToDouble(numero);
                limpiar();
                calcular(operador);
            }
            else if (texto == "C")
            {
                limpiar();
            }
            else if (texto == "X")
            {
                if (numero == "") return;
                string nuevo = entNumber.Text.Remove(entNumber.Text.Length - 1);
                limpiar();
                escribir(nuevo);
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
                default:
                    escribir("¡Operacion desconocida!");
                    break;
            }
        }
    }
}