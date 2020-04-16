using System;
using System.Collections.Generic;
using System.Diagnostics;
using Covid19Feeds.Models;
using Covid19Feeds.Views.Covid19IndiaViews;
using Covid19Feeds.Views.CovidInformViews;
using Xamarin.Forms;

namespace Covid19Feeds.Views.ContentViews
{
    public partial class DashboardView : ContentView
    {
        public static event EventHandler ItemTappedHandler;
        public DashboardView()
        {
            InitializeComponent();
            // cv.SelectionChanged += Cv_SelectionChanged;

            
        }

        private async void OnKnowMoreTapped(object s,EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CovidInfoPage());
        }
        private async void OnIndiaTapped(object s, EventArgs e)
        {
            if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new StateListPage());
            }
           
            
        }

        private async void OnCVTapped(object s, EventArgs e)
        {
            try
            {

                AllCountriesCasesModel SeletedItem = (s as StackLayout).BindingContext as AllCountriesCasesModel;
                await Application.Current.MainPage.Navigation.PushModalAsync(new CovidDetailsPage(SeletedItem));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

       

        

    }
}
