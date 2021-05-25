using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIA_Waste_App.Models;
using TIA_Waste_App.Views.Menu;
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
            App.StartCheckIfInternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }

         async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success!", "Ok");
                // var result = await App.RestService.Login(user); //The app is not connected to a server so it will not be able to retrieve a token
                var result = new Token(); //Dummy Token
                if (result != null) //result.access_token
                {
                    // App.UserDatabase.SaveUser(user);
                    // App.TokenDatabase.SaveToken(result);
                    if(Device.OS == TargetPlatform.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new Dashboard());
                    }
                    else if(Device.OS == TargetPlatform.iOS)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new Dashboard()));
                    }
                }
            }
            else
            {
                 DisplayAlert("Login", "Login Failure!", "Ok");
            }

        }
    }
}