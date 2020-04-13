using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Feeds.Helpers
{
    public class Setting
    {

        private static ISettings AppSettings => CrossSettings.Current;

        public static string SelectedCountry
        {
            get => AppSettings.GetValueOrDefault(nameof(SelectedCountry), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(SelectedCountry), value);
        }
        
      
    }
}
