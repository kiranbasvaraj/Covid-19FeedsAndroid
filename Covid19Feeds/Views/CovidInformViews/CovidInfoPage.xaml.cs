using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Covid19Feeds.Views.CovidInformViews
{
    public partial class CovidInfoPage : ContentPage
    {
        public CovidInfoPage()
        {
            InitializeComponent();
        }


        private async void OnFaqTapped(object s,EventArgs e)
        {
           await  Navigation.PushAsync(new FAQPage());

        }
    }
}
