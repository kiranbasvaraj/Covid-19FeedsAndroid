using System;
using Android.Content;
using Covid19Feeds.Droid.DependencyServices;
using Covid19Feeds.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

[assembly: Dependency(typeof(DroidOpenMap))]
namespace Covid19Feeds.Droid.DependencyServices
{
    public class DroidOpenMap: IOpenMap
    {
       private string x="Food Shelter Near Me";
        public DroidOpenMap()
        {
        }

        public void OpenMap()
        {
            // String url = "http://maps.google.com/maps?daddr=" + x;
            string url = "https://www.google.com/maps/search/food+shelters+near+me";

            Android.Content.Intent intent = new Android.Content.Intent(Intent.ActionView,Android.Net.Uri.Parse(url));
          
          Forms.Context.StartActivity(intent);
        }
    }
}
