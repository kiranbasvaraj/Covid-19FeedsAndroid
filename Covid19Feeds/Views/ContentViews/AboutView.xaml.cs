using System;
using System.Collections.Generic;
using Covid19Feeds.Views.CovidInformViews;
using Xamarin.Forms;

namespace Covid19Feeds.Views.ContentViews
{
    public partial class AboutView : ContentView
    {
        public AboutView()
        {
            InitializeComponent();
        }
        private async void OnAboutMeTapped(object s, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AboutUsPage());
        }
        public async void OnResourceTapped(object s, EventArgs e)
        {
            await Navigation.PushAsync(new ResourcesUsedPage());
        }





    }
}
