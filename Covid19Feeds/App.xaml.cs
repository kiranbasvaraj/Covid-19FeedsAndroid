using eliteKit;
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
          //  Core.initializeKit(typeof(App).GetTypeInfo().Assembly);
            MainPage = new MainPage();
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
