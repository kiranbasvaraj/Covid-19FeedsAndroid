using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Covid19Feeds.Views.ContentViews
{
    public partial class AboutView : ContentView
    {
        public AboutView()
        {
            InitializeComponent();
        }

        public async void OnResourceTapped(object s,EventArgs e)
        {
            await Navigation.PushAsync(new ResourcesUsedPage());
        }

        public async void OnFeedbackTapped(object s, EventArgs e)
        {
        }


        public async void OnShareTapped(object s, EventArgs e)
        {
        }


        public async void OnAboutmeTapped(object s, EventArgs e)
        {
        }

    }
}
