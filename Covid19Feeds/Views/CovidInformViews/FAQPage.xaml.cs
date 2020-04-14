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
            var vm = this.BindingContext as CovidInformationViewModel;
            vm.LoadFaqs();

        }


    }
}
