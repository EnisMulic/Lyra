using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lyra.Mobile.Services;
using Lyra.Mobile.Views;

namespace Lyra.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            string licenseKey = "MzE0NjExQDMxMzgyZTMyMmUzMGJWRHQxbFR5RHpaZUVUT0lwUWFocmVGNVIyeWNwWDNlVlpyb2d2aE1GTUE9";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);

            InitializeComponent();

            MainPage = new SignInPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
