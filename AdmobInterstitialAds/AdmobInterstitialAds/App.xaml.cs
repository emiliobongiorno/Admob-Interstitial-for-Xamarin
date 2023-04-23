using AdmobInterstitialAds.InterstitialSample;
using Xamarin.Forms;

namespace AdmobInterstitialAds
{
    public partial class App : Application
    {

        public static IAdInterstitial adInterstitial;

        public App ()
        {
            InitializeComponent();

            adInterstitial = DependencyService.Get<IAdInterstitial>();

            MainPage = new MainPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }

    }
}

