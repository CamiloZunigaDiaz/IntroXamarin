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
        public double numUno = 0, numDos = 0;
        string operador = "";

        private void escribir(String numero)
        {
            if (entNumber.Text == "0" && numero != ".")
            {
                entNumber.Text = numero;
            }
            else
            {
                entNumber.Text += numero;
            }
        }

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
            escribir("");
            String entrada = ((Button)sender).Text;

            if (entrada == "+" || entrada == "-" || entrada == "*" || entrada == "/")
            {
                if (numero == "") return;
                operador = entrada;
                numUno = Convert.ToInt32(numero);
                limpiar();
            }
            else if (entrada == "=")
            {
                if (numero == "") return;
                numDos = Convert.ToInt32(numero);
                limpiar();
                calcular(operador);
            }
            else if (entrada == "C")
            {
                limpiar();
            }
            else if (entrada == "X")
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