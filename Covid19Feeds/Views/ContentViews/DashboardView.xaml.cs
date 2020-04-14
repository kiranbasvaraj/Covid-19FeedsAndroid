using System;
using System.Collections.Generic;
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



    }
}
