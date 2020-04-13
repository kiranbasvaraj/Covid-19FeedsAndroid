using System;
using System.Collections.Generic;
using Covid19Feeds.Models;
using Covid19Feeds.ViewModels;
using Xamarin.Forms;
using System.Linq;
using System.Diagnostics;

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

        private async void OnSearch(object s, TextChangedEventArgs e)
        {
            var vm = this.BindingContext as DashboardViewModel;
            try
            {
                string serachValue = e.NewTextValue;

                if (string.IsNullOrWhiteSpace(serachValue))
                {
                    list.ItemsSource = vm.SearchedList;
                }
                else
                {

                    list.ItemsSource = vm.SearchedList.Where(x => x.country.ToLower().StartsWith(serachValue.ToLower()));
                    
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.StackTrace);
            }
            

        }
    }
}
