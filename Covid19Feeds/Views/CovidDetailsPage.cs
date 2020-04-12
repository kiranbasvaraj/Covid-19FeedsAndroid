using System;

using Xamarin.Forms;

namespace Covid19Feeds.Views
{
    public class CovidDetailsPage : ContentPage
    {
        public CovidDetailsPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

