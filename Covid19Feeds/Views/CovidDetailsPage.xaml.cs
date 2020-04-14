using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Covid19Feeds.Models;
using Covid19Feeds.ViewModels;
using Xamarin.Forms;

namespace Covid19Feeds.Views
{
    public partial class CovidDetailsPage : ContentPage
    {
        public AllCountriesCasesModel item;

        public CovidDetailsPage()
        {
            InitializeComponent();

        }

        public CovidDetailsPage(AllCountriesCasesModel item)
        {

            try
            {
                /**/
                InitializeComponent();
                if (item != null)
                {
                    this.item = item;
                    country.Text = item.country.ToString();
                    flag.Source = item.countryInfo.flag.ToString();
                    tests.Text = item.tests.ToString();
                    criticalcases.Text = item.critical.ToString();
                    casespermiilion.Text = item.casesPerOneMillion.ToString();
                    testpermillion.Text = item.testsPerOneMillion.ToString();
                    deathspermillion.Text = item.deathsPerOneMillion.ToString();
                    totalcases.Text = item.cases.ToString();
                    todayscases.Text = item.todayCases.ToString();
                    deaths.Text = item.deaths.ToString();
                    todaysdeaths.Text = item.todayDeaths.ToString();
                    recovered.Text = item.recovered.ToString();
                    active.Text = item.active.ToString();


                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }

        }

        private async void OnSwiped(object s, SwipedEventArgs e)
        {
            await Navigation.PopModalAsync();
        }


    }
}
