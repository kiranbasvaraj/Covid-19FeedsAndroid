using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Covid19Feeds.ViewModels
{
    public class ResourcesUsedPageViewModel
    {
        public Command<string> OpenUriCommand { get; set; }
        public ResourcesUsedPageViewModel()
        {
            OpenUriCommand = new Command<string>((x) => OpenBrowser(x));
        }


        private void OpenBrowser(string x)
        {
            switch (x)
            {
                case "api":
                    Launcher.OpenAsync(new Uri("https://corona.lmao.ninja/docs/#/Countries/get_v2_countries__query_"));
                    break;

                case "api2":
                    Launcher.OpenAsync(new Uri("https://api.covid19india.org/"));
                    break;
                case "who":
                    Launcher.OpenAsync(new Uri("https://www.who.int/news-room/q-a-detail/q-a-coronaviruses"));
                    break;
                case "xamarin":
                    Launcher.OpenAsync(new Uri("https://docs.microsoft.com/en-us/xamarin/xamarin-forms/"));
                    break;
                default:
                    break;
            }

        }
    }
}
