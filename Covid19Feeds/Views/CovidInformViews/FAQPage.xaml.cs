using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Covid19Feeds.ViewModels;
using Covid19Feeds.Views.ContentViews;
using Xamarin.Forms;

namespace Covid19Feeds.Views.CovidInformViews
{
    public partial class FAQPage : ContentPage
    {
        public FAQPage()
        {
            InitializeComponent();
            //    Task addUI = new Task(() =>
            //    {
            //        var vm = this.BindingContext as CovidInformationViewModel;
            //        var x = new FAQTemplate();
            //        x.BindingContext = vm;
            //        SV.Content = x;
            //    }

            //    )};
            //Device.b


            Device.BeginInvokeOnMainThread(async() => {
                var vm = this.BindingContext as CovidInformationViewModel;
                var x = new FAQTemplate();
                x.BindingContext = vm;
                SV.Content = x;
            
            });

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

          
            

        }
    }
}
