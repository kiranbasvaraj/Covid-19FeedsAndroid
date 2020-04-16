using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Covid19Feeds.Models;
using Covid19Feeds.ViewModels;
using Covid19Feeds.ViewModels.Covid19IndiaViewModels;
using Covid19Feeds.Views.Cards.Covid19IndiaCards;
using Xamarin.Forms;

namespace Covid19Feeds.Views.Covid19IndiaViews
{
    public partial class StateListPage : ContentPage
    {
        public StateAndDistrictPageViewModel vm => (StateAndDistrictPageViewModel)BindingContext;
        public StateListPage()
        {
            try
            {

                InitializeComponent();
                Task.Run(async () =>
                {
                    await vm.GetStateDataAsync();
                    await vm.GetStateAndDistrictDataAsync();
                }).GetAwaiter();

            }
            catch (Exception ex)
            {

            }

        }
        private async void OnSearch(object s, TextChangedEventArgs e)
        {

            try
            {
                string serachValue = e.NewTextValue;

                if (string.IsNullOrWhiteSpace(serachValue))
                {
                    list.ItemsSource = vm.StateDataModel.statewise;
                    indicatorlabl.IsVisible = false;
                }
                else
                {

                    var item = vm.StateDataModel.statewise.Where(x => x.state.ToLower().StartsWith(serachValue.ToLower())).ToList();
                    if (item.Count > 0)
                    {
                        list.ItemsSource = item;
                        indicatorlabl.IsVisible = false;
                    }
                    else
                    {
                        indicatorlabl.IsVisible = true;
                        list.ItemsSource = item;
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.StackTrace);
            }

        }
        protected async override void OnAppearing()
        {
           
            base.OnAppearing();
            


        }

        private async void OnStateTapped(object s, EventArgs e)
        {

           
            Statewise item = (s as StateCardView).BindingContext as  Statewise;

            DistrictWiseListPage page = new DistrictWiseListPage(item);
            page.BindingContext = vm;

            await Navigation.PushAsync(page);
        }
    }


}
