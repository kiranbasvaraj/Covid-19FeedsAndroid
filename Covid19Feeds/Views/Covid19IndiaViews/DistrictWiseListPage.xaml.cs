using System;
using System.Collections.Generic;
using Covid19Feeds.Models;
using Covid19Feeds.ViewModels.Covid19IndiaViewModels;
using Xamarin.Forms;
using System.Linq;
using System.Diagnostics;

namespace Covid19Feeds.Views.Covid19IndiaViews
{
    public partial class DistrictWiseListPage : ContentPage
    {
        private Statewise item;
        private StateAndDistrictPageViewModel vm => BindingContext as StateAndDistrictPageViewModel;



        public DistrictWiseListPage(Statewise item)
        {
            try
            {

                InitializeComponent();
                this.item = item;
                state.Text = item.state;
                date.Text = item.lastupdatedtime;
                confirmed.Text = item.confirmed;
                active.Text = item.active;
                recovered.Text = item.recovered;
                deaths.Text = item.deaths;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            

        }

        protected override void OnAppearing()
        {
            try
            {

                base.OnAppearing();
               
                cv.ItemsSource = vm.StateDistrictList.Where(x => x.state.ToLower() == item.state.ToLower()).FirstOrDefault()?.districtData;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            

        }
    }
}
