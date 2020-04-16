using Covid19Feeds.Views;
using Covid19Feeds.Views.Covid19IndiaViews;
using Covid19Feeds.Views.CovidInformViews;
using eliteKit;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19Feeds
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Core.initializeKit(typeof(App).GetTypeInfo().Assembly);
            MainPage = new NavigationPage( new DashboardPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=fa695725-0735-4187-a13b-e98239762a8a;" +
                     "uwp={Your UWP App secret here};" +
                     "ios={Your iOS App secret here}",
                     typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
