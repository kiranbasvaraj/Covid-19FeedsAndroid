using System;
using System.Collections.Generic;
using Covid19Feeds.Views.ContentViews;
using Xamarin.Forms;

namespace Covid19Feeds.Views
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
            CountriesView.ItemTappedHandler += CountriesView_ItemTappedHandler;
        }

        private void CountriesView_ItemTappedHandler(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CovidDetailsPage());
        }
    }
}
