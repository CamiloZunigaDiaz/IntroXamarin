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
        public double numUno = 0, numDos= 0, resultado = 0;
        

        

        private void Ingresar_Numero (String numero)
        {
            if(entNumber.Text == "0" && numero != ".")
            {
                entNumber.Text = numero;
            }else
            {
                entNumber.Text += numero;//
            }
        }
        private void Restar_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("-");

        }
        private void Sumar_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("+");
        }

        private void Multi_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("*");
        }

        private void Dividir_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("/");
        }


        private void Borrar_Clicked(object sender, EventArgs e) 
        {
           
        }

        private void Uno_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("1");
        }
        private void Dos_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("2");
        }

        private void Tres_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("3");
        }

        private void Cuatro_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("4");
        }

        private void Cinco_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("5");
        }
               

        private void Seis_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("6");
        }
                
        private void Siete_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("7");
        }

        private void Ocho_Clicked(object sender, EventArgs e)
        {
            Ingresar_Numero("8");
        }

        private void Nueve_Clicked(object sender, EventArgs e)
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
        }
            

        public CalculatorPage()
        {
            InitializeComponent();
        }
    }
}