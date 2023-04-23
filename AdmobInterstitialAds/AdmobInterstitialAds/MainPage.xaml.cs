using System;
using Xamarin.Forms;

namespace AdmobInterstitialAds
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            if (!App.adInterstitial.ShowAd())
            {
                await DisplayAlert("Alert", "The ad is not loaded yet", "OK");
            }
        }
    }
}

