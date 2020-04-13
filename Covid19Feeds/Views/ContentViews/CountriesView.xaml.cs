using System;
using System.Collections.Generic;
using Covid19Feeds.Models;
using Xamarin.Forms;

namespace Covid19Feeds.Views.ContentViews
{
    public partial class CountriesView : ContentView
    {
        public static event EventHandler ItemTappedHandler;
        public CountriesView()
        {
            InitializeComponent();
          //  list.ItemsSource = new List<string>() { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        }

        private async void ListItemTapped(object s,ItemTappedEventArgs e)
        {
            // ItemTappedHandler?.Invoke(s,e);
      
          var  item=  e.Item as AllCountriesCasesModel;
            await Navigation.PushModalAsync(new CovidDetailsPage(item));

        }
    }
}
