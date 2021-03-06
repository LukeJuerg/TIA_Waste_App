using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIA_Waste_App.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TIA_Waste_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }

        async void SignInProcedure(object sender, EventArgs e)
        {
            //User user = new User(Entry_Username.Text, Entry_Password.Text);
            //if (user.CheckInformation())
            //{
            //   await DisplayAlert("Login", "Login Success!", "Ok");
            //}
            //else
            //{
            //   await DisplayAlert("Login", "Login Failure!", "Ok");
            //}
            await Navigation.PushAsync(new MainMenu());
        }
    }
}