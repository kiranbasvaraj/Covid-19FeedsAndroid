using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Covid19Feeds.Views.CovidInformViews;
using WantToWork.Helpers;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Covid19Feeds.ViewModels
{
    public class AboutMePageViewModel : BaseViewModel
    {
        public Command OpenFaceBookCommand { get; set; }
        public Command OpenInstaCommand { get; set; }
        public Command OpenTwitterCommand { get; set; }
        public Command OpenLinkedinCommand { get; set; }

        public AboutMePageViewModel()
        {
            OpenFaceBookCommand = new Command(async () => await OpenFaceBook());
            OpenTwitterCommand = new Command(async () => await OpenTwitter());
            OpenInstaCommand = new Command(async () => await OpenInstagram());
            OpenLinkedinCommand = new Command(async () => await OpenLinkedin());
        }

        private async Task OpenInstagram()
        {
        
            bool isSupported = await Launcher.CanOpenAsync(AppConstants.InstagramUrl);
            if (isSupported)
            {
               await Launcher.OpenAsync(AppConstants.InstagramUrl);
            }
            else
            {

            }

        }

        private async Task OpenTwitter()
        {
            bool isSupported = await Launcher.CanOpenAsync(AppConstants.TwitterUrl);
            if (isSupported)
            {
                await Launcher.OpenAsync(AppConstants.TwitterUrl);
            }
            else
            {

            }
        }

        private async Task OpenFaceBook()
        {
            bool isSupported = await Launcher.CanOpenAsync(AppConstants.FaceBookUrl);
            if (isSupported)
            {
                await Launcher.OpenAsync(AppConstants.FaceBookUrl);
            }
            else
            {

            }
        }

        private async Task OpenLinkedin()
        {
            bool isSupported = await Launcher.CanOpenAsync(AppConstants.LinkedInUrl);
            if (isSupported)
            {
                await Launcher.OpenAsync(AppConstants.LinkedInUrl);
            }
            else
            {

            }
        }
    }


   

}

