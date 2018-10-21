using System;
using System.Collections.Generic;
using BMSaver.ViewModels;
using Xamarin.Forms;

namespace BMSaver.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            if (this.BindingContext == null)
            {
                this.BindingContext = new MainPageViewModel();
            }
            base.OnAppearing();
        }





    }
}
