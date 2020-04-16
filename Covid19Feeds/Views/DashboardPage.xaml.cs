using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Covid19Feeds.ViewModels;
using Covid19Feeds.Views.ContentViews;
using Covid19Feeds.Views.Popups;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace Covid19Feeds.Views
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            try
            {
                /**/
                InitializeComponent();
                NavigationPage.SetHasNavigationBar(this, false);

                var vm = this.BindingContext as DashboardViewModel;
                Task.Run(async () =>
                {
                    await vm.LoadGlobalCases();
                    await vm.LoadAllCountryCases();
                    // 

                }).GetAwaiter();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }

            // vm.ItemSelectionHandler += Vm_ItemSelectionHandler;

        }



        private void CountriesView_ItemTappedHandler(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CovidDetailsPage());
        }

        protected async override void OnAppearing()
        {
            try
            {
                /**/
                base.OnAppearing();
                var vm = this.BindingContext as DashboardViewModel;
              
                MessagingCenter.Subscribe<Object>(this, "PopupEvent", async (s) =>
                {

                    var page = new ChangeCountryPopup();
                    page.BindingContext = vm;
                    await Navigation.PushPopupAsync(page);



                });

                //await vm.ChooseDEaflutCountry();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }


        }
        protected override void OnDisappearing()
        {
            try
            {

                base.OnDisappearing();
                CountriesView.ItemTappedHandler -= CountriesView_ItemTappedHandler;
                MessagingCenter.Unsubscribe<object>(this, "PopupEvent");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
    }


}

