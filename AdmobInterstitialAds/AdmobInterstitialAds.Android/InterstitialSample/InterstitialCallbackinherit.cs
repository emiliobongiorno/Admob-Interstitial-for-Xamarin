using Android.Gms.Ads;

namespace AdmobInterstitialAds.Droid.InterstitialSample
{
    public class InterstitialCallbackinherit : InterstitialCallback
    {


        public override void OnAdLoaded(Android.Gms.Ads.Interstitial.InterstitialAd interstitialAd)
        {
            AdInterstitial.interstitialAd = interstitialAd;
            base.OnAdLoaded(interstitialAd);
            AdInterstitial.adLoaded = true;

        }
        public override void OnAdFailedToLoad(LoadAdError p0)
        {
            base.OnAdFailedToLoad(p0);
            AdInterstitial.adLoaded = false;
        }
    }
}

