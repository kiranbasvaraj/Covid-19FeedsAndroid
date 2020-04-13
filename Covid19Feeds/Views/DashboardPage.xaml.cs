using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Covid19Feeds.ViewModels;
using Covid19Feeds.Views.ContentViews;
using Xamarin.Forms;

namespace Covid19Feeds.Views
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            CountriesView.ItemTappedHandler += CountriesView_ItemTappedHandler;
            var vm = this.BindingContext as DashboardViewModel;
            Task.Run(async() => {
               await vm.LoadGlobalCases();
               await vm.LoadAllCountryCases();
            }).GetAwaiter();
           
            vm.ItemSelectionHandler += Vm_ItemSelectionHandler;
        }

        private async void Vm_ItemSelectionHandler(object sender, EventArgs e)
        {
            var vm = this.BindingContext as DashboardViewModel;
            //vm.SeletedItem = null;
            await Navigation.PushModalAsync(new CovidDetailsPage() );
        }

        private void CountriesView_ItemTappedHandler(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CovidDetailsPage());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
        
       

        }

        
    }
}
