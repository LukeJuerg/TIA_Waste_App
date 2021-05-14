using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIA_Waste_App.Models;
using TIA_Waste_App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TIA_Waste_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
            Init();
        }

        async void LogOut(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            
        }
    }
}