using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Covid19Feeds.Views.ContentViews
{
    public partial class CountriesView : ContentView
    {
        public CountriesView()
        {
            InitializeComponent();
            list.ItemsSource = new List<string>() { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        }
    }
}
