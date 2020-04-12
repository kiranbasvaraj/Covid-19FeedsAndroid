using System;
using System.Collections.Generic;
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
            ItemTappedHandler?.Invoke(s,e);

        }
    }
}
