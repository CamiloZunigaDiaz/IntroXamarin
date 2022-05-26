﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace IntroXamarin.App.ViewModels.Forms
{
    internal class RegisterPatternViewModel : BaseViewModel
    {
        #region Attributes
        private string _firstName;
        private string _lastName;
        private string _email;
        private long _telephone;
        private DateTime _enrollmentDate;

        #endregion

        #region Properties
        public string FirstName
        {
            get { return _firstName; }
            set { this.SetValue(ref _firstName, value); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { this.SetValue(ref _lastName, value); }
        }

        public long Telephone
        {
            get { return _telephone; }
            set { this.SetValue(ref _telephone, value); }
        }

        public string Email
        {
            get { return _email; }
            set { this.SetValue(ref _email, value); }

        }

        public DateTime EnrollmentDate
        {
            get { return _enrollmentDate; }
            set { this.SetValue(ref _enrollmentDate, value); }
        }
        #endregion

        public RegisterPatternViewModel()
        {
            this.EnrollmentDate = DateTime.Now;
            this.RegisterCommand = new Command(Register);
        }

        #region Commands
        public Command RegisterCommand { get; set; }
        #endregion

        #region Methods
        private async void Register()
        {
            bool required = false;
            if (string.IsNullOrEmpty(this.FirstName))
                required = true;


            if (required)
            {
                await Application.Current.MainPage.DisplayAlert("Notify", "Fields required", "Cancel");
                return;
            }
            var firstnName = this.FirstName;
            var lastName = this.LastName;
            var email = this.Email;
            var telephone = this.Telephone;
            var enrollmentDate = this.EnrollmentDate.Date;

            var message = $"Register successful {firstnName} {lastName}";
            await Application.Current.MainPage.DisplayAlert("Notify", message, "Cancel");

        } 
        #endregion
    }
}