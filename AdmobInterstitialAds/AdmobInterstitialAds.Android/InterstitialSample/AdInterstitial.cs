using Android.Gms.Ads;
using Android.Gms.Ads.Interstitial;
using AdmobInterstitialAds.InterstitialSample;
using AdmobInterstitialAds.Droid.InterstitialSample;
using Xamarin.Forms;

[assembly: Dependency(typeof(AdInterstitial))]
namespace AdmobInterstitialAds.Droid.InterstitialSample
{
    public class AdInterstitial : IAdInterstitial
    {
        public static InterstitialAd interstitialAd;
        public static bool adLoaded;

        public AdInterstitial()
        {
            adLoaded = false;
            LoadAd();
        }

        void LoadAd()
        {
            InterstitialAd.Load(Android.App.Application.Context, "ca-app-pub-ca-app-pub-0000000000000000/0000000000", new AdRequest.Builder().Build(), new InterstitialCallbackinherit());
        }

        public bool ShowAd()
        {
            if (AdInterstitial.adLoaded)
            {
                interstitialAd.Show(MainActivity.instance);
                LoadAd();
                return true;
            }
            return false;
        }

    }
}
