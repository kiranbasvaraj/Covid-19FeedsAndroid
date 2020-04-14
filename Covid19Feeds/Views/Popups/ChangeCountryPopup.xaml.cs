using System;
using System.Collections.Generic;
using System.Diagnostics;
using Covid19Feeds.Helpers;
using Covid19Feeds.Models;
using Covid19Feeds.ViewModels;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace Covid19Feeds.Views.Popups
{
    public partial class ChangeCountryPopup : PopupPage
    {
        public ChangeCountryPopup()
        {
            InitializeComponent();
            cv.SelectionChanged += Cv_SelectionChanged;
        }

        private async void Cv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                var vm = this.BindingContext as DashboardViewModel;
                Setting.SelectedCountry = (cv.SelectedItem as AllCountriesCasesModel).country;
                await vm.ChooseDEaflutCountry();
                await Navigation.PopPopupAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        protected override bool OnBackgroundClicked()
        {
            base.OnBackgroundClicked();
            return false;


        }
    }
}
