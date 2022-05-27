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
            Escribir(""); // Evita que el texto sea 'null' al iniciar la aplicación.
        }

        private void Escribir(String texto)
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
                Limpiar();
            }
            entNumber.Text += texto;
        }

        public void Limpiar()
        {
            entNumber.Text = "";
            tienePunto = false;
        }

        public void Common_clicked(object sender, EventArgs evt)
        {
            String numero = entNumber.Text;
            String texto = ((Button)sender).Text;

            if (texto == "+" || texto == "-" || texto == "*" || texto == "/")
            {
                if (numero == "" || numero.EndsWith(".")) return;
                operador = texto;
                numUno = Convert.ToDouble(numero);
                Limpiar();
            }
            else if (texto == "=")
            {
                if (numero == "" || numero.EndsWith(".")) return;
                numDos = Convert.ToDouble(numero);
                Limpiar();
                Calcular(operador);
            }
            else if (texto == "C")
            {
                Limpiar();
            }
            else if (texto == "AC")
            {
                if (numero == "") return;
                string nuevo = entNumber.Text.Remove(entNumber.Text.Length - 1);
                Limpiar();
                Escribir(nuevo);
            }
            else
            {
                Escribir(((Button)sender).Text);
            }
        }

        public void Calcular(string operador)
        {
            switch (operador)
            {
                case "+":
                    Escribir(Convert.ToString(numUno + numDos));
                    break;
                case "-":
                    Escribir(Convert.ToString(numUno - numDos));
                    break;
                case "*":
                    Escribir(Convert.ToString(numUno * numDos));
                    break;
                case "/":
                    if (numDos == 0)
                    {
                        Escribir("¡Error, division entre 0!");
                    }
                    else
                    {
                        Escribir(Convert.ToString(numUno / numDos));
                    }
                    break;
                default:
                    Escribir("¡Operacion desconocida!");
                    break;
            }
        }
    }
}