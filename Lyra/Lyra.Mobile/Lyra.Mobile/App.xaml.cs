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
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new SignUpPage();
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
