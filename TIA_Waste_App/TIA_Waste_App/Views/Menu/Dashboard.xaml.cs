using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIA_Waste_App.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Share;
using Xamarin.Essentials;
using System.Net.Http;

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
            await CrossShare.Current.OpenBrowser("https://youtu.be/Y8qtmD_QTYw"); // link to website >> http://13.93.71.77/
        }

        async void CaptureImage(object sender, EventArgs e)
        {
            var CapturedImage = await MediaPicker.CapturePhotoAsync();
            if (CapturedImage != null)
            {
                var stream = await CapturedImage.OpenReadAsync();

                resultImage.Source = ImageSource.FromStream(() => stream);
            }
        }

         void SubmitPicture(object sender, EventArgs e)
        {
            
        }
    }
}