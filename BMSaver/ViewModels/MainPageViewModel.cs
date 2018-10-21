using System;
using System.Windows.Input;
using BMSaver.Views;
using Xamarin.Forms;

namespace BMSaver.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand OpenClothesListPage
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushModalAsync(new ClothesListPage(), false);
                });
            }
        }
    }
}
