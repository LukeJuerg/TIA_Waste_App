using System;
using TIA_Waste_App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TIA_Waste_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
            MainPage = new MainMenu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
