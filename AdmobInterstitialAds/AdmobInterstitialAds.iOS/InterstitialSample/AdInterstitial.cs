using Google.MobileAds;
using UIKit;
using Xamarin.Forms;
using AdmobInterstitialAds.InterstitialSample;
using AdmobInterstitialAds.iOS.InterstitialSample;

[assembly: Dependency(typeof(AdInterstitial))]
namespace AdmobInterstitialAds.iOS.InterstitialSample
{
    public class AdInterstitial : IAdInterstitial
    {
        InterstitialAd adInterstitial;

        public AdInterstitial()
        {
            LoadAd();

        }

        void LoadAd()
        {

            if (adInterstitial == null)
            {
                InterstitialAd.Load("ca-app-pub-0000000000000000/0000000000", Request.GetDefaultRequest(), (ad, err) => {
                    if (ad != null)
                    {
                        adInterstitial = ad;

                        adInterstitial.DismissedContent += (sender, e) => {

                            // You need to explicitly Dispose Interstitial when you dont need it anymore
                            // to avoid crashes if pending request are in progress
                            adInterstitial.Dispose();
                            adInterstitial = null;
                        };
                    }
                });
            }

        }

        public bool ShowAd()
        {

            if (adInterstitial != null)
            {

                adInterstitial.Present(GetVisibleViewController());
                return true;
            }
            else
            {
                LoadAd();
            }
            return false;
        }

        UIViewController GetVisibleViewController()
        {
            var rootController = UIApplication.SharedApplication.KeyWindow.RootViewController;

            if (rootController.PresentedViewController == null)
                return rootController;

            if (rootController.PresentedViewController is UINavigationController)
            {
                return ((UINavigationController)rootController.PresentedViewController).VisibleViewController;
            }

            if (rootController.PresentedViewController is UITabBarController)
            {
                return ((UITabBarController)rootController.PresentedViewController).SelectedViewController;
            }

            return rootController.PresentedViewController;
        }


    }
}