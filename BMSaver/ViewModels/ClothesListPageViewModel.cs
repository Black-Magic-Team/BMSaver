using System;
using System.Windows.Input;
using BMSaver.Views;
using Xamarin.Forms;

namespace BMSaver.ViewModels
{
    public class ClothesListPageViewModel : BaseViewModel
    {
        public ICommand OpenMainPage
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(), false);
                });

            }

        }
    }
}
