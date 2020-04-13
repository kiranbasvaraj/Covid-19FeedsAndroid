using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISmart.Helpers
{
    public class Setting
    {

        private static ISettings AppSettings => CrossSettings.Current;

        public static string AppUserId
        {
            get => AppSettings.GetValueOrDefault(nameof(AppUserId), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(AppUserId), value);
        }
        public static string ConcernsGuid
        {
            get => AppSettings.GetValueOrDefault(nameof(ConcernsGuid), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(ConcernsGuid), value);
        }
        public static string AppLanguage
        {
            get => AppSettings.GetValueOrDefault(nameof(AppLanguage), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(AppLanguage), value);
        }
        public static string AppUserMobileNumber
        {
            get => AppSettings.GetValueOrDefault(nameof(AppUserMobileNumber), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(AppUserMobileNumber), value);
        }
        public static bool IsUserRegistered
        {
            get => AppSettings.GetValueOrDefault(nameof(IsUserRegistered),false);
            set => AppSettings.AddOrUpdateValue(nameof(IsUserRegistered), value);
        }

        public static string SuggestionsEndpoint
        {
            get => AppSettings.GetValueOrDefault(nameof(SuggestionsEndpoint), ISmart.Helpers.AppConstants.DefaultSuggestionsEndpoint);

            set => AppSettings.AddOrUpdateValue(nameof(SuggestionsEndpoint), value);
        }

        public static string FallbackMapsLocation
        {
            get => AppSettings.GetValueOrDefault(nameof(FallbackMapsLocation), AppConstants.DefaultFallbackMapsLocation);

            set => AppSettings.AddOrUpdateValue(nameof(FallbackMapsLocation), value);
        }

        public static string AppUserName
        {
            get => AppSettings.GetValueOrDefault(nameof(AppUserName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(AppUserName), value);
        }
        public static bool IsBuyer
        {
            get => AppSettings.GetValueOrDefault(nameof(IsBuyer), false);
            set => AppSettings.AddOrUpdateValue(nameof(IsBuyer), value);
        }

        public static string BuyerUserId
        {
            get => AppSettings.GetValueOrDefault(nameof(BuyerUserId), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(BuyerUserId), value);
        }
    }
}
