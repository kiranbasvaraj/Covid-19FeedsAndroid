using System;
namespace WantToWork.Helpers
{
    public class AppConstants
    {
        public AppConstants()
        {
        }

        public static string TabChanged = "TabChange";


        public static string BaseUrl = "https://corona.lmao.ninja/v2/";
        public static string LoadGlobalCasesAPi = BaseUrl+"all?yesterday=true";
        public static string LoadAllCountryCasesAPi = BaseUrl + "countries?yesterday=true&sort=cases";


    }
}
