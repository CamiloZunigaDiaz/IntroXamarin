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
    public partial class RegisterGridPage : ContentPage
    {
        public RegisterGridPage()
        {
            Indicator.IsRunning = false;
            InitializeComponent();
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            bool required = false;
            if (string.IsNullOrEmpty(FirstName.Text))
            {
                required = true;
                FirstName.BackgroundColor = Color.Red;
                FirstName.Opacity = 50;
            }
            if (required)
            {
                DisplayAlert("Notify", "Fields required", "Cancel");
                return;
            }

            Indicator.IsRunning = true;

            var firstnName = FirstName.Text;
            var lastName = LastName.Text;
            var email = Email.Text;
            var telephone = long.Parse(Telephone.Text);
            var enrollmentDate = EnrollmentDate.Date;

            var message = $"Register successful {firstnName} {lastName}";
            DisplayAlert("Notify", message, "Cancel");

            Register.BackgroundColor = Color.DarkMagenta;

            Indicator.IsRunning = false;
        }
    }
}