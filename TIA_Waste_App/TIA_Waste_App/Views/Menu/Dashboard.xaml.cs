using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIA_Waste_App.Models;
using TIA_Waste_App.Views.DetailViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Share;

namespace TIA_Waste_App.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            App.StartCheckIfInternet(lbl_NoInternet, this);
        }

        async void AccountInfo(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new InfoScreen1());
            CrossShare.Current.OpenBrowser("https://youtu.be/Y8qtmD_QTYw"); // link to website >> http://13.93.71.77/
        }
    }
}