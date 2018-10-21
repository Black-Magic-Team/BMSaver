using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BMSaver.Views;
using BMSaver.Database;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BMSaver
{
    public partial class App : Application
    {
        static BMSaverDatabase _database;
        public static BMSaverDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BMSaverSQLite.db3");

                    _database = new BMSaverDatabase(path);
                }
                return _database;
            }

        }


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
